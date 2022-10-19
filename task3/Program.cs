/*Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int Value = int.Parse(strValue);
    return Value;
}

string[] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение"};
int Value = Prompt("Введите день недели  от 1 до 7 >");
int daysValue = Value-1;
if (Value < 6)
{   
System.Console.WriteLine ($"{Value} -> Не выходной день недели {days[daysValue]}");
}
else
{
    System.Console.WriteLine ($"{Value} -> Выходной день недели {days[daysValue]}");
}
