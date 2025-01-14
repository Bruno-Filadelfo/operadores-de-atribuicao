int a1 = 5;
double b1 = a1;
Console.WriteLine(a1);

int a2 = 555555555;
long b2 = a2;
Console.WriteLine(a2);

int a3 = int.MaxValue;
long b3 = a3;
Console.WriteLine(a3);

long a4 = long.MaxValue;
int b4 = Convert.ToInt32(a4);

long a5 = 100;
double b5 = Convert.ToDouble(a5);