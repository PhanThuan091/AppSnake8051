
#include <reg51.h>
#include <intrins.h>
#include <stdlib.h>

//#define KIT  // chay mo phong --> comment doan nay

sbit SH = P3 ^ 6;
sbit ST = P3 ^ 5;
sbit R = P3 ^ 4;
bit over = 0;
sbit up = P3 ^ 1;
sbit down = P3 ^ 0;
sbit left = P3 ^ 2;
sbit right = P3 ^ 3;
#define uchar unsigned char
#define SNAKE 40  // Maximum length of the SNAKE
#define TIME 15	  // delay time
#define SPEED 100 // snake speed
#define COMMONPORTS P0
uchar x[SNAKE + 1]; // cot, truc tung
uchar y[SNAKE + 1]; // hang, truc hoanh
unsigned int TIME1;
unsigned char mousex, mousey;
uchar n, i, e;
char addx, addy;
unsigned char dcount;
// uchar a[2] = 0;
bit Mang1;
bit Mang2;
bit Mang3;
bit Mang4;
bit Mang5;
bit Mang6;
bit Mang7;
bit Mang8;

unsigned char code TAB[8] = {0x7f, 0xbf, 0xdf, 0xef, 0xf7, 0xfb, 0xfd, 0xfe};
unsigned char code SAD[2][8] = {{0x3C, 0x42, 0xA5, 0x89, 0x89, 0xA5, 0x42, 0x3C}, // h4
								{0x3C, 0x42, 0xA9, 0x89, 0x89, 0xA9, 0x42, 0x3C}};
unsigned char code intro[3][8] = {{0x18, 0x18, 0x18, 0xE7, 0xE7, 0x18, 0x18, 0x18},
								  {0x42, 0xE7, 0x7E, 0x24, 0x24, 0x7E, 0xE7, 0x42},
								  {0x18, 0x18, 0x18, 0xE7, 0xE7, 0x18, 0x18, 0x18}};

unsigned char code NUMCODEright[11][8] = {
	{0x00, 0x00, 0x00, 0x00, 0x3E, 0x41, 0x41, 0x3E}, // 0
	{0x00, 0x00, 0x00, 0x00, 0x00, 0x21, 0x7F, 0x01}, // 1
	{0x00, 0x00, 0x00, 0x00, 0x27, 0x49, 0x49, 0x31}, // 2
	{0x00, 0x00, 0x00, 0x00, 0x00, 0x49, 0x49, 0x7F},
	{0x00, 0x00, 0x00, 0x00, 0x08, 0x18, 0x28, 0x7F}, // 4
	{0x00, 0x00, 0x00, 0x00, 0x79, 0x49, 0x49, 0x46},
	{0x00, 0x00, 0x00, 0x00, 0x3E, 0x49, 0x49, 0x06},
	{0x00, 0x00, 0x00, 0x00, 0x00, 0x40, 0x4F, 0x70}, // 7
	{0x00, 0x00, 0x00, 0x00, 0x36, 0x49, 0x49, 0x36},
	{0x00, 0x00, 0x00, 0x00, 0x30, 0x49, 0x49, 0x3E},

}; // 10

unsigned char code NUMCODEleft[11][8] = {
	{0x3E, 0x41, 0x41, 0x3E, 0x00, 0x00, 0x00, 0x00}, // 0
	{0x21, 0x7F, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0},		  // 1
	{0x27, 0x49, 0x49, 0x31, 0x00, 0x00, 0x00, 0x00}, // 2
	{0x49, 0x49, 0x7F, 0x00, 0x00, 0x00, 0x00, 0x00}, // 3
	{0x18, 0x28, 0x7F, 0x00, 0x00, 0x00, 0x00, 0x00}, // 4
	{0x79, 0x49, 0x49, 0x46, 0x00, 0x00, 0x00, 0x00}, // 5
	{0x3E, 0x49, 0x49, 0x06, 0x00, 0x00, 0x00, 0x00}, // 6
	{0x40, 0x47, 0x48, 0x70, 0x00, 0x00, 0x00, 0x00}, // 7
	{0x36, 0x49, 0x49, 0x36, 0x00, 0x00, 0x00, 0x00}, // 8
	{0x30, 0x49, 0x49, 0x3E, 0x00, 0x00, 0x00, 0x00}, // 9
};

// Delay
//  7HC595

sbit beep = P2 ^ 5;
unsigned char flag = 0; // flag to know when you received data
unsigned char revData;	// byte to save data from computer

void serial_init(void)
{
	TMOD = 0x20; // Timer 1, 8bit, auto reload
	TH1 = 0xFD;	 // toc do 9600
	SCON = 0x50; // su dung timer 1
	TR1 = 1;	 // bat dau timer 1

	EA = 1; // enabale inter all
	ES = 1; // enable inter serial
}


void serial_Send(unsigned char x)
{
	SBUF = x; // buff a chacrater to buffer
	while (TI == 0)
		;	// waiting transmitting complete
	TI = 0; // claer flag
}

