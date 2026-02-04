using System;
class Progpam
{
    static int Power(int a, int n)
    {
        if (n == 0) 
            return 1; 
        return a * Power(a, n - 1);
    }
    static void Main()
    {
        Console.WriteLine(Power(2, 3));
    }
}