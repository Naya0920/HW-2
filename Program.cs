// 2 задачи с предыдущей домашней работы,которые не пушились
// Задача№2
/*
Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

 if(b > max) 
 max = b;
 if(c > max)
 max = c;
 Console.WriteLine(max);
*/
// Задача№3 
/*
Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a % 2==0)
{
    Console.Write("Number is even");
}
else 
{
    Console.Write("Odd number");
}
*/
// Нынешняя домашняя работа 
//Задача№1
/*
Console.Write("Enter a three-digit number: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("Second digit of this number "+stringNumber[1]);
*/
// Задача№2 
/*
Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
    Console.WriteLine("third digit " + numberText[2]);
}
else 
{
    Console.WriteLine("no third digit");
}
*/
//Задача№3
/*
Console.Write("Enter a number for the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Day off");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("It's not a day of the week");
    }
    else Console.WriteLine("Not a day off");
}
CheckingTheDayOfTheWeek(dayNumber);
*/