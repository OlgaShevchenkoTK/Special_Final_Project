// Задача. Написать программу, которая из имеющегося массива строк формирует
//массив из строк, длина которых меньше или равна 3 символа. Первоначальный массив
//можно задать с клавиатуры, либо задать на старте выполнения алгоритма.

//ПОРЯДОК ДЕЙСТВИЙ
// Преобразовать введенный текст в массив строк
// Выбрать значения меньше или равно 3 символа
// Выбранные значения сохранить в новый массив строк
// Вывести в консоль результат

void SelectionText(string[] text)
{
    string[] resultSelectionText = new string[text.Length];
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= 3)
            resultSelectionText[i] = text[i];
        else 
        {
            string item = " ";
            text = text.Where(e => e != item).ToArray();
        }
        Console.Write(resultSelectionText[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Input the text:");
string text = Console.ReadLine();
string[] words = text.Split(new char[] { ' ' });
SelectionText(words);

