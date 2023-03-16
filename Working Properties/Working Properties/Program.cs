using System;

namespace Working_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(3, 1);
            Renderer renderer = new Renderer("@");

            renderer.SetCursor(player.PositionX, player.PositionY);
            renderer.Print();
        }

        class Player
        {
            public Player(int positionX,int positionY)
            {
                PositionX = positionX;
                PositionY = positionY;
            }

            public int PositionX { get; }
            public int PositionY { get; }
        }

        class Renderer
        {
            private string _symbol;

            public Renderer(string symbol)
            {
                _symbol = symbol;
            }

            public void SetCursor(int positionX, int positionY)
            {
                Console.SetCursorPosition(positionX, positionY);
            }

            public void Print()
            {
                Console.WriteLine(_symbol);
            }
        }
    }
}


