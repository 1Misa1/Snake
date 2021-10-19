using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        PictureBox had1;
        PictureBox had2;

        public Form1()
        {
            InitializeComponent();
            VytvorHady();

        }
        private void VytvorHady()
        {
            had1 = new PictureBox();
            had1.Size = new Size(40,40);
            had1.Location = new Point(10, 10);
            had1.BackColor = Color.LimeGreen;
            this.Controls.Add(had1);

            had2 = new PictureBox();
            had2.Size = new Size(40, 40);
            had2.Location = new Point(ClientSize.Width-60,10);
            had2.BackColor = Color.Red;
            this.Controls.Add(had2);
        }
    }

}
