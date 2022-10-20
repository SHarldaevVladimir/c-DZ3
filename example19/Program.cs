// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


string stringNumber = Convert.ToString(Console.ReadLine()!);

void palindromeNumber(string stringNumber)
{
    if (stringNumber[0] == stringNumber[4]  && stringNumber[1] == stringNumber[3])
    {
        Console.WriteLine("Да, это Палиндром");
    }
        else Console.WriteLine("Нет, это не Палиндром");
}

if (stringNumber.Length==5) palindromeNumber(stringNumber);
else Console.WriteLine("Введите пятизначное");
