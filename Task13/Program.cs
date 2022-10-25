Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int n = number;
int digitCount = (int)Math.Log10(n) + 1;
if(digitCount < 3)
{
    Console.WriteLine($"{number} - нет третьей цифры");
}
else
{
    while(number > 1000) 
    {
        number = number / 10;
    }
    int result = number % 10;
    Console.WriteLine(result);
}
