// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operatie?");
string operatie = Console.ReadLine();

Console.WriteLine("Eerste getal?");
float getal1 = float.Parse(Console.ReadLine());

Console.WriteLine("Tweede getal?");
float getal2 = float.Parse(Console.ReadLine());

if (operatie == "/")
{
    if (getal2 == 0)
    {
        Console.WriteLine("Je kan niet delen door 0.");
    }
    else
    {
        Console.WriteLine("Resultaat: " + getal1 / getal2);
    }
}
else if (operatie == "*")
{
    Console.WriteLine("Resultaat: " + getal1 * getal2);
}
else if (operatie == "-")
{
    Console.WriteLine("Resultaat: " + (getal1 - getal2));
}
else if (operatie == "+")
{
    Console.WriteLine("Resultaat: " + (getal1 + getal2));
}
else if (operatie == "%")
{
    Console.WriteLine("Resultaat: " + getal1 % getal2);
}
else
{
    Console.WriteLine("Ongeldige operatie.");
}