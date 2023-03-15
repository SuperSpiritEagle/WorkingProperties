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
            public int PositionX { get;}
            public int PositionY { get;}

            public Player(int positionX,int positionY)
            {
                PositionX = positionX;
                PositionY = positionY;
            }
        }

        class Renderer
        {
            private string _player;
            public Renderer(string player)
            {
                _player = player;
            }

            public void Print()
            {
                Console.WriteLine(_player);
            }

            public void SetCursor(int positionX,int positionY)
            {
                Console.SetCursorPosition(positionX, positionY);
            }
        }
    }
}


