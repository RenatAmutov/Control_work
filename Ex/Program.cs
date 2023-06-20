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
void IshemSlovaMenseTrehSinvolov(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        
    }
}

Console.WriteLine("Сколько слов будет в массиве ? ");
int a = Convert.ToInt32(Console.ReadLine());
string[] array = new string[a];
CreateArray(array);
PrintAray(array);