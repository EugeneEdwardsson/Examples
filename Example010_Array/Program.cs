using System;


//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


// Console.Write("Input three-digit number:  ");
// int numberThreeDigit = Convert.ToInt32(Console.ReadLine());
// string numberDigit = Convert.ToString(numberThreeDigit);
// Console.WriteLine("Second digit of a three-digit number" + " " + numberDigit[1]);



//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


// Console.Write("Input number: ");
// int givenNumber = Convert.ToInt32(Console.ReadLine());
// string numberStringConvert = Convert.ToString(givenNumber);

// if (numberStringConvert.Length > 2)
// {
//   Console.WriteLine("Third digit of a given number:" + " " + numberStringConvert[2]);
// }
// else 
// {
//   Console.WriteLine("The given number is missing the third digit!!!");
// }


//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Input the number of the day of the week");
int inputNumber = Convert.ToInt32(Console.ReadLine());

void CheckingDayWeek(int inputNumber)
{
    if (inputNumber == 6) 
    {
        Console.WriteLine(inputNumber + " " + "Six day!!! Satuday - day off");
    } 
    else if (inputNumber == 7)
    {
        Console.WriteLine(inputNumber + " " + "Seven day!!! Sunday - day off");
    } 
    else
    {
        Console.WriteLine(inputNumber + " " + "Week day!!! Work nigga");
    }
    
    int check = CheckingDayWeek(inputNumber);
    Console.Write(check);
   
}



