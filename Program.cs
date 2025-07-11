Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Nhập vào 3 số a,b,c: ");
Console.Write("a = ");
double a = double.Parse(Console.ReadLine());

Console.Write("b = ");
double b = double.Parse(Console.ReadLine());

Console.Write("c = ");
double c = double.Parse(Console.ReadLine());

double delta = (double) Math.Pow(b, 2);

if  (delta < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Phương trình vô nghiệm.");
    Console.ResetColor();
}

else if (delta ==0)
{
    double x = (double)-b / (2 * a);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Phương trình có nghiệm kép là : x = {x} ");
    Console.ResetColor();
}
else
{
    double x1 = (double)(-b + Math.Sqrt(delta)) / (2 * a); 
    double x2 = (double)(-b - Math.Sqrt(delta)) / (2 * a);
    Console.ForegroundColor= ConsoleColor.Green;
    Console.WriteLine($"Phương trình có 2 nghiệm phân biệt x1 = {x1}, x2 = {x2}");
    Console.ResetColor();
}