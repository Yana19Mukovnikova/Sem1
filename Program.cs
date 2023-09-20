//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a, b;
  
    Console.WriteLine("Введи 2 числа и мы тебе скажем какое из них больше");
    Console.WriteLine("Введи свое первое число - ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введи свое второе число - ");
    b = Convert.ToInt32(Console.ReadLine());
    if (a>b)
    {
        Console.WriteLine($"Число {a} больше чем {b}");
    }
    else if (a==b)
    {
        Console.WriteLine($"Числа {a} и {b} равны");
    }
    else if (b>a)
    {
        Console.WriteLine($"Число {b} больше чем {a}");
    }
    Console.ReadLine ();