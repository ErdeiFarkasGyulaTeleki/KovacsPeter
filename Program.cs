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

    public Diak(string _nev)
    {
        nev = _nev;
    }

    public void AtlagSzamolasEsKiiras()
    {
        if (jegyek.Count == 0)
        {
            Console.WriteLine("A jegyek száma 0, és nullával nem osztunk!");
            return;
        }

        double atlag = (double)jegyek.Sum() / jegyek.Count;

        Console.WriteLine($"{nev} átlaga: {atlag}");
    }
}

class Program
{
    static void Main ()
    {
        Diak diak1 = new Diak("Kovács Péter");

        diak1.eletkor = -5;
        diak1.jegyek.Add(5);
        diak1.jegyek.Add(4);

        diak1.AtlagSzamolasEsKiiras();
    }
}