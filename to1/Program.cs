Console.Write("Введите 1-ое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-ое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2 )
{
    Console.WriteLine("Первое число большого второго ");
}
else
{
    Console.WriteLine("Второе число большого первого ");
}