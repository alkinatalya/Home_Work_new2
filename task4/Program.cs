/*Дополнительная Задача 9
Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да*/
int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int value = Prompt("Введите число >");
//while
 if(value % 7 != 0 || value % 23 !=0)
{
    System.Console.WriteLine($"{value} = нет");
}
else
{
System.Console.WriteLine($"{value} = да");
}