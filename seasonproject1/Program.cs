
using System.Linq.Expressions;
Console.WriteLine("Enter month number");

string MonthText = Console.ReadLine();

int usermonthinput = int.Parse(MonthText);

if (usermonthinput == 12 || usermonthinput == 1 || usermonthinput == 2)
{
    Console.WriteLine("Winter");
}
else if (usermonthinput == 3 || usermonthinput == 4 || usermonthinput == 5)
{
    Console.WriteLine("Spring");
}
else if (usermonthinput == 6 || usermonthinput == 7 || usermonthinput == 8)
{
    Console.WriteLine("Summer");
}
else if (usermonthinput == 9 || usermonthinput == 10 || usermonthinput == 11)

{
    Console.WriteLine("Autumn");
}
else if (usermonthinput >= 12 || usermonthinput <= 1)
{
    Console.WriteLine("Invalid Month");
}

