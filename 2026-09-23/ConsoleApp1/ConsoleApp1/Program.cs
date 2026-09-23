class Program
{
    static void Main(string[] args)
    {
        Kartoffeln kartoffel = new Kartoffeln(); // Neue Kartoffel definieren
        Schwein schwein1 = new Schwein(); // Neues Schwein definieren
        schwein1.ausgabe(); // Ausgabe der Daten des Schweines
        schwein1.wachsen(); // Schwein wächst
        schwein1.fressen(kartoffel); // Schwin frisst Kartoffel
        schwein1.ausgabe(); // Ausgabe der Daten des Schweines
        
        Schwein schwein2 = new Schwein(1,1,1);
        schwein2.ausgabe(); // Ausgabe der Daten des Schweines
        schwein2.wachsen(); // Schwein wächst
        schwein2.ausgabe(); // Ausgabe der Daten des Schweines
    }
}

class Schwein
{
    private int groesse;
    private int gewicht;
    private int saettigung;

    public Schwein() // Standartkonstrukto
    {
        groesse = 10;
        gewicht = 10;
        saettigung = 10;
    }
    public Schwein(int groesse, int gewicht, int saettigung) // Parametasierter Konstruktor
    {
        this.groesse = groesse;
        this.gewicht = gewicht;
        this.saettigung = saettigung;
    }

    public void wachsen() // Schwein wächst
    {
        groesse++;
        gewicht++;
        saettigung--;
    }

    public void fressen(Kartoffeln kartoffeln) // Schwein frisst
    {
        kartoffeln.GefressenWerden(); // Frisst eine Kartoffel
        groesse++;
        gewicht++;
        saettigung--;
    }

    public void ausgabe()
    {
        Console.WriteLine("Größe: " + groesse);
        Console.WriteLine("Gewicht: " + gewicht);
        Console.WriteLine("Sättigung "  + saettigung);
    }
    

}

class Kartoffeln
{
    private int knollenanzahl;
    
    public Kartoffeln() // Standart Konstruktor
    {
        knollenanzahl = 10;
    }

    public void GefressenWerden() // Kartoffel -- und Ausgabe ausführen
    {
        knollenanzahl--;
        AusgabeFressen();
    }

    private void AusgabeFressen() // Ausgabe
    {
        Console.WriteLine($"Es wird eine Kartoffel gegessen... \n -------- \nNeue Kartoffelanzahl: {knollenanzahl} \n --------");
    }
}