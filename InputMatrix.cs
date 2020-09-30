using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab_5.Resources
{
    public partial class InputMatrix : Form
    {

        public InputMatrix()
        {
            Application.EnableVisualStyles();
            
            InitializeComponent();
        }

        private void InputMatrix_FormClosed(object sender, FormClosedEventArgs e)
        {
            (MdiParent as Form1).inputMatrixClose();
        }

        private void InputMatrix_Shown(object sender, EventArgs e)
        {
            double[,] matrix;
            (MdiParent as Form1).GetMatrix(out matrix);
            darkTextBox1.Text = matrix.GetLength(0).ToString();
            darkTextBox2.Text = matrix.GetLength(1).ToString();
            if (matrix.GetLength(0) > 0)
            {
                dataGridView1.RowCount = matrix.GetLength(0);
                dataGridView1.ColumnCount = matrix.GetLength(1);
                for (int i=0; i<matrix.GetLength(0); i++)
                {
                    for (int j=0; j<matrix.GetLength(1); j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                    }
                }
            }
        }

        private void darkTextBox1_TextChanged(object sender, EventArgs e)
        {
            byte height, width;
            if (byte.TryParse(darkTextBox1.Text, out height) && 
                byte.TryParse(darkTextBox2.Text, out width) 
                && height != 0 && width != 0)
            {
                dataGridView1.RowCount = height;
                dataGridView1.ColumnCount = width;
            }
        }

        private void darkTextBox2_TextChanged(object sender, EventArgs e)
        {
            byte height, width;
            if (byte.TryParse(darkTextBox1.Text, out height) && 
                byte.TryParse(darkTextBox2.Text, out width) 
                && height != 0 && width != 0)
            {
                dataGridView1.RowCount = height;
                dataGridView1.ColumnCount = width;
            }
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0 && dataGridView1.ColumnCount > 0)
            {
                bool fl = true;
                double[,] matrix = new double[dataGridView1.RowCount, dataGridView1.ColumnCount];
                for (int i = 0; fl && i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; fl && j < dataGridView1.ColumnCount; j++)
                    {
                        fl = double.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out matrix[i, j]);
                    }
                }
                if (fl)
                {
                    (MdiParent as Form1).SetMatrix(ref matrix);
                    return;
                }
            }
            MessageBox.Show("Проверьте данные","Ошибка!", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            
        }
    }
}
