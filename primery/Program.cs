// 
// string s = "1, 2, 3, 4, 5, 6, 7.";
// Console.WriteLine(s);

// string[] nums = s.Split(new char[]{' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);

// int[] n = nums.Select(Int32.Parse).ToArray();

// foreach (var num in nums)
// {
//    Console.WriteLine($" Значение {num}");
// }

// int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);




// // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
// Console.Clear();
// int[] array = new int[12];
// int result = 0;
// int resultneg = 0;
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(-9, 10);
//   Console.Write($"{array[i]} ");
//   if (array[i] > 0)
//   {
//     result = result + array[i];
//   }
//   else
//   {
//     resultneg = resultneg + array[i];
//   }
// }
// Console.WriteLine($"{result} и {resultneg}");


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// Console.Clear();
// int[] array = new int[12];
// int result = 0;
// int resultneg = 0;
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(-9, 10);
//   Console.Write($"{array[i]} ");
// }
// Console.WriteLine();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i]  * (-1);
//     Console.Write($"{array[i]} ");
// }


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[5];
// string result = "такого значения нет";

// for (int i = 0; i < array.Length; i++)
// {
// array[i] = new Random().Next(0, 5);
// Console.Write(array[i]);
//   if (array[i] == N)
// {
//     result = "такое значение есть";
// }
// }
// Console.WriteLine(result);


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и 
// предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = new int[5];
int [] array2 = new int [array.Length/2+array.Length%2];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 5);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for (int i = 0; i < array2.Length; i++)
{
    if (i == array.Length-i-1) 
    {
        array2[i] = array[i];
    }
    else
    {
        array2[i] = array[i] * array [array.Length-i-1];
    }
    Console.Write ($"{array2[i]} ");
    
}

