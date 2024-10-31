Ausing System;

public class Automat
{
    public int ID { get; set; }
    public string Stav { get; set; } // funkční, nefunkční, potřebuje doplnění
    public List<Produkt> Produkty { get; set; }

    public Automat(int id)
    {
        ID = id;
        Produkty = new List<Produkt>();
    }

    public void PřidatProdukt(Produkt produkt)
    {
        Produkty.Add(produkt);
    }

    public void OdebratProdukt(Produkt produkt)
    {
        Produkty.Remove(produkt);
    }

    public void ZkontrolovatStav()
    {
        // Logika pro kontrolu stavu automatu
    }
}
