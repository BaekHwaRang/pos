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
    public partial class productUpdate : Form
    {
        string strData = "Server=localhost;Database=convenience;Uid=root;Pwd=1234;";
        Main counterForm;
        bool One, Two, n=false;
        public productUpdate(Main main_Form)
        {
            InitializeComponent();
            counterForm = main_Form;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            barcodeText.Focus();
            SendKeys.Send("{BACKSPACE}");
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            DataTable data = barcodeCheck();

            bool pcheck = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    if (dataGridView1["Num", i].Value.ToString().Equals(data.Rows[0][1].ToString().ToString()))
                    {
                        pcheck = true;
                    }
                }
                catch { }
            }
            if (pcheck)
                pcheck = false;
            else
            {
                try
                {
                    dataGridView1.Rows.Add(data.Rows[0].ItemArray);
                    data.Clear();
                }
                catch { MessageBox.Show("등록된 상품의 바코드가 아닙니다."); }
            }
        }
        private DataTable barcodeCheck() // 바코드데이터를 pos 테이블 검색 및 반환
        {
            
            MySqlConnection conn = new MySqlConnection(strData);
            DataTable dt = new DataTable();
            string bar = "select barcode,pnum , pname , price,event11,event22,amount from pos where barcode='" + barcodeText.Text + "';";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = new MySqlCommand(bar, conn);
            dataAdapter.Fill(dt);
            return dt;
        }
        private void None_Click(object sender, EventArgs e)
        {
            ColorSet();
            none.BackColor = Color.Lime;
            n = true;
            One = false;
            Two = false;
        }
       
        private void OnePlus_one_Click(object sender, EventArgs e)
        {
            ColorSet();
            onePlus_one.BackColor = Color.Lime;
            n = false;
            One = true;
            Two = false;
        }

        private void TwoPlus_one_Click(object sender, EventArgs e)
        {
            ColorSet();
            twoPlus_one.BackColor = Color.Lime;
            n = false;
            One = false;
            Two = true;
        }

       

        private void ColorSet()
        {
            none.BackColor = Color.White;
            onePlus_one.BackColor = Color.White;
            twoPlus_one.BackColor = Color.White;
        }
        int checkIndex = 0;
        int bools1 = 0;
        int bools2 = 0;

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    checkIndex = i;
                }
                string change = "delete from pos where pnum = "+dataGridView1["Num",checkIndex].Value.ToString()+";";
                MySqlConnection conn = new MySqlConnection(strData);
                conn.Open();
                MySqlCommand cm = new MySqlCommand(change, conn);
                cm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("상품을 삭제하였습니다.");

            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string insert = "insert into pos(barcode,pname,price,event11,event22,amount) " +
                "value('"+barcodeText.Text+"','"+nameField.Text+"',"+priceField.Text+","+bools1+","+bools2+","+amountField.Text+");";
           
            MySqlConnection conn = new MySqlConnection(strData);
            conn.Open();
            MySqlCommand cm = new MySqlCommand(insert, conn);
            cm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("상품을 추가하였습니다.");
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    dataGridView1["상품명", i].Value = nameField.Text;
                    dataGridView1["단가", i].Value = priceField.Text;
                    dataGridView1["수량", i].Value = amountField.Text;

                    if (n)
                    {
                        dataGridView1["OnePlus", i].Value = "False";
                        dataGridView1["TwoPlus", i].Value = "False";
                        bools1 = 0;bools2 = 0;
                    }
                    else if (One)
                    {
                        dataGridView1["OnePlus", i].Value = "True";
                        dataGridView1["TwoPlus", i].Value = "False";
                        bools1 = 1; bools2 = 0;
                    }
                    else if (Two)
                    {
                        dataGridView1["OnePlus", i].Value = "False";
                        dataGridView1["TwoPlus", i].Value = "True";
                        bools1 = 0; bools2 = 1;
                    }
                    checkIndex = i;
                    
                }
                string change = "update pos set pname ='"+ dataGridView1["상품명", checkIndex].Value .ToString()+"'," +
                                            " price ="+ dataGridView1["단가", checkIndex].Value.ToString() + "," +
                                              " amount ="+ dataGridView1["수량", checkIndex].Value .ToString()+"," +
                                                " event11 ="+bools1+"," +
                                                    " event22 ="+ bools2+"" +
                                                    " where pnum = " + dataGridView1["Num", checkIndex].Value.ToString() + ";";
                MySqlConnection conn = new MySqlConnection(strData);
                conn.Open();
                MySqlCommand cm = new MySqlCommand(change, conn);
                cm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("상품의 정보를 변경하였습니다.");

            
            }
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    if (dataGridView1.Rows[i].Selected == true)
                    {
                        nameField.Text=dataGridView1["상품명", i].Value.ToString();
                        priceField.Text= dataGridView1["단가", i].Value.ToString();
                        amountField.Text= dataGridView1["수량", i].Value.ToString();

                        if (dataGridView1["OnePlus", i].Value.ToString().ToString() == "false" && dataGridView1["TwoPlus", i].Value.ToString().ToString() == "false")
                        {
                            ColorSet();
                            none.BackColor = Color.Lime;
                            n = true;
                            One = false;
                            Two = false;
                        }
                        else if (dataGridView1["OnePlus", i].Value.ToString().ToString()=="True")
                        {
                            ColorSet();
                            onePlus_one.BackColor = Color.Lime;
                            n = false;
                            One = true;
                            Two = false;
                        }
                        else if (dataGridView1["TwoPlus", i].Value.ToString().ToString() == "True")
                        {
                            ColorSet();
                            twoPlus_one.BackColor = Color.Lime;
                            n = false;
                            One = false;
                            Two = true;
                        }
                    }
                }
                catch { }
            }
        }
    }
}
