// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.Clear();
// int[] array = new int[8];
// int result = 0;
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(99, 1000);
//   Console.Write($"{array[i]} ");
//   if (array[i] % 2 == 0)
//   {
//     result = result + 1;
//   }  
// }
// Console.WriteLine($"{result} ");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.Clear();
// int[] array = new int[8];
// int result = 0;
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(0, 10);
//   Console.Write($"{array[i]} ");
//   if (i % 2 == 0)
//   {
//     result = result + array[i];
//   }  
// }
// Console.WriteLine();
// Console.WriteLine($"{result} ");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Console.Write("Введите количество элементов массива:");
// int a = Convert.ToInt32(Console.ReadLine());
// double[] randomArray = new double[a];

// void mas(int a)
// {
// Random rand = new Random();
// for (int i = 0; i < a; i++)
// {
// randomArray[i] = rand.NextDouble();
// Console.Write($"{randomArray[i]:F2} ");
// }

// }

// double raz(double[] randomArray)
// {
// double min = randomArray[0];
// double max = randomArray[0];
// int i = 1;
// while (i < randomArray.Length)
// {
// if (max<randomArray[i])
// max = randomArray[i];
// if (min>randomArray[i])
// min = randomArray[i];
// i = i + 1;
// }
// return max-min;
// }

// mas(a);
// Console.Write($"\nРазница между максимальным и минимальным элементов массива: {raz(randomArray):F2}");
