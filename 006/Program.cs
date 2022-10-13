// Найти сумму чисел одномерного массива стоящих на нечетной позиции

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine());
int[] array = new int[length];
for(int i = 0; i < length; i++)
     array[i] = new Random().Next(0,50);
Console.Write("Ваш массив: ");
for(int i = 0; i < length; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine();
int sum = 0;
for(int i = 0; i < length; i++)
{
    if(i%2==1)
    sum = sum+array[i];
}
 Console.Write($"Сумма чисел, стоящих на нечетных позициях равна {sum} ");
