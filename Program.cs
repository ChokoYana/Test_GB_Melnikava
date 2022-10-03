// Написать программу, которая из имеющегося массива строк  формирует массив строк, длина которых меньше или равна 3.
// 

Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] CreateStringArray ()
{
    string[] array = new string[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ")
        array[i] = Console.ReadLine();
    }
    return array;
}

void ShowStringArray(string[] array)
{
    for(int i = 0; i < size; i++) Console.Write($"{array[i]}  ");
}

ShowStringArray(CreateStringArray());