using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sapper_2.Model;
using Sapper_2.Controllers;

namespace Sapper_2
{
    public partial class FormMain : Form        
    {
        #region Variables
        /// <summary>
        /// Размер ячейки поля
        /// </summary>
        private int size = 30;
        

        #endregion

        #region Constructors;

        public FormMain()
        {
            InitializeComponent();
        }

        #endregion

        private void UpdateSea(Panel panel)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (panel.Name == "mineField")
                    {
                        switch (Game.seaOwn[i, j])
                        {
                            case CellState.Empty:
                                break;
                            case CellState.Flag:
                                break;
                            case CellState.Question:
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

        }

    }
}
