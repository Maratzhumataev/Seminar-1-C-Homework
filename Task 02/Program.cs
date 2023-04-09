Console.WriteLine("Введите первое число для сравнения");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число для сравнения");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Большее число = {number1}");
    Console.WriteLine($"Меньшее число = {number2}");
}
else if (number2 > number1)
{
    Console.WriteLine($"Большее число = {number2}");
    Console.WriteLine($"Меньшее число = {number1}");
    }
else
{
    Console.WriteLine("Числа равны");
}