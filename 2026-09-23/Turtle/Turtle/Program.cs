class Program
{
    static void Main(string[] args)
    {
        turtle c = new turtle(5, 10, 'b'); // Neues Objekt Definieren
        c.laufe(6); // 6 Schritte laufen
        c.drehe(); // Drehen
        c.laufe(4); // 4 Schritte nach unten Laufen
    }
}

class turtle
{
    private int xposition;
    private int yposition;
    private int richtung;
    private ConsoleColor farbe;

    /*
     * Das ist der Standart Konstruktor
     * Er gibt den Variablen Standart werte für den Fall das was schief läuft oder nichts angegeben wird
     */
    public turtle()
    {
        xposition = 0;
        yposition = 0;
        richtung = 0;
    }
    /*
     * Das ist der Paramisierte Konstruktor
     * Ihm muss man die Startwerte geben
     */
    public turtle(int startx, int starty, char startFarbe)
    {
        xposition = startx;
        yposition = starty;
        richtung = 0;
        aenderefarbe(startFarbe);
    }
    
    /*
     * Definiert Farben zur einfachen Verwaltung
     */
    public void aenderefarbe(char f)
    {
        switch (char.ToLower(f))
        {
            case 'r': farbe = ConsoleColor.Red; break;
            case 'w': farbe = ConsoleColor.White; break;
            case 'b': farbe = ConsoleColor.Blue; break; 
            case 'g': farbe = ConsoleColor.Green; break;
        }
    }

    /*
     * Das ist die Zeichen Methode
     * Sie schreibt das "x" an der x und y Position
     * Außerdem wird hier die Farbe geändet
     */
    public void zeichne()
    {
        Console.SetCursorPosition(xposition, yposition);
        Console.ForegroundColor = farbe;
        Console.Write("x");
    }
    /*
     * Das ist der Läufer oder die Schildkröte
     * Er läuft die Strecke und fürt die Methode zeichne aus
     */
    public void laufe(int strecke)
    {
        for (int i = 0; i < strecke; i++)
        {
            switch (richtung) // Hier werden die Variablen verändert je nach Richtung
            {
                case 0: xposition++; break;
                case 1: yposition++; break;
                case 2: xposition--; break;
                case 3: yposition--; break;
            }
            zeichne();
        }
    }
    
    /*
     * Das ist der Springer
     * Er überspringt einen bestimmten Bereich
     */
    public void springe(int x, int y)
    {
        xposition += x;
        yposition += y;
    }

    /*
     * Das ist der Dreher
     * Er dreht die Richtung in 4 verschiedene Richtungen
     * Wenn aufgerufen dreht er 1 einheit im Uhrzeigersinn
     */
    public void drehe()
    {
        richtung = (richtung + 1) % 4;
    }

}