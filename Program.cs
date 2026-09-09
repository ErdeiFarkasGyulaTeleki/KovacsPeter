class Diak
{
    public string nev { get; set; }
    public int eletkor
    {
        get;
        set
        {
            if (value < 1) field = 1;
        }
    }
    public List<int> jegyek = new List<int>();

    public Diak(string n)
    {
        nev = n;
    }

    public void AtlagSzamolas()
    {
        if (jegyek.Count == 0)
        {
            Console.WriteLine("A jegyek száma 0, és nullával nem osztunk!");
            return;
        }

        float osszeg = jegyek.Sum();

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