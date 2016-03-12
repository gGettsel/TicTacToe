using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTac
{
    public partial class Form1 : Form
    {
        int CountColumn = 0;
        int CountRows = 0;
        bool who = true; // TRUE - X ; FALSE - O

        
        public Form1()
        {
            InitializeComponent();
            DrawCell(10, 10);
            
        }

        public void DrawCell(int count_x, int count_y)
        {
            for (int i = CountColumn; i < count_y; i++)
            {
                pole.Columns.Add("cell" + i, Convert.ToString(i));
                pole.Columns[i].Width = 30;
            }
            pole.Rows.Add(count_y);
            for (int j = CountRows; j < count_y; j++)
                for (int i = CountColumn; i < count_x; i++)
                    pole[i, j].Value = null;

            CountColumn = count_x;
        }

        private int winHorizontal(int x, int y)
        {
            string whoByte = pole[x,y].Value.ToString();
            bool flag = false;
            int count = 0;
            for (int temp = 1; temp < 5; temp++)
            {
                if (!flag)
                {
                    if ((pole[x + temp, y].Value == null) || (pole[x + temp, y].Value.ToString() != whoByte) || (x + temp > pole.ColumnCount))
                    {
                        flag = !flag;
                        count = temp - 1;
                        temp = 0;
                    }
                }
                else
                    if ((pole[x + temp, y].Value == null) || (pole[x - temp, y].Value.ToString() != whoByte) || (x - temp < 0) || pole[x - temp, y].Value == null)
                    return count + temp;
            }
            return count;
        }
        private bool Win(int x, int y)
        {
            if (winHorizontal(x, y) == 5)
                return true;
            return false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (who)
                pole[e.ColumnIndex, e.RowIndex].Value = "X";
            else
                pole[e.ColumnIndex, e.RowIndex].Value = "O";
            if (Win(e.ColumnIndex, e.RowIndex))
                MessageBox.Show(who ? "Победили X" : "Победили O");
            who = !who;
        }
    }
}
