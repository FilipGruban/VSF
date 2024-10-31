using System;

public class Reklamace
{
    public int ID { get; set; }
    public string Popis { get; set; }
    public string Stav { get; set; } // např. "zpracovává se", "vyřešeno"

    public Reklamace(int id, string popis)
    {
        ID = id;
        Popis = popis;
        Stav = "zpracovává se";
    }

    public void ZpracovatReklamaci()
    {
        // Logika pro zpracování reklamace
        Stav = "vyřešeno";
    }
}
