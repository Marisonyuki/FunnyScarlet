Console.WriteLine("Выберите операцию");
Console.WriteLine("1. Сложение");
Console.WriteLine("2. Вычитание");
Console.WriteLine("3. Умножение");
Console.WriteLine("4. Деление");
Console.WriteLine("5. Степень");
Console.WriteLine("6. Квадратный корень");
Console.WriteLine("7. 1% от числа");
Console.WriteLine("8. Факториал");
Console.WriteLine("9. Выход");
int g = 0;
int a = 0;
int b = 0;
do
{
    string j = Console.ReadLine();
    int Num = Convert.ToInt32(j);
    g = Num;
    if (g == 1)
    {
        Console.WriteLine("Введите первое и второе число (a+b)");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("= " + (a + b));
    }    
    if (g == 2)
    {
        Console.WriteLine("Введите первое и второе число (a-b)");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("= " + (a - b));
    }
    if (g == 3)
    {
        Console.WriteLine("Введите первое и второе число (a*b)");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("= " + (a * b));
    }
    if (g == 4)
    {
        double ad = 0;
        double bd = 0;
        Console.WriteLine("Введите первое и второе число (a/b)");
        ad = Convert.ToDouble(Console.ReadLine());
        bd = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("= " + (ad / bd));
    }
    if (g == 5)
    {
        double stepen = 0;
        Console.WriteLine("Введите первое число и степень (a^b)");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        stepen = Math.Pow(a, b);
        Console.WriteLine("= " + stepen);
    }
    if (g == 6)
    {
        double koren = 0;
        Console.WriteLine("Введите первое число (sqrt(a))");
        a = Convert.ToInt32(Console.ReadLine());
        koren = Math.Sqrt(a);
        Console.WriteLine("= " + koren);
    }
    if (g == 7)
    {
        double perc = 0;
        Console.WriteLine("Введите первое число (1% от a)");
        perc = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("= " + (perc/100));
    }
    if (g == 8)
    {
        double c = 1;
        Console.WriteLine("Введите первое число для факториала (a!)");
        a = Convert.ToInt32(Console.ReadLine());
        b = 0;
        for (int i = 0; i < a; i++)
        {
            b = b + 1;
            c = b * c;
        }
        Console.WriteLine("= " + (c));
    }
}
while (g < 9);