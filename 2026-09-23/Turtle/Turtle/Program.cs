class Program
{
    static void Main(string[] args)
    {
        turtle c = new turtle(5, 10, 'b');
        c.laufe(6);
        c.drehe();
        c.laufe(4);
    }
}

class turtle
{
    private int xposition;
    private int yposition;
    private int richtung;
    private ConsoleColor farbe;

    public turtle()
    {
        xposition = 0;
        yposition = 0;
        richtung = 0;
    }

    public turtle(int startx, int starty, char startFarbe)
    {
        xposition = startx;
        yposition = starty;
        richtung = 0;
        aenderefarbe(startFarbe);
    }

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

    public void zeichne()
    {
        Console.SetCursorPosition(xposition, yposition);
        Console.ForegroundColor = farbe;
        Console.Write("x");
    }

    public void laufe(int strecke)
    {
        for (int i = 0; i < strecke; i++)
        {
            switch (richtung)
            {
                case 0: xposition++; break;
                case 1: yposition++; break;
                case 2: xposition--; break;
                case 3: yposition--; break;
            }
            zeichne();
        }
    }

    public void springe(int x, int y)
    {
        xposition += x;
        yposition += y;
    }

    public void drehe()
    {
        richtung = (richtung + 1) % 4;
    }

}