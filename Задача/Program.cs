/* Задача.
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше лиибо равна 3 символа. Первоначальный массив можно ввести с клавиатуры или задать на старте.
При решении не рекомендуется пользоваться коллекциями.

Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

string [] array = {"hello", "2", "world", ":-)"};
int maxLength = 3;

PrintArray(array);

SelectArray(array);

//Метод отбора из массива строк с количеством символов менее или равно 3
void SelectArray(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for(int i = 0; i < length; i++)
    {
        if(array[i].Length <= maxLength)
        {
            result[count] = array[i];
            Console.Write($" {result[count]}");
            count++;
        }  
    }
}



