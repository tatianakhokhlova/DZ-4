// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int Length = 123;
int[] array = new int[Length];
for(int i = 0; i < Length; i++)
     array[i] = new Random().Next(-10,111);
Console.Write("Ваш массив: ");
Console.WriteLine();

for(int i = 0; i < Length; i++)
    Console.Write($"{array[i]} ");

    int count = 0;
for(int i = 0; i < Length; i++)
{
    if((array[i]>=10) &&(array[i]<=99))
    count++;
}
 Console.WriteLine($" Количество элементов из отрезка [10,99]:  {count} ");
 Console.WriteLine();


