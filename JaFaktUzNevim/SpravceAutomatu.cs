using System;

public class SprávceAutomatů
{
    public int ID { get; set; }
    public string Jméno { get; set; }

    public SprávceAutomatů(int id, string jméno)
    {
        ID = id;
        Jméno = jméno;
    }

    public void GenerovatReporty()
    {
        // Logika pro generování reportů
    }

    public void PlánovatÚdržbu(Automat automat)
    {
        // Logika pro plánování údržby
    }
}