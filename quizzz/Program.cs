string svar = "";
svar = svar.ToLower();

int sum = 0;

Console.WriteLine("1) In what region i Japan");
Console.WriteLine("a) Europe b Africa c Asia");
svar = Console.ReadLine();
svar = svar.ToLower();

if (svar == "c")
{
Console.WriteLine("Correct");
sum++;
}




else if (svar != "c" )
{
    Console.WriteLine("Incorrect");
}

Console.ReadLine();
Console.WriteLine("1) In what region i Japan");
Console.WriteLine("a) Europe b Africa c Asia");



svar = Console.ReadLine();

