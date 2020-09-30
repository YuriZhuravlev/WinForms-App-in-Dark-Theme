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
    public partial class InputArray : Form
    {
        public InputArray()
        {
            InitializeComponent();
        }

        private void InputArray_FormClosed(object sender, FormClosedEventArgs e)
        {
            (MdiParent as Form1).inputArrayClose();
        }

        private void InputArray_Shown(object sender, EventArgs e)
        {
            double[] array;
            (MdiParent as Form1).GetArray(out array);
            if (array.Length > 0)
            {
                darkTextBox1.Text = String.Join(" ", array);
            }
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            bool fl = true;
            string[] nums = darkTextBox1.Text.Split(new char[] { ' ', ';' });
            double[] array = new double[nums.GetLength(0)];
            for (int i = 0; fl && i < nums.GetLength(0); i++)
            {
                fl = double.TryParse(nums[i], out array[i]);
            }
            if (fl)
            {
                (MdiParent as Form1).SetArray(ref array);
            } else
            {
                MessageBox.Show("Проверьте данные", "Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
