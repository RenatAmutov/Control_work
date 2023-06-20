// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


void CreateArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
     {
        Console.WriteLine($"Введите {i+1}e слово: ");
         array[i] = Console.ReadLine();
     }
}
void PrintAray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int PoiskKolichestvaSlov(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}  
void CreateNewArray(string[] firstArray, string[] secondArray)
{
    for (int i = 0, j = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
          secondArray[j] =  firstArray[i];
          j++; 
        }
    }
}
Console.WriteLine("Сколько слов будет в массиве ? ");
int a = Convert.ToInt32(Console.ReadLine());
string[] array = new string[a];
CreateArray(array);
Console.WriteLine($"Массив введенных слов: ");
PrintAray(array);
string[] newStringArray = new string[PoiskKolichestvaSlov(array)];
CreateNewArray(array, newStringArray);
Console.WriteLine();
Console.WriteLine($"Массив слов меньше 4х символов: ");
PrintAray(newStringArray);