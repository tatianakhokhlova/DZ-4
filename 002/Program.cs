// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine());
int[] array = new int[length];
for(int i = 0; i < length; i++)
     array[i] = new Random().Next(100,999);
Console.Write("Ваш массив: ");
for(int i = 0; i < length; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine();
int count1 = 0;
int count2 = 0;
for(int i = 0; i < length; i++)
{
   if(array[i]%2==0)
{
    count1++;
} 
else
{
    count2++;
}
}
Console.Write($"количество четных чисел в массиве: {count1} ");
Console.WriteLine();
Console.Write($"количество нечетных чисел в массиве: {count2} ");
Console.WriteLine();


