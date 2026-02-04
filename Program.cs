using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите номер задания (1 или 2): ");
        int task = int.Parse(Console.ReadLine());

        switch (task)
        {
            case 1:
                {
                    TaskOne();
                    break;
                }
            case 2:
                {
                    TaskTwo();
                    break;
                }
            default:
                {
                    Console.WriteLine("Нет такого задания");
                    break;
                }
        }

        Main();
    }

    // Task 1
    static void TaskOne()
    {
        Console.Write("Введите основание a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите показатель степени n: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1)
        {
            Console.WriteLine("n должно быть натуральным числом (n >= 1)");
            return;
        }

        int result = 1;
        for (int i = 0; i < n; i++)
        {
            result *= a;
        }

        Console.WriteLine($"{a}^{n} = {result}");
    }

    // Task 2
    static void TaskTwo()
    {
        Console.Write("Введите число x (x >= 100): ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int x) || x < 100)
        {
            Console.WriteLine("Ошибка: необходимо ввести целое число не менее 100");
            return;
        }

        string xStr = x.ToString();

        char secondDigitChar = xStr[1];

        string withoutSecondDigitStr = xStr.Remove(1, 1);

        string resultStr = withoutSecondDigitStr + secondDigitChar;

        if (!int.TryParse(resultStr, out int n))
        {
            Console.WriteLine("Ошибка: результат слишком велик для типа int");
            return;
        }

        Console.WriteLine($"\nИсходное число x = {x}");
        Console.WriteLine($"Вторая цифра = {secondDigitChar}");
        Console.WriteLine($"Число без второй цифры = {withoutSecondDigitStr}");
        Console.WriteLine($"Результат n = {n}");
    }
}
