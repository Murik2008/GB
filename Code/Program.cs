// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = {"Hello", "2", "world", ":-)"};
void NewArray(string[] array)
{
    string[] array_01 = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if ( array[i].Length <= 3 )
        {
            array_01[i] = array[i];
        }
    }
    for (int l = 0; l < array_01.Length; l++) 
    {
        Console.Write(array_01[l]);
    }
    Console.WriteLine();
}
NewArray(array);