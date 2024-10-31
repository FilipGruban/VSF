using System;

public class Doplňovač
{
    public int ID { get; set; }
    public string Jméno { get; set; }

    public Doplňovač(int id, string jméno)
    {
        ID = id;
        Jméno = jméno;
    }

    public void DoplnitZboží(Automat automat)
    {
        // Logika pro doplnění zboží do automatu
    }
}
