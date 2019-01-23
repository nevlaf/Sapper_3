using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sapper_2.Model;


namespace Sapper_2.Controllers
{
    public static class Game
    {
        #region Variables
        private static int w = 10;
        private static int h = 10;

        public static CellState[,] mineField = new CellState[h, w];

        #endregion
        #region
        public static void Init()
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    mineField[i, j] = CellState.Empty;
                }
            }
        }

        #endregion
    }
}
