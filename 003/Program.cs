// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] arr = {1, 0, 1, 0, 1, 0, 1, 0 };

void PrintArray(int [] array)
{
    int count = array.Length;
    for(int i = 0; i<count; i++ )
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);