void serial_ISR(void) interrupt 4
{

	if (RI == 1)
	{					// interrupt when received data
		revData = SBUF; // read data and save it to revData
		RI = 0;			// clear flag
		flag = 1;
	}
		
}
void Hc595SendByte(unsigned char dat) // dung de chay hieu ung 
{
	unsigned char a;
	SH = 0;
	ST = 0;
	for (a = 0; a < 8; a++)
	{
		R = dat >> 7;
		dat <<= 1;

		SH = 1; //

		SH = 0;
	}

	ST = 1;

	ST = 0;
}
void ISR_timer0() interrupt 1
{
	TH0 = 0xFC;
	TL0 = 0x18; //timer 0: 1ms
	dcount++;
}

void delay(char MS) // delay va tao seed cho random
{
	while (MS != 0)
	{
		MS--;
		if (dcount > 7) // dcount dung de tao ra seed cho random
		{
			dcount = 0;
		}
	}
}

void delay10ms() // delay 10ms
{
	unsigned char i, j;
	for (i = 1; i > 0; i--)
		for (j = 128; j > 0; j--)
			;
}

void display(uchar v); // goi ra truoc 

void mux1(uchar temp) // quet tung cot, gan moi cot la gnd
{
	switch (temp)
	{
	case 1:
		P0 = TAB[0];
		break;
	case 2:
		P0 = TAB[1];
		break;
	case 3:
		P0 = TAB[2];
		break;
	case 4:
		P0 = TAB[3];
		break;
	case 5:
		P0 = TAB[4];
		break;
	case 6:
		P0 = TAB[5];
		break;
	case 7:
		P0 = TAB[6];
		break;
	case 8:
		P0 = TAB[7];
		break;
		// default:
		// P0 = TAB [0];
		// break;
	}
}
void mux(uchar temp) // ham cho ic 74hc595 cho snake
{
	Mang1 = 0;
	Mang2 = 0;
	Mang3 = 0;
	Mang4 = 0;
	Mang5 = 0;
	Mang6 = 0;
	Mang7 = 0;
	Mang8 = 0;

	switch (temp)
	{
	case 1:
		Mang1 = 1;
		break;
	case 2:
		Mang2 = 1;
		break;
	case 3:
		Mang3 = 1;
		break;
	case 4:
		Mang4 = 1;
		break;
	case 5:
		Mang5 = 1;
		break;
	case 6:
		Mang6 = 1;
		break;
	case 7:
		Mang7 = 1;
		break;
	case 8:
		Mang8 = 1;
		break;
	}

	SH = 0; // cho phep dich bit qua
	ST = 0; // cho phep dich 8 bit
	R = 0; // tao bit de dich

	R = Mang8;
	SH = 1;
	SH = 0;
	R = Mang7;
	SH = 1;
	SH = 0;
	R = Mang6;
	SH = 1;
	SH = 0;
	R = Mang5;
	SH = 1;
	SH = 0;
	R = Mang4;
	SH = 1;
	SH = 0;
	R = Mang3;
	SH = 1;
	SH = 0;
	R = Mang2;
	SH = 1;
	SH = 0;
	R = Mang1;
	SH = 1;
	SH = 0;

	ST = 1;
	ST = 0;
}
void GameOver() // khi thua thi hien diem 
{
	// con so moi matrix tu tao
	unsigned char tab, i, j;
	// Hien thi diem
	for (i = 0; i < 50; i++)
	{
		for (tab = 0; tab < 8; tab++)
		{
			Hc595SendByte(0x00);
			COMMONPORTS = TAB[tab];
			Hc595SendByte(NUMCODEright[n % 10][tab]); // hang don vi

			COMMONPORTS = TAB[tab];
			Hc595SendByte(NUMCODEleft[n / 10][tab]); // hang chuc
			delay10ms();
		}
	}
	j++;
	if (j == 11) 
	{
		j = 0;
	}
}
/*****************
check buttons
*****************/
void playSound(unsigned int frequency, unsigned int duration)
{
	int i;
	// bam xung de tao am thanh mong muon
	for (i = 0; i < duration; i++) // thoi gian keo dai
	{
		beep = 1;
		delay(frequency); // tan so
		beep = 0;
		delay(frequency);
	}
}
void turnkey() // kiem tra nut nhan 
{
	if (down == 0)
	{
		// delay10ms();
		delay(TIME1);
		if (down == 0)
		{
			addy = 0;
			if (addx != 1) // neu khong phai di len
				addx = -1; // thi di xuong
			else
				addx = 1; 
		}
	}
	if (up == 0)
	{
		// delay10ms();
		delay(TIME1);
		if (up == 0)
		{
			addy = 0;
			if (addx != -1) // neu khong di xuong
				addx = 1; // thi di len 
			else
				addx = -1;
		}
	}
	if (right == 0)
	{
		// delay10ms();
		delay(TIME1);
		if (right == 0)
		{
			addx = 0;
			if (addy != -1) // neu khong trai
				addy = 1; // queo phai
			else
				addy = -1;
		}
	}
	if (left == 0)
	{
		// delay10ms();
		delay(TIME1);
		if (left == 0) 
		{
			addx = 0;
			if (addy != 1)// neu khong phai 
				addy = -1; // di trai 
			else
				addy = 1;
		}
	}
}

