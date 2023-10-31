using System;

class Program
{
    static void Main(string[] args)
    {
        // علی پیر محمد جماعت و حمیدرضا واحدی و مهدی نوروزی   پیشرفته 1   شمسی پور
        Console.WriteLine("تعداد اعدادی که میخواهید محاسبه شود را وارد کنید");
        int a = 0;
        a = Convert.ToInt32(Console.ReadLine());
        int n = a; 
        Console.WriteLine("اعداد فیبوناتچی:");
        for (int i = 0; i < n; i++)
        {  Console.Write(Fibonacci(i) + " ");  }
         Console.WriteLine("تقدیم  به استاد حافظی عزیز");
        }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        
        int a = 0;
        int b = 1;
        
        for (int i = 2; i <= n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        
        return b;
    }
}

