using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekz
{
    class Game15
    {
        int field;
        int[,] coordsystem;
        int spaceX, spaceY;
        static Random rand = new Random();

        public Game15 (int field)
        {
            if (field < 2) field = 2;
            if (field > 5) field = 5;
            this.field = field;
            coordsystem = new int[field, field];
        }

        public void Beginning ()
        {
            for (int x = 0; x < field; x++)
                for (int y = 0; y < field; y++)
                    coordsystem[x, y] = ConvertCoordsToPosition(x, y) + 1;
            spaceX = field - 1;
            spaceY = field - 1;
            coordsystem[spaceX, spaceY] = 0;
        }
        public void Moving (int position)
        {
            int x, y;
            ConvertPositionToCoords(position, out x, out y);
            if (Math.Abs(spaceX - x) + Math.Abs(spaceY - y) != 1)
                    return;
            coordsystem[spaceX, spaceY] = coordsystem[x,y];
            coordsystem[x, y] = 0;
            spaceX = x;
            spaceY = y;
        }

        public bool CheckNumbers()
        {
            if (!(spaceX == field - 1 && spaceY == field - 1))
                return false;
            for (int x = 0; x < field; x++)
                for (int y = 0; y < field; y++)
                    if (!(x == field - 1 && y == field - 1))
                       if (coordsystem[x, y] != ConvertCoordsToPosition(x, y) + 1)
                            return false;
            return true;
                            
        }
    
        public void EmptyCell()
        {
            for(int i = 0;i<4;i++)
            {
                int z = 0;
                int x = spaceX;
                int y = spaceY;
                switch (z)
                {
                    case 0: x++; break;
                    case 1: y++; break;
                }
                Moving(ConvertCoordsToPosition(x, y));
            }
            for (int i = 0; i < 4; i++)
            {
                int z = 1;
                int x = spaceX;
                int y = spaceY;
                switch (z)
                {
                    case 0: x++; break;
                    case 1: y++; break;
                }
                Moving(ConvertCoordsToPosition(x, y));
            }
        }
        public int GetNumber(int position)
        {
            int x, y;
            ConvertPositionToCoords(position, out x, out y);
            if (x < 0 || x >= field) return 0;
            if (y < 0 || y >= field) return 0;
            return coordsystem[x, y];
        }
        private int ConvertCoordsToPosition(int x, int y)
        {
            if (x < 0) x = 0;
            if (x > field - 1) x = field - 1;
            if (y < 0) y = 0;
            if (y > field - 1) y = field - 1;
            return y * field + x;
        }

        private void ConvertPositionToCoords(int position, out int x,out int y)
        {
            if (position < 0) position = 0;
            if (position > field * field - 1) position = field * field - 1;
            x = position % field;
            y = position / field;
        }
        public void Moving_randomly()
        {
            int a = rand.Next(0, 4);
            int x = spaceX;
            int y = spaceY;
            switch(a)
            {
                case 0: x--;break;
                case 1: x++;break;
                case 2: y--;break;
                case 3: y++;break;
            }
            Moving(ConvertCoordsToPosition(x, y));
        }
  
    }
}