#ifdef KIT		// khi dung cho kit	
void display(uchar v) // hien thi con ran 
{

	while (v--)// thoi gian con ran hien thi buoc tiep theo // speed 
	{
		for (i = 0; i < 41; i++)
		{
			P0 = 0XFF;	// X?a d? tr?nh l?i hi?n th?
			mux(x[i]);	// display Row
			mux1(y[i]); // display coloumn
			turnkey();	// check keys
			delay(TIME1);
			// delay

		}
	}
}

#else // khi dung cho mo phong 
void display(uchar v) // hien thi con ran
{

	while (v--) // thoi gian con ran hien thi buoc tiep theo // speed 
	{
		for (i = 0; i < 41; i++)
		{
			mux(x[i]);	// quet tung hang l� Vcc
			mux1(y[i]); // quet tung cot la gnd 
			turnkey();	// check keys
			delay(TIME1);
			// delay

		}
	}
}

#endif	
		
bit knock() // khi bi chet 
{
	bit k;
	k = 0;
	if (x[1] > 8 || y[1] > 8)
		k = 1; // hits the wall
	if (x[1] + addx < 0 || y[1] + addy < 0)
		k = 1;
	for (i = 2; i < n; i++)
		if ((x[1] == x[i]) && (y[1] == y[i]))
			k = 1; // hits its own body
	return k;
}

void check_level() // check speed form truyen ve
{
	while (1)
	{
		unsigned char i, j, tab;
		if (revData == 0x0A || revData == 0x50 || revData == 0x28)
		{
			flag = 0; // clear flag
			e = SPEED - revData;
			P1 = revData;
			flag = 0;
			break;
		}
		for (i = 0; i < 50; i++)
		{
			for (tab = 0; tab < 8; tab++)
			{
				Hc595SendByte(0x00);
				COMMONPORTS = TAB[tab];
				Hc595SendByte(intro[j][tab]);
				delay10ms();
			}
		}
		j++;
		if (j == 3) // delays
		{
			j = 0;
		}
	}
}
void mouse() // tao chuot
{
	int a;
	int var = dcount;
	srand(var); // tao seed 

creat:
	mousex = rand() % 7;
	mousey = rand() % 7;
	for (a = 0; a < n + 1; a++)
	{
		if (mousex == x[a] && mousey == y[a])
			goto creat;
	}
}
void main()
{
	unsigned char stable, j, tab;
	unsigned int i;

	serial_init();
	while (1)
	{

		check_level();
		revData = 0;
		stable = 1;
		// lam trang bang 
		for (i = 3; i < SNAKE + 1; i++)
			x[i] = 100;
		for (i = 3; i < SNAKE + 1; i++)
			y[i] = 100; // initialization
		mouse();		// fruit
		n = 2;			// start the snake
		x[1] = 1;
		y[1] = 2; // generate the snake's head
		x[2] = 1;
		y[2] = 1; // tail
		addx = 0;
		addy = 1; // di phai
		TIME1 = TIME;

		while (!over)
		{
			
			x[0] = mousex; // fruit
			y[0] = mousey;
			display(e); 
			

			if ((x[0] == x[1] + addx) && (y[0] == y[1] + addy)) // check eating
			{
				n++; // dai them 1 dot
				e = e - 1; // giam toc do moi lan an 
				if (n == 7 * stable)
				{
					TIME1 = TIME1 - 1;
					stable++;
				} // giu on dinh moi khi ran dai 
				mouse(); // tao thuc an moi 
				playSound(100, 20); // phat buzzer moi khi an duoc 
			}
			
///////////////////////////////////////////////
			// dich con ran qua buoc tiep theo 
			for (i = n; i > 1; i--) // dich than ran 
			{
				x[i] = x[i - 1];
				y[i] = y[i - 1];
			}
			// dich dau ran 
			x[1] = x[2] + addx;
			y[1] = y[2] + addy;
///////////////////////////////////////////////
			
			if (knock()) // check the collision
			{
				delay10ms();
				over = 1; // bien kiem tra thua
				serial_Send(n); // gui toi form 
				// hien thi mat buon khi thua 
				j=0;
				for (i = 0; i < 50; i++)
				{
					for (tab = 0; tab < 8; tab++)
					{
						Hc595SendByte(0x00);
						COMMONPORTS = TAB[tab];
						Hc595SendByte(SAD[j][tab]);
						delay10ms();
					}
				}
				revData=0;
				break;
			}
		}

		while (over) // khi thua hien diem va doi lenh tiep theo 
		{
			
			GameOver();
			delay10ms();
			if (revData == 0x0A || revData == 0x50 || revData == 0x28)
			{
				over =0 ;
				break; // break toi vong while to nhat 
			}
		}
	}
}