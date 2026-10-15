class Program
{
    static void Main(string[] args)
    {
        Clock uhr1 = new Clock("23:54:11");
        uhr1.Ausgeben();
        Clock uhr2 = new Clock(20, 11, 2);
        uhr2.Ausgeben();
    }

    class Clock
    {
        private int std;
        private int min;
        private int sec;

        public Clock()
        {
            std = 0;
            min = 0;
            sec = 0;
        }

        public Clock(int std, int min, int sec)
        {
            this.std = (std >= 0 && std < 24) ? std : 0;
            this.min = (min >= 0 && min < 60) ? min : 0;
            this.sec = (sec >= 0 && sec < 60) ? sec : 0;
        }

        public Clock(int sec)
        {
            
        }

        public Clock(string zeitString)
        {
            string[] teile = zeitString.Split(':');
            int std = int.Parse(teile[0]);
            int min = int.Parse(teile[1]);
            int sec = int.Parse(teile[2]);
            
            this.std = (std >= 0 && std < 24) ? std : 0;
            this.min = (min >= 0 && min < 60) ? min : 0;
            this.sec = (sec >= 0 && sec < 60) ? sec : 0;
        }

        public void Ausgeben()
        {
            Console.WriteLine($"{std:D2}:{min:D2}:{sec:D2}");
        }
    }
}