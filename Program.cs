class Diak
{
    public string nev;
    public int eletkor;
    public List<int> jegyek;

    public Diak(string n)
    {
        nev = n;
    }

    public void AtlagSzamolas()
    {
        int osszeg = 0;
        foreach (var j in jegyek)
        {
            osszeg += j;
        }
        Console.WriteLine(nev + " átlaga: " + (osszeg / jegyek.Count));
    }
}

class Program
{
    static void Main ()
    {
        Diak d = new Diak("Kovács Péter");
        d.eletkor = -5;
        d.jegyek.Add(5);
        d.jegyek.Add(4);

        d.AtlagSzamolas();
    }
}