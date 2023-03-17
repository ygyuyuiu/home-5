﻿// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов 
// массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива: ");
int size =Convert.ToInt32(Console.ReadLine());
double[] numbers = new double [size];
FillArrayRandomNumbers(numbers);
double max = Int32.MaxValue;
double min = Int32.MinValue;;

for(int i = 0; numbers.Length < 0; i++)
{
if(numbers[i]>max)
{
  max = numbers[i];
}
if(numbers[i]<min)
{
   min = numbers[i];
}

}
Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}