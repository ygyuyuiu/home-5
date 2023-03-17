// Задача 34: Задайте массив заполненный  
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел 
// в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива: ");
int size =Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
FillArrayRandomNumbers(array);
int count = 0;

for(int i = 0; i < array.Length; i++)
if(array[i] % 2 ==0)
count ++;

Console.WriteLine($"Получается {array.Length} чисел, {count} из них четные");

void FillArrayRandomNumbers(int[] array)
{
  for(int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(100,1000);
  }
}