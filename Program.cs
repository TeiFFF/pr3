Double Result = 0;
Console.WriteLine("Введите число A");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число B");
double B = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Действие");
string Distinct  = Console.ReadLine();
if (Distinct == "+")
{
    Result = A + B;
}
else if (Distinct == "-")
{
    Result = A - B;
}
else if (Distinct == "*")
{
    Result = A * B;
}
else if (Distinct == "/")
{
    Result = A / B;
}
Console.WriteLine(Result);