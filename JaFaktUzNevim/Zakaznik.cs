using System;

public class Zakaznik
{
    public int ID { get; set; }
    public string Jméno { get; set; }
    public string Email { get; set; }

    public Zakaznik(int id, string jméno, string email)
    {
        ID = id;
        Jméno = jméno;
        Email = email;
    }

    public void NakoupitProdukt(Produkt produkt)
    {
        // Logika pro nákup produktu
    }

    public void HlásitProblém(string problém)
    {
        // Logika pro hlášení problému
    }
}
