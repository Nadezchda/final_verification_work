
// ЗАДАЧА:
// Написать программу, которая из имеющегося массива строк
// формирует массивы из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с кулавиатуры либо задать на старте
// выполнения алгоритма.

 string[] array1 = new string[4] {"3456", "678", "hello", ":-)"};
 Console.Write("[3456, " + "678, " + "hello, "+ ":-)] => [");

 string[] array2 = new string[array1.Length];

void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}" + ",");
    }
    Console.WriteLine("]");
}
SecondArray(array1 , array2);
PrintArray(array2);
