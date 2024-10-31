using System;

public class Výdaj
{
    public int ID { get; set; }
    public DateTime Datum { get; set; }
    public decimal Částka { get; set; }

    public Výdaj(int id, DateTime datum, decimal částka)
    {
        ID = id;
        Datum = datum;
        Částka = částka;
    }

    public void VytvořitVýdaj()
    {
        // Logika pro vytvoření výdaje
    }
}
