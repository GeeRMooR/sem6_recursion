// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

Console.WriteLine("Введите строку содержащую латинские буквы:");
string text = Console.ReadLine();
PrintConsonats(text);

void PrintConsonats(string txt, int index = 0)
{
    if(index == txt.Length)
    {
        return;
    }
    string vowels = "aeiouy";
    if (!vowels.Contains(txt[index]))
    {
        Console.Write($"{txt[index]} ");
    }
    PrintConsonats(txt, index + 1);
}
