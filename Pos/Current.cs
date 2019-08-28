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
    public partial class Current : Form
    {
        Main CounterForm;
        string strData = "Server=localhost;Database=convenience;Uid=root;Pwd=1234;";
        public Current(Main Counter_Form)
        {
            InitializeComponent();
            CounterForm = Counter_Form;
        }

        private void UpdateTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 || e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Current_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(strData);
            DataTable dt = new DataTable();
            string bar = "select * from money;";
            conn.Open();
            MySqlCommand cd  = new MySqlCommand(bar, conn);
            MySqlDataReader reader = cd.ExecuteReader();

            while (reader.Read())
            {
                PosMoney.Text = reader[0].ToString();
            }
            conn.Close();
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ResultField.Text = "0";
                ResultField.Text = (int.Parse(PosMoney.Text) + int.Parse(updateTextBox.Text)).ToString();
            }
            catch { }
        }

        private void MiunsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ResultField.Text = "0";
                ResultField.Text = (int.Parse(PosMoney.Text) - int.Parse(updateTextBox.Text)).ToString();
            }
            catch { }
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ResultField.Text = "0";
                ResultField.Text = updateTextBox.Text;
            }
            catch { }
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (ResultField.Text.Equals(""))
                ResultField.Text = "0";

               string updating = "update money set price = " + ResultField.Text + "";
               MySqlConnection conn = new MySqlConnection(strData);
               conn.Open();
               MySqlCommand cm = new MySqlCommand(updating, conn);
               cm.ExecuteNonQuery();
               conn.Close();
               MessageBox.Show("잔고수정이 완료되었습니다.");

               PosMoney.Text = ResultField.Text;
               updateTextBox.Text = "";
               ResultField.Text = "";
        }
    }
}
