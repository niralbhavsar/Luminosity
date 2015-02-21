/******************************************************\
| AUTHOR: Niral Bhavsar - NiralBhavsar.com             |
| PURPOSE: Windows RGB LED controller using an Arduino |
\******************************************************/

#define REDPIN		6
#define GREENPIN	3
#define BLUEPIN		5

#define REDPIN2		10
#define GREENPIN2	11
#define BLUEPIN2	9

#define BUTTONPIN	2

#define FADESPEED	1		// larger = slower fade
#define SWIRLSPEED	10		// larger = slower fade
#define ON			1
#define OFF			0

unsigned long timerA;
int buttonState;
int lastButtonState;
int buttonValue;

long lastDebounceTime = 0;	// the last time the output pin was toggled
long debounceDelay = 50;	// the debounce time; increase if the output flickers

//RGB Common Colors
int white[] = {255,255,255};
int dimWhite[] = {155,155,155};
int cyan[] = {0,255,255};
int blue[] = {0,0,255};
int violet[] = {138,43,226};
int brown[] = {165,42,42};
int lime[] = {127,255,0};
int magenta[] = {139,0,139};
int red[] = {255,0,0};
int green[] = {0,255,0};
int orange[] = {255,140,0};
int pink[] = {255,20,147};
int gold[] = {255,215,0};

int off[] = {0,0,0};


int input = -1;		//from computer controller (app)

int current_color[] = {0,0,0};
int current_color2[] = {0,0,0};

void setup() {
 Serial.begin(9600);
 // initialize input output
  setIO();   
}

void loop(){

	//color_swirl();

	if (Serial.available() > 0) 
	{
		input = Serial.read(); 

		switch (input)
		{
			case 'a': //Set red
				set_color(1, red);
				set_color(2, red);
				break;
			case 'b': //set green
				set_color(1, green);
				set_color(2, green);
				break;
			case 'c': //set blue
				set_color(1, blue);
				set_color(2, blue);
				break;
			case 'd': //set white
				set_color(1, white);
				set_color(2, white);
				break;
			case 'e': //set violet
				set_color(1, violet);
				set_color(2, violet);
				break;
			case 'f': //set lime
				set_color(1, lime);
				set_color(2, lime);
				break;
			case 'g': //set orange
				set_color(1, orange);
				set_color(2, orange);
				break;
			case 'h': //TODO: set swirl 
				color_swirl();
				break;
		}
   }
}

//sets all of the respective pins as inputs or outputs
void setIO()
{
	pinMode(REDPIN, OUTPUT);
	pinMode(GREENPIN, OUTPUT);
	pinMode(BLUEPIN, OUTPUT);

	pinMode(REDPIN2, OUTPUT);
	pinMode(GREENPIN2, OUTPUT);
	pinMode(BLUEPIN2, OUTPUT); 

	pinMode(BUTTONPIN, INPUT);
}


//sets the color of the specific channel of LED Strip
void set_color(int channel, int color[])
{
	if(channel == 1)
	{
		for(int up = get_min(current_color), down = get_max(current_color); up <= get_max(color) ; up++, down--)
		{
			//Fade up
			if(current_color[0] < color[0])//red
			{
				analogWrite(REDPIN, current_color[0]++);
				delay(FADESPEED);
			}
			if(current_color[1] < color[1])//green
			{
				analogWrite(GREENPIN, current_color[1]++);
				delay(FADESPEED);
			}
			if(current_color[2] < color[2])//blue
			{
				analogWrite(BLUEPIN, current_color[2]++);
				delay(FADESPEED);
			}
			//Fade down
			if(current_color[0] > color[0])//red
			{
				analogWrite(REDPIN, current_color[0]--);
				delay(FADESPEED);
			}
			if(current_color[1] > color[1])//green
			{
				analogWrite(GREENPIN, current_color[1]--);
				delay(FADESPEED);
			}
			if(current_color[2] > color[2])//blue
			{
				analogWrite(BLUEPIN, current_color[2]--);
				delay(FADESPEED);
			}
		}
	}
	else
	{   //TODO: Implement Fade for channel 2
		analogWrite(REDPIN2,color[0]);
		current_color2[0] = color[0];
		analogWrite(GREENPIN2,color[1]);
		current_color2[1] = color[1];
		analogWrite(BLUEPIN2,color[2]);
		current_color2[2] = color[2];
	}
}

int get_min(int a[])
{
	int min = a[0];
	for(int i = 1 ; i < 3 ; i++)
		if(a[i] < min)
			min = a[i];
	return min;
}

int get_max(int a[])
{
	int max = a[0];
	for(int i = 1 ; i < 3 ; i++)
		if(a[i] > max)
			max = a[i];
	return max;
}

void color_swirl()
{
	int r, g, b;
 
	// fade from blue to violet
	for (r = 0; r < 256; r++)
	{
		analogWrite(REDPIN, r);
		delay(SWIRLSPEED);
	} 
	// fade from violet to red
	for (b = 255; b > 0; b--)
	{ 
		analogWrite(BLUEPIN, b);
		delay(SWIRLSPEED);
	} 
	// fade from red to yellow
	for (g = 0; g < 256; g++)
	{ 
		analogWrite(GREENPIN, g);
		delay(SWIRLSPEED);
	} 
	// fade from yellow to green
	for (r = 255; r > 0; r--)
	{ 
		analogWrite(REDPIN, r);
		delay(SWIRLSPEED);
	} 
	// fade from green to teal
	for (b = 0; b < 256; b++)
	{ 
		analogWrite(BLUEPIN, b);
		delay(SWIRLSPEED);
	} 
	// fade from teal to blue
	for (g = 255; g > 0; g--)
	{ 
		analogWrite(GREENPIN, g);
		delay(SWIRLSPEED);
	}  
}