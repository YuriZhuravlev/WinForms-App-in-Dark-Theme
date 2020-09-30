using lab_5.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms;

namespace lab_5
{
    public partial class Form1 : Form
    {
        ExtendedDoubleArray doubleArray;

        public void SetMatrix(ref double[,] matrix)
        {
            doubleArray.A = matrix;
        }

        public void GetMatrix(out double[,] matrix)
        {
            matrix = doubleArray.A;
        }

        public void SetArray(ref double[] array)
        {
            doubleArray.P = array;
        }

        public void GetArray(out double[] array)
        {
            array = doubleArray.P;
        }

        public void Compute(out double averageP, out double minimumA, out double[] array)
        {
            averageP = doubleArray.AverageP;
            minimumA = doubleArray.MinimumA;
            doubleArray.Processing();
            array = doubleArray.P;
        }

        public Form1()
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = this.BackColor;
                    break;
                }
            }
            doubleArray = new ExtendedDoubleArray(0,0,0);

        }
        
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void вводМатрицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (вводМатрицыToolStripMenuItem.Checked)
            {
                InputMatrix inputMatrix = new InputMatrix();
                inputMatrix.MdiParent = this;
                
                inputMatrix.Show();
            } else
            {
                bool fl = true;
                for (int i=0; fl && i<this.MdiChildren.Length; i++)
                {
                    if (MdiChildren[i] is InputMatrix)
                    {
                        MdiChildren[i].Close();
                        fl = false;
                    }
                }
            }
        }

        public void inputMatrixClose()
        {
            вводМатрицыToolStripMenuItem.Checked = false;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutForm = new AboutBox1();
            aboutForm.Show();
        }

        private void каскадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void поГоризонталиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void поВертикалиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void вводМассиваPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (вводМассиваPToolStripMenuItem.Checked)
            {
                InputArray inputArray = new InputArray();
                inputArray.MdiParent = this;
                inputArray.Show();
            }
            else
            {
                bool fl = true;
                for (int i = 0; fl && i < this.MdiChildren.Length; i++)
                {
                    if (MdiChildren[i] is InputArray)
                    {
                        MdiChildren[i].Close();
                        fl = false;
                    }
                }
            }
        }

        public void inputArrayClose()
        {
            вводМассиваPToolStripMenuItem.Checked = false;
        }

        private void вычислениеРезультатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (вычислениеРезультатаToolStripMenuItem.Checked)
            {
                ResultForm resultForm = new ResultForm();
                resultForm.MdiParent = this;
                resultForm.Show();
            }
            else
            {
                bool fl = true;
                for (int i = 0; fl && i < this.MdiChildren.Length; i++)
                {
                    if (MdiChildren[i] is ResultForm)
                    {
                        MdiChildren[i].Close();
                        fl = false;
                    }
                }
            }
        }

        public void resultFormClose()
        {
            вычислениеРезультатаToolStripMenuItem.Checked = false;
        }

        private void закрытьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i=MdiChildren.Length-1; i>=0; i--)
            {
                MdiChildren[i].Close();
            }
        }

        private void закрытьТекущееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
        }
    }
}
