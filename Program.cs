// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

void IsPalindrom (int number)
{
    if (number >= 10000 && number < 100000)
    {
        int num1 = number % 10;
        int num2 = (number / 10000) % 10;
        if (num1 == num2)
        {
            int num3 = (number / 10) % 10;
            int num4 = (number / 1000) % 10;
            if(num3 == num4)
            {
                Console.WriteLine($" Your number {number} is Palindrom");
            }
            else
            {
                Console.WriteLine($" Your number {number} is not Palindrom");
            }
        }
        else
        {
            Console.WriteLine($" Your number {number} is not Palindrom");
        }
    }
         else
    {
        Console.WriteLine($"Your number is not of 5 digits");
    }
   
}

Console.WriteLine("Input your number");
int num = Convert.ToInt32(Console.ReadLine());
IsPalindrom(num);












