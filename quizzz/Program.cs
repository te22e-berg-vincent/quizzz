string svar = "";
svar = svar.ToLower();

int sum = 0;

Console.WriteLine("1) In what region i Japan");
Console.WriteLine("a) Europe b Africa c Asia");
svar = Console.ReadLine();
svar = svar.ToLower();

if (svar == "c")
{
Console.WriteLine("That's correct!");
sum++;
}




else if (svar != "c" )
{
    Console.WriteLine("Incorrect");
}


Console.WriteLine("When was the first car invented");
Console.WriteLine("a) 1896. b) 1923. c1904");
svar = Console.ReadLine();
svar = svar.ToLower();

if (svar == "a")
{
Console.WriteLine("That's right!");
sum++;
}

else if (svar != "a")
{
   Console.WriteLine("Sorry not quite");
}








Console.ReadLine();