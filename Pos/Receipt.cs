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
    public partial class Receipt : Form
    {
        string strData = "Server=localhost;Database=convenience;Uid=root;Pwd=1234;";
        Main counter;
        public Receipt(Main Main_Form)
        {
            InitializeComponent();
            counter = Main_Form;
        }
        DataTable chart,buyChart;
        private void Receipt_Load(object sender, EventArgs e)
        {
            chart = dataChart();
            buyChart = dataBuyChart();
            dataGridView1.DataSource = chart;
            dataGridView2.DataSource = buyChart;
           
            
            //chart.Rows.Clear();
        }

        private DataTable dataBuyChart()
        {
            MySqlConnection conn = new MySqlConnection(strData);
            DataTable dt = new DataTable();
            string bar = "select * from buy ;";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = new MySqlCommand(bar, conn);
            dataAdapter.Fill(dt);
            return dt;
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<dataGridView1.Rows.Count;i++)
            {
               if(dataGridView1.Rows[i].Selected==true)
                {
                    ReceiptTime.Text= dataGridView2["times", i].Value.ToString();
                    SumLabel.Text = dataGridView2["totalprice", i].Value.ToString();
                    ReceiptCh.Text = dataGridView2["cash", i].Value.ToString();
                    ReceiptCard.Text = dataGridView2["card", i].Value.ToString();
                    Content.Text = dataGridView2["productText", i].Value.ToString()+"\n\n" +
                        "합계 : "+SumLabel.Text+"\n" +
                        "현금 : "+ReceiptCh.Text+"\n"+
                        "카드 : "+ReceiptCard.Text+"" ;
                    if (int.Parse(dataGridView2["cash", i].Value.ToString()) > 0 && int.Parse(dataGridView2["card", i].Value.ToString())>0)
                        tradeLabel.Text = "현금 , 카드";
                    else if (int.Parse(dataGridView2["cash", i].Value.ToString()) > 0)
                        tradeLabel.Text = "현금";
                    else if (int.Parse(dataGridView2["card", i].Value.ToString()) > 0)
                        tradeLabel.Text = "카드";
                }
            }
        }

        private DataTable dataChart()
        {
            MySqlConnection conn = new MySqlConnection(strData);
            DataTable dt = new DataTable();
            string bar = "select * from inquiry ;";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = new MySqlCommand(bar, conn);
            dataAdapter.Fill(dt);
            return dt;
        }
    }
}
