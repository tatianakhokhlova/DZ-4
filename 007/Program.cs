// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//N-i-1.

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine()?? "0");
int[] array = new int[length];
for(int i = 0; i < length; i++)
     array[i] = new Random().Next(1,10);
Console.WriteLine("Ваш массив: ");

for(int i = 0; i < length; i++)
{
    Console.Write($"{array[i]} ");
}
int index = 0;
int S = 1;
int j = array.Length - 1;
for(int i = 0; i<j; i++)
{
    S=array[index] * array[j];
    Console.WriteLine($"Произведение пар: {array[index]} * {array[j]} = {S}; ");
    j--;
    index++;
}
   