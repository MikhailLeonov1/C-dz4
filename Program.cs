// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8



Console.WriteLine("Введите длину: ");

      int a = Convert.ToInt32(Console.ReadLine());
      int b = 1;
        if (b == 1)
        {
         b += 1;
        }
        while (b <= a)
        {
            Console.WriteLine(b);
            b += 2;
        }

