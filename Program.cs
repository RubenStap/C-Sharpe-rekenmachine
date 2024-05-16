// See https://aka.ms/new-console-template for more information
class Program
{
    public static int keer(int getala, int getalb)
    {
        return getala * getalb;
    }
    public static void Main()
    {
        Console.WriteLine("Getal a: ");
        int getala = int.Parse(Console.ReadLine());
        Console.WriteLine("Getal b: ");
        int getalb = int.Parse(Console.ReadLine());

        int resutaat = keer(getala, getalb);

        Console.WriteLine("a x b = " + resutaat);

    }



}