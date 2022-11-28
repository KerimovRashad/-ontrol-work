/* ЗАДАЧА:
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

//РЕШЕНИЕ 1 (с использованием двух массивов)
/*
Console.Write("How many elements do you want to enter? ");
int size  =  Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];

   
for (int  i = 0; i < size; i++)
{
    Console.WriteLine($"Input {i+1}-й element: ");
   string element = Convert.ToString(Console.ReadLine());
    arrayStrings[i] = element;
}

string[] arrayFinal=new string[size];
int len = 3;
int pos = 0;

for (int  j = 0; j < size; j ++)
{
    if (arrayStrings[j].Length <= len)
    {
        arrayFinal[pos] = arrayStrings[j];
        ++pos;
    }
}

Console.WriteLine();
PrintArray(arrayFinal);
*/
// РЕШЕНИЕ 2 (с использованием одного массива)
 
Console.Write("How many elements do you want to enter? ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayStrings = new string[size];
int len = 3;
int pos = 0;
for (int i = 0; i < size; i++)
{
 Console.WriteLine($"Input {i+1} element: ");
 string element = Convert.ToString(Console.ReadLine());
if (element.Length <= len)
    {
 arrayStrings[pos] = element;
 pos++;
    }
}
Console.WriteLine();
PrintArray(arrayStrings);


// _____________Блок вспомогательных методов_____________


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
/*
Программа:
Для запуска программы перейдите в папку solution и запустите команду через терминал:

dotnet run 
Далее введите значения через пробел, например:

Введите значения через пробел: 2 hello sun 33 world
Пример вывода программы:

[2, hello, sun, 33, world] -> [2, sun, 33]
*/