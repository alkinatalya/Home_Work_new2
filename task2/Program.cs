/*Задача 13: Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int firstNumber = Prompt("Введите любое число > ");
if (firstNumber >= 0)
{
    if (firstNumber > 99)
    {
        while (firstNumber >= 999)
        {
            firstNumber = firstNumber / 10;
        }
        int result = firstNumber % 10;
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
else
{
    if (firstNumber < -99)
    {
        while (firstNumber <= -999)
        {
            firstNumber = firstNumber / 10;
        }
        int result = firstNumber % 10;
        result = result * -1;
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
