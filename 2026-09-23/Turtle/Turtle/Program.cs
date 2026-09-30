using System;
using System.Threading; 

class Program
{
    static void Main(string[] args)
    {
        Console.CursorVisible = false; 
        int maxBreite = Console.WindowWidth;
        for (int y = 0; y < 20; y += 8)
        {
            for (int x = 0; x < maxBreite - 20; x++)
            {
                
                Console.Clear(); 
                //Console.BackgroundColor = ConsoleColor.Black;
                
                
                turtle c = new turtle(x + 2, y + 2, 'b', maxBreite); 
                c.laufe(6); // 6 Schritte laufen
                c.springe(-6, 0);
                c.drehe(); // Drehen (nach unten)
                c.laufe(4); // 4 Schritte nach unten Laufen
                c.drehe();
                c.drehe();
                c.drehe(); // Drehen (nach rechts)
                c.springe(0, 1);
                c.laufe(6);
                
                turtle s = new turtle(x + 10, y + 2, 'g', maxBreite);
                
                s.springe(2, 0);
                s.drehe(); // Drehen nach unten
                s.laufe(5);
                
                s.springe(3, -5); // Zurück nach oben springen
                s.laufe(5);
                
                s.springe(-4, -1);
                s.drehe();
                s.drehe();
                s.drehe(); // Nach rechts drehen
                s.laufe(6);
                
                s.springe(-6, -2);
                s.laufe(6);
                
                Thread.Sleep(50);
            }
        }
    } 
}

class turtle
{
    private int xposition;
    private int yposition;
    private int richtung;
    private ConsoleColor farbe;
    private int maxBreite; // Speichert die maximale Breite (alt)

    /*
     * Das ist der Standart Konstruktor
     * Er gibt den Variablen Standart werte für den Fall das was schief läuft oder nichts angegeben wird
     */
    public turtle()
    {
        xposition = 0;
        yposition = 0;
        richtung = 0;
        maxBreite = Console.WindowWidth;
    }

    /*
     * Das ist der Paramisierte Konstruktor
     * Ihm muss man die Startwerte geben
     */
    public turtle(int startx, int starty, char startFarbe, int maxBreite)
    {
        xposition = startx;
        yposition = starty;
        richtung = 0;
        this.maxBreite = maxBreite;
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
        if (xposition >= 0 && xposition < Console.WindowWidth && yposition >= 0) 
        {
            Console.SetCursorPosition(xposition, yposition);
            Console.ForegroundColor = farbe;
            Console.Write("x");
        }
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
                case 0: if (xposition < maxBreite - 1) xposition++; break;
                case 1: yposition++; break;
                case 2: if (xposition > 0) xposition--; break;
                case 3: if (yposition > 0) yposition--; break;
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
        if (xposition >= maxBreite) xposition = maxBreite - 1; 
        if (xposition < 0) xposition = 0;

        yposition += y;
        if (yposition < 0) yposition = 0;
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