// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] FindStrArray(string[] array, int k)
{
    int len = array.Length;
    int count = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i].Length <= k) count++;
    }

    string[] new_arr = new string[count];
    count = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i].Length <= k)
        {
            new_arr[count] = array[i];
            count++;
        }
    }
    return new_arr;
}

string PrintArrayToString(string[] array)
{
    return String.Join(',', array);
}

int k = 3;
string[] array = { "Hello", "2", "World", ":-)" };
System.Console.WriteLine(PrintArrayToString(array));
string[] new_arr = FindStrArray(array, k);
System.Console.WriteLine(PrintArrayToString(new_arr));
