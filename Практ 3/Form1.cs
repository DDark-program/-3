using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_2;
using LibMas;

namespace Практ_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Table.ColumnCount = 4;
            Table.RowCount = 4;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Mass.ClearMatr(Table);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Mass.SaveMatr(Table);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Mass.OpenMatr(Table);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор программы:\n" +
                "Студент группы ИСП-31\n" +
                "Подъяблонский Данила Владимирович\n" +
                "Задание:\n" +
                "ана целочисленная матрица размера M × N.\n" +
                "Найти номер последнего из ее столбцов,\n" +
                "содержащих равное количество положительных и отрицательных элементов (нулевые элементы матрицы не учитываются)\n" +
                "Если таких столбцов нет, то вывести 0. ");
        }

        private void NumUpDownColumns_ValueChanged(object sender, EventArgs e)
        {
            Table.ColumnCount = Convert.ToInt32(NumUpDownColumns.Value);
        }

        private void NumUpDownRows_ValueChanged(object sender, EventArgs e)
        {
            Table.RowCount = Convert.ToInt32(NumUpDownRows.Value);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mass.SaveMatr(Table);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mass.OpenMatr(Table);
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void заданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание:\n" +
                "Дана целочисленная матрица размера M × N.\n" +
                "Найти номер последнего из ее столбцов,\n" +
                "содержащих равное количество положительных и отрицательных элементов \n" +
                "(нулевые элементы матрицы не учитываются)\n" +
                "Если таких столбцов нет, то вывести 0.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mass.FillMatr(Table);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtCalc.Text = (TaskMatr.FindClone(Table)+1).ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
