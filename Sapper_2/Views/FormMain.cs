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
using Sapper_2.Views;

namespace Sapper_2
{
    public partial class FormMain : Form        
    {
        #region Variables
        /// <summary>
        /// Размер ячейки поля
        /// </summary>
        private int size = 10;
       // Panel mineFieldPanel;


        #endregion

        #region Constructors;

        public FormMain()
        {
            InitializeComponent();
            CreateField(nPanel);
            Game.Init();
        }

        #endregion

        #region Event

        private void Cell_Click(object sender, EventArgs e)
        {
            // string massege = string.Format("i:{0}, i:{1}, i:({2})",
            //     (sender as Cell).i,
            //     (sender as Cell).j,
            //     (sender as Cell).Parent.Name);
            // MessageBox.Show(massege);
            if ((sender as Cell).Parent.Name == "mineField")
            {
                if (Game.mineField[(sender as Cell).i, (sender as Cell).j] == CellState.Empty)
                {
                    Game.mineField[(sender as Cell).i, (sender as Cell).j] = CellState.Flag;
                    UpdateField((sender as Cell).Parent as Panel);
                }
            }
        }
        private void UpdateField(Panel panel)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (panel.Name == "mineField")
                    {
                        switch (Game.mineField[i, j])
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
        #endregion

        #region Methods

        /// <summary>
        /// Методсоздает массив ячеек игрового моря
        /// </summary>
        /// <param name="panel"></param>

        private void CreateField(Panel panel)
        {
            char[] gorizontal = new char[10] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            char[] vertical = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Cell cell = new Cell(i, j)
                    {
                        Name = string.Format("{0}_{1}", i, j),
                        Left = size + i * size,
                        Top = size + j * size,
                        Width = size,
                        Height = size,
                    };
                    cell.Click += Cell_Click;
                    panel.Controls.Add(cell);
                }
                /*
                panel.Controls.Add(new Label()
                {
                    Left = 0,
                    Top = size + j * size,
                    Width = size,
                    Height = size,
                    Text = vertical[j].ToString(),
                    TextAlign = ContentAlignment.MiddleCenter
                });

                panel.Controls.Add(new Label()
                {
                    Left = size + j * size,
                    Top = 0,
                    Width = size,
                    Height = size,
                    Text = gorizontal[j].ToString(),
                    TextAlign = ContentAlignment.MiddleCenter
                });*/
            }


            }
            #endregion
        }
    }
