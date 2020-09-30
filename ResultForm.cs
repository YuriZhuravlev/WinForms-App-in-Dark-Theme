using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            (MdiParent as Form1).resultFormClose();
        }

        private void ResultForm_Shown(object sender, EventArgs e)
        {
            try
            {
                double[] array;
                double average, minimum;
                (MdiParent as Form1).Compute(out average, out minimum, out array);
                darkTextBox1.Text = String.Join(" ", array);
                darkTextBox2.Text = average.ToString();
                darkTextBox3.Text = minimum.ToString();
            } catch (Exception)
            {
                MessageBox.Show("Введите данные", "Ошибка!", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            try
            {
                double[] array;
                double average, minimum;
                (MdiParent as Form1).Compute(out average, out minimum, out array);
                darkTextBox1.Text = String.Join(" ", array);
                darkTextBox2.Text = average.ToString();
                darkTextBox3.Text = minimum.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Введите данные", "Ошибка!", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
