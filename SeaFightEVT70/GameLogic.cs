using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaFightEVT70
{
    internal class GameLogic
    {
        int[] left = new int[36];
        int[] right = new int[36];

        static GameLogic()
        {

        }

        public void Shoot(int f, int cell)
        {
            switch (f)
            {
                case 0:
                    switch (left[cell])
                    {
                        case 0:
                            left[cell] = 3;
                            break;
                        case 1:
                            left[cell] = 2;
                            break;
            
                    }
                    break;

                case 1:
                    switch (right[cell])
                    {
                        case 0:
                            right[cell] = 3;
                            break;
                        case 1:
                            right[cell] = 2;
                            break;

                    }
                    break;
            }
        }

        public void SetShip(int f, int cell)
        {
            switch (f)
            {
                case 0:
                    switch (left[cell])
                    {
                        case 0:
                            left[cell] = 1;
                            break;

                    }
                    break;

                case 1:
                    switch (right[cell])
                    {
                        case 0:
                            right[cell] = 1;
                            break;

                    }
                    break;
            }
        }

        public void Reset()
        {
            left = new int[36];
            right = new int[36];
        }
    }
}
