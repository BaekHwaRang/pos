using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
   
    public partial class age : Form
    {

        int man1=0, man2=0, man3=0, man4=0, woman1=0, woman2=0, woman3=0, woman4=0; // 14 19 20 30

        private void Age_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        public age()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(sender==man14)
            {
                man1++;
                
            }
            else if(sender==man19)
            {
                man2++;
            }
            else if (sender == man20)
            {
                man3++;
            }
            else if (sender == man30)
            {
                man4++;
            }
            else if (sender == woman14)
            {
                woman1++;
            }
            else if (sender == woman19)
            {
                woman2++;
            }
            else if (sender == woman20)
            {
                woman3++;
            }
            else if (sender == woman30)
            {
                woman4++;
            }
            ShowForm2();
        }
        void ShowForm2()
        {
            Main mainForm = new Main(this);
            mainForm.StartPosition = FormStartPosition.Manual;
            mainForm.Location = new Point(this.Location.X, this.Location.Y);

            mainForm.Shown += (sf, se) => { this.Hide(); };
            mainForm.FormClosing += (sf, se) => { this.Show(); };
            mainForm.Show();
        }
    }
}
