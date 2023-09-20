//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int a, b, c;
  
    Console.WriteLine("Введи 3 числа и мы тебе скажем, какое из них наибольшее");
    Console.WriteLine("Введи своё первое число - ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введи своё второе число - ");
    b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введи своё третье число - ");
    c = Convert.ToInt32(Console.ReadLine());
    if ((a>b) & (a>c))
    {
        Console.WriteLine($"Число {a} наибольшее");
    }
    else if ((b>a) & (b>c))
    {
        Console.WriteLine($"Число {b} наибольшее");
    }
    else 
    {
        Console.WriteLine($"Число {c} наибольшее");
    }
    Console.ReadLine ();