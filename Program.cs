
// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine ("Введите число");

        string number = Console.ReadLine();
        
        if (number.Length > 5)
        {
            Console.WriteLine ("Число превышает допустимое значение");
        }
        if (number [0] == number [4] && number [1] == number [3])
        {
            Console.WriteLine ("Палиндром");
        }
        else
        {
            Console.WriteLine ("Число не является палиндромом");
        }
        */
        
        //Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

        Random rand = new Random();

        int x1 = rand.Next (1, 10);
        int y1 = rand.Next (1, 10);
        int z1 = rand.Next (1, 10);

        int x2 = rand.Next (1, 10);
        int y2 = rand.Next (1, 10);
        int z2 = rand.Next (1, 10);

        Console.WriteLine (Math.Sqrt(Math.Pow (x1 - x2, 2) + Math.Pow (y1 - y2, 2) + Math.Pow (z1 - z2, 2)));

        // Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

        int N = rand.Next(1, 10);
        int counter = 1;
        while (counter <= N)
        {
                Console.WriteLine($"{counter} -> {counter*counter*counter}");
                counter ++;
        }