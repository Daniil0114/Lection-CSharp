int a1 = 15;
int b1 = 30;
int c1 = 45;
int a2 = 60;
int b2 = 75;
int c2 = 90;
int a3 = 105;
int b3 = 120;
int c3 = 135;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);