Console.WriteLine("Введите значение b1");
int b1= int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k1");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2");
int k2 = int.Parse(Console.ReadLine());

double x = (double)(b2 - b1) / (k1 - k2);
double y = (double) k1 * x + b1;
Console.WriteLine("Точка перечения = ({0};{1})",x,y);