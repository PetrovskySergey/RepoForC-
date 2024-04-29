// Задайте произвольный массив. Выведете его элементы, начиная с конца.
//  Использовать рекурсию, не использовать циклы.


void OutputOfArrayElementsInReverseOrder(int[] array, int i = 0)
{
    if (i < array.Length)
    {
        OutputOfArrayElementsInReverseOrder(array, i + 1);
        Console.Write(array[i] + " ");
    }
}
int[] array = { 3, 8, 1, 4, 13, 25 };
OutputOfArrayElementsInReverseOrder(array);