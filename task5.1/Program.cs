// Задача 36: Задайте одномерный массив,
//  заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива: ");
int size =Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
FillArrayRandomNumbers(array);
int sum = 0;

for(int i = 0; i < array.Length; i++)
{
  sum = sum + array[i];
}
Console.WriteLine($"всего {array.Length} чисел, сумма элементов на нечётных позициях = {sum}");
void FillArrayRandomNumbers(int[] array)
{
  for(int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(1,10);
  }
}