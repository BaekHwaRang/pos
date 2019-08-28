using MySql.Data.MySqlClient;
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
    public partial class product : Form
    {
        Main counterForm;
        public product(Main main_Form)
        {
            InitializeComponent();
            counterForm = main_Form;
        }
        bool Check = false;
        string strData = "Server=localhost;Database=convenience;Uid=root;Pwd=1234;";
        private void Enter_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(strData);
            DataTable dt = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            string bar = "select *  from pos where barcode='" + barcodeText.Text + "';";
            try
            {
                if (barcodeText.Text.Equals("ALL"))
                {
                    bar = "select *  from pos;";
                    dataAdapter.SelectCommand = new MySqlCommand(bar, conn);
                    dataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    Check = true;
                }
                else if(barcodeText.Text.Equals("clear")) 
                {
                    dataAdapter.Fill(dt);
                    dataGridView1.Rows.Clear();
                    Check = true;
                }
                
                else{
                    dataAdapter.SelectCommand = new MySqlCommand(bar, conn);
                    dataAdapter.Fill(dt);
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1["바코드", i].Value.ToString().Equals(dt.Rows[0][0].ToString().ToString()))
                        {
                            Check = true;
                        }
                    }
                    if (Check)
                        Check = false;
                    else if (!Check)
                        dataGridView1.Rows.Add(dt.Rows[0].ItemArray);
                }
                } catch { MessageBox.Show("상품바코드가 아닙니다"); } 
        }
    }
}
