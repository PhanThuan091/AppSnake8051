using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppSnake8051
{
    public partial class Medium : Form
    {
        Congratulation congratulation = new Congratulation();
        public Medium()
        {
            InitializeComponent();
        }
        private class ScoreInfo
        {
            public string PlayerName { get; set; }
            public int Score { get; set; }
            public int Difficulty { get; set; }
            public DateTime Date { get; set; }
        }
        private void Medium_Load(object sender, EventArgs e)
        {
            try
            {
                serialPort2.Open();
                // Đọc thông tin điểm cao nhất và hiển thị lên labelHighScoreMedium
                string highScoreInfo = ReadHighScore();
                labelHighScoreMedium.Text = string.IsNullOrEmpty(highScoreInfo) ? "Không có điểm cao nhất" : highScoreInfo;
            }
            catch
            {
                MessageBox.Show("Cant open serial");
            }
        }
        private void Medium_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort2.IsOpen)
            { serialPort2.Close(); }
        }

        Action<string> serialPortReceiverAction;
        

        private void buttonStartMedium_Click(object sender, EventArgs e)
        {
            byte speed = 0x00;
            try
            {
                speed = 0x28;
                // Tạo mảng byte chứa giá trị 0xFF và 0x80
                byte[] dataToSend = new byte[] { speed };

                // Gửi mảng byte qua cổng serial
                serialPort2.Write(dataToSend, 0, dataToSend.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialPortReceiverAction = serialPortReceiver;
            try
            {
                // Đọc dữ liệu từ cổng Serial
                string receivedData = serialPort2.ReadExisting();

                // Gọi hàm xử lý dữ liệu và cập nhật UI
                this.BeginInvoke(serialPortReceiverAction, receivedData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu từ cổng Serial: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Hàm xử lý dữ liệu nhận được từ cổng Serial
        private void serialPortReceiver(string input)
        {

            // Hiển thị giá trị byte lên TextBox
            foreach (char chr in input)
            {
                string playerName = "Phan_Thuan";
                int score = (int)((byte)chr);
                int difficulty = 60;
                if (score != 0 && score != 63)
                {
                    labelScoreMedium.Text = ((byte)chr).ToString() + " ";
                    // Kiểm tra nếu có thông tin đầy đủ
                    if (!string.IsNullOrEmpty(playerName))
                    {
                        // Lưu thông tin vào file text
                        SaveHighScore(playerName, score, difficulty);
                        //SaveHighScore("Phuc_Thinh", score, int.Parse(do_kho));
                    }
                }
            }
            string highScoreInfo = ReadHighScore();
            labelHighScoreMedium.Text = string.IsNullOrEmpty(highScoreInfo) ? "Không có điểm cao nhất" : highScoreInfo;
        }
        private string ReadHighScore()
        {
            try
            {
                // Đường dẫn đến file lưu điểm
                string filePath = "D:/Thuan/ThucTap/Kien_truc_may_tinh/Project/App/AppSnake8051 (1)/highscore_medium.txt";

                // Kiểm tra xem file tồn tại không
                if (!File.Exists(filePath))
                {
                    return string.Empty;
                }

                // Đọc tất cả các dòng từ file
                string[] allLines = File.ReadAllLines(filePath);

                // Nếu không có dòng nào, trả về chuỗi trống
                if (allLines.Length == 0)
                {
                    return string.Empty;
                }

                // Tạo một List để lưu trữ thông tin điểm
                List<ScoreInfo> scoresList = new List<ScoreInfo>();

                // Duyệt qua từng dòng để phân tích và thêm vào List
                foreach (var line in allLines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length >= 3 && int.TryParse(parts[1].Trim().Split(':')[1], out int score))
                    {
                        // Lấy thông tin từ dòng và thêm vào List
                        scoresList.Add(new ScoreInfo
                        {
                            PlayerName = parts[0].Trim().Split(':')[1],
                            Score = score,
                            Difficulty = int.Parse(parts[2].Trim().Split(':')[1]),
                        });

                    }
                }

                // Kiểm tra xem có điểm nào không
                if (scoresList.Count > 0)
                {
                    // Sắp xếp List theo điểm và độ khó
                    scoresList = scoresList.OrderByDescending(s => s.Score)
                                           .ThenBy(s => s.Difficulty)
                                           .ToList();
                    // Trả về thông tin điểm cao nhất cho độ khó cụ thể
                    return scoresList.Count > 0
                        ? $"Player: {scoresList[0].PlayerName}, Score: {scoresList[0].Score}, Speed: {scoresList[0].Difficulty}"
                        : string.Empty;
                }
                else
                {
                    return $"Lỗi";
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                return string.Empty;
            }
        }
        private void SaveHighScore(string playerName, int score, int difficulty)
        {
            try
            {
                byte newhs1 = 0x00;
                // Đường dẫn đến file lưu điểm cao nhất
                string highScoreFilePath = "D:/Thuan/ThucTap/Kien_truc_may_tinh/Project/App/AppSnake8051 (1)/highscore_medium.txt";

                // Đọc tất cả các dòng từ file
                string[] allLines = File.ReadAllLines(highScoreFilePath);

                // Tạo một List để lưu trữ thông tin điểm cao nhất
                List<ScoreInfo> highScoresList = new List<ScoreInfo>();
                List<ScoreInfo> scoresList1 = new List<ScoreInfo>();
                // Duyệt qua từng dòng để phân tích và thêm vào List
                foreach (var line in allLines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length >= 3 && int.TryParse(parts[1].Trim().Split(':')[1], out int highScore))
                    {
                        int lineDifficulty = int.Parse(parts[2].Trim().Split(':')[1]);
                        if (lineDifficulty == difficulty)
                        {
                            // Lấy thông tin từ dòng và thêm vào List
                            highScoresList.Add(new ScoreInfo
                            {
                                PlayerName = parts[0].Trim().Split(':')[1],
                                Score = highScore,
                                Difficulty = int.Parse(parts[2].Trim().Split(':')[1])
                            });
                        }
                    }
                }

                // Tìm kiếm xem đã có điểm cao nhất cho độ khó này chưa
                ScoreInfo currentHighScore = highScoresList.FirstOrDefault(s => s.Difficulty == difficulty);

                if (currentHighScore == null || score > currentHighScore.Score)
                {

                    byte newhs = 0x15;
                    newhs1 = newhs;
                    serialPort2.Write(new byte[] { newhs }, 0, 1);
                    // Nếu chưa có hoặc điểm hiện tại lớn hơn điểm cao nhất
                    // Thì cập nhật hoặc thêm mới thông tin điểm cao nhất
                    if (currentHighScore != null)
                    {
                        highScoresList.Remove(currentHighScore);
                    }

                    highScoresList.Add(new ScoreInfo
                    {
                        PlayerName = playerName,
                        Score = score,
                        Difficulty = difficulty
                    });

                    // Ghi thông tin điểm cao nhất vào file
                    File.WriteAllLines(highScoreFilePath, highScoresList.Select(s => $"Player: {s.PlayerName}, Score: {s.Score}, Difficulty: {s.Difficulty}"));
                    congra();
                    
                }
                else
                {
                    byte newhs = 0x24;
                    newhs1 = newhs;
                    serialPort2.Write(new byte[] { newhs }, 0, 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lưu điểm cao nhất: {ex.Message}");
            }
        }

        private void closeTime(object sender, EventArgs e)
        {
            timer1.Stop();
            congratulation.Close();
        }

        public void congra()
        {
            timer1 = new Timer();
            timer1.Interval = 2000;
            timer1.Start();

            timer1.Tick += closeTime;
            congratulation.ShowDialog();
        }
    }
}
