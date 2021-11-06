using System;

namespace ConsoleApp3
{
    class Program
    {
        private class mooietent
        {

        }

        private class Tent
        {
            private mooietent[][] mooietent;

            public Tent(int width, int height)
            {
                this.mooietent = new mooietent[height][];

                for (int i = 0; i < height; i++)
                {
                    this.mooietent[i] = new mooietent[width];

                    for (int j = 0; j < width; j++)
                    {
                        this.mooietent[i][j] = new mooietent();
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Tent tent = new Tent(2, 2);
        }
    }
}