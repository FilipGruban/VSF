using System;

public class Administrátor
{
    public int ID { get; set; }
    public string Jméno { get; set; }

    public Administrátor(int id, string jméno)
    {
        ID = id;
        Jméno = jméno;
    }

    public void SpravovatUživatele()
    {
        // Logika pro správu uživatelských účtů
    }
}
