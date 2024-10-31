using System;

public class Produkt
{
    public int ID { get; set; }
    public string Název { get; set; }
    public decimal Cena { get; set; }
    public int Množství { get; set; }

    public Produkt(int id, string název, decimal cena, int množství)
    {
        ID = id;
        Název = název;
        Cena = cena;
        Množství = množství;
    }

    public void AktualizovatMnožství(int novéMnožství)
    {
        Množství = novéMnožství;
    }
}