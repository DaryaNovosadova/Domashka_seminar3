Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number3 = number %10;
int number2 = (number / 10) % 10;

Console.WriteLine(number2);
