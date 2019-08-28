using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
namespace Pos
{
    public partial class Main : Form
    {
        age ageForm;

        bool asphone = false;
        string strData = "Server=localhost;Database=convenience;Uid=root;Pwd=1234;";
        int cellindex = 0; int sum = 0;
        int totalSum = 0; int totaldis=0; int totalrec=0;
        int TotalMoney = 0;

        public Main(age age_Form)
        {
            InitializeComponent();
            ageForm = age_Form;
        }


        private void Button10_Click(object sender, EventArgs e) // AS 버튼 텍스트 변경
        {
            if (asphone)
            {
                AS.Text = "A/S\n연락처";
                asphone = false;
            }
            else
            {
                AS.Text = "010-5874-1253";
                asphone = true;
            }
        }

        private void Button9_Click(object sender, EventArgs e) //backspace 키와 같은 동작을 하는 버튼
        {
            barcodeText.Focus();
            SendKeys.Send("{BACKSPACE}");
        }

        int[] amount = new int[20];
        DataTable eventData = new DataTable();
        DataTable data = new DataTable();

        bool pcheck = false;
        private void EnterBtn(object sender, EventArgs e) // 엔터를 누를 시 DataGridView 에 데이터를 삽입
        {

            data = barcodeCheck();

            for (int i = 0; i < dataGridView1.Rows.Count; i++) // 그리드뷰에 같은 바코드의 제품있는지 확인
            {
                try
                {
                    
                        if (dataGridView1["Num", i].Value.ToString().Equals(data.Rows[0][0].ToString().ToString()))
                        {
                            amount[i]++;
                            dataGridView1["수량", i].Value = amount[i].ToString();
                            pcheck = true;
                        }
                    
                }
                catch{ }
            }
            if (pcheck)
            {
                pcheck = false;
            }
            else 
            {
                try
                {
                    dataGridView1.Rows.Add(data.Rows[0].ItemArray);
                    dataGridView1["수량", cellindex].Value = amount[cellindex];
                    cellindex++;
                }
                  catch{ MessageBox.Show("등록된 상품의 바코드가 아닙니다.");}
            }
            // 행증가

            discounts(); // 상품 이벤트 처리
            
            sum = 0;
            
            eventData.Rows.Clear();
            data.Clear();
        }
        private DataTable barcodeCheck() // 바코드데이터를 pos 테이블 검색 및 반환
        {
            MySqlConnection conn = new MySqlConnection(strData);
            DataTable dt = new DataTable();
            string bar = "select pnum , pname , price   from pos where barcode='" + barcodeText.Text + "';";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = new MySqlCommand(bar, conn);
            dataAdapter.Fill(dt);
            return dt;

        }
        private DataTable eventCheck(int product) // 이벤트 1+1 , 2+1 검사
        {
            MySqlConnection conn = new MySqlConnection(strData);
            DataTable dt = new DataTable();
            string bar = "select event11,event22 from pos where pnum=" + product + ";";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = new MySqlCommand(bar, conn);

            dataAdapter.Fill(dt);
            return dt;
        }
        private void discounts() // 이벤트 1+1 . 2 + 1 계산
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try{
                    sum += int.Parse(dataGridView1["수량", i].Value.ToString());

                    totalSum = totalSum+int.Parse(dataGridView1["수량", i].Value.ToString().ToString());
                    TotalAmount.Text = totalSum.ToString();

                    eventData = eventCheck(int.Parse(dataGridView1["Num", i].Value.ToString()));
                    if (eventData.Rows[0][0].ToString().ToString()=="True") // 1+1
                    {
                        int temp = int.Parse(dataGridView1["수량", i].Value.ToString());
                        dataGridView1["할인", i].Value = ((temp / 2) * int.Parse(dataGridView1["단가", i].Value.ToString())).ToString();
                        dataGridView1["영수액", i].Value = (temp * int.Parse(dataGridView1["단가", i].Value.ToString()) - int.Parse(dataGridView1["할인", i].Value.ToString())).ToString();
                        
                    }
                    else if (eventData.Rows[0][1].ToString().ToString()=="True") // 2+1
                    {
                        int temp = int.Parse(dataGridView1["수량", i].Value.ToString());
                        dataGridView1["할인", i].Value = ((temp / 3) * int.Parse(dataGridView1["단가", i].Value.ToString())).ToString();
                        dataGridView1["영수액", i].Value = (temp * int.Parse(dataGridView1["단가", i].Value.ToString()) - int.Parse(dataGridView1["할인", i].Value.ToString())).ToString();

                        //if (int.Parse(dataGridView1["수량", i].Value.ToString()) % 3 == 0)
                         //   TotalCheck = true;
                    }
                    else
                    {
                        int temp = int.Parse(dataGridView1["수량", i].Value.ToString());
                        dataGridView1["할인", i].Value = 0.ToString();
                        dataGridView1["영수액", i].Value = (temp*int.Parse(dataGridView1["단가", i].Value.ToString())).ToString();
                    }

                     totaldis = totaldis + int.Parse(dataGridView1["할인", i].Value.ToString());
                     TotalDiscount.Text = totaldis.ToString();
                     
                    totalrec = totalrec + int.Parse(dataGridView1["영수액", i].Value.ToString());
                    TotalReceipt.Text = totalrec.ToString();

                }catch{ }
            }totalSum = 0; totaldis = 0; totalrec= 0;
        }

        private void productJoin_Click(object sender, EventArgs e) // 상품조회 페이지로 이동
        {
            product productForm = new product(this);
            productForm.StartPosition = FormStartPosition.Manual;
            productForm.Location = new Point(this.Location.X, this.Location.Y);

            productForm.Shown += (sf, se) => { this.Hide(); };
            productForm.FormClosing += (sf, se) => { this.Show(); };
            productForm.Show();
        }

       /* private void Hold_Click(object sender, EventArgs e)
        {

        }
       */
        private void Main_Load(object sender, EventArgs e)
        {
            amountReset();
        }

        private void amountReset() // 상품등록시 1개로 초기화
        {
            for (int i = 0; i < amount.Length; i++)
            {
                amount[i] = 1;
            }
        }

       

        private void allcancel_Click(object sender, EventArgs e) // 일괄취소 버튼
        {
            all();
        }
        private void all()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            amountReset();
            cellindex = 0;
            TotalAmount.Text = "0"; TotalDiscount.Text = "0"; TotalReceipt.Text = "0";
            sum = 0;
            Money1.Text = "0"; Money2.Text = "0"; Money3.Text = "0";
            barcodeText.Text = "";
        }

        private void onecancel_Click(object sender , EventArgs e ) // 지정취소 버튼
        {
            for(int i=0; i<dataGridView1.Rows.Count; i++)
            {
                try
                {
                    if (dataGridView1.Rows[i].Selected == true)
                    {
                        dataGridView1["수량", i].Value = "0";
                        amount[i] = 0;
                        discounts();
                    }
                }
                catch { }
            }

        }
        bool tradeCheck = false;
        private void cashTrade_Click_1(object sender, EventArgs e) // 현금결제 버튼 이벤트
        {
            if (!tradeCheck)
            { 
                Money1.Text = TotalReceipt.Text;
                Money3.Text = (-int.Parse(TotalReceipt.Text)).ToString();
                Money2.Focus();
                tradetext.Text = "현금결제";
                tradeCheck = true;
                Money2.Enabled = true;
                Money2.Text = "";
            }
            else if (tradeCheck)
            {
               if(Money2.Text.Equals(""))
                MessageBox.Show("받은금액을 입력해주세요");

               else if(int.Parse(Money1.Text) < int.Parse(Money2.Text))
                {
                    Money2.Text = Money1.Text;
                }
               else if(int.Parse(Money1.Text)> int.Parse(Money2.Text))
                {
                    MessageBox.Show("금액을 더 받아주세요");
                }
                else if (int.Parse(Money3.Text) >= 0)
                {
                    JournalCheck();
                    all();
                    Money2.Enabled = false;
                    Money2.Text = "";
                    tradetext.Text = "";
                    tradeCheck = false;
                }
               
            }
        }

        private void CardTrade_Click(object sender, EventArgs e) // 카드결제 버튼 이벤트
        {
            tradetext.Text = "카드결제";
            Money1.Text = TotalReceipt.Text;
            Money3.Text = (-int.Parse(TotalReceipt.Text)).ToString();
            if (int.Parse(Money3.Text) < 0)
            {
                JournalCheck();
                all();
                Money2.Enabled = false;
                Money2.Text = "";
                tradetext.Text = "";
            }
            else { 
            MessageBox.Show("잘못된 동작입니다.");
                tradetext.Text = "";
            }
        }


        private void JournalCheck() // 계산이 끝난 상품정보 , 거래번호 , 시간 저장
        {
            MySqlConnection conn = new MySqlConnection(strData);
            conn.Open();
            string bar = "insert into inquiry(days,times,price) value('"+ DateTime.Now.ToString("yy-MM-dd")+"' , '"+DateTime.Now.ToString("HH:mm")+"' , "+TotalReceipt.Text+");";
            MySqlCommand inquiry = new MySqlCommand(bar, conn);
            inquiry.ExecuteNonQuery();

            string sum = "";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                sum += dataGridView1["상품명", i].Value.ToString()+"   ";
                sum += dataGridView1["수량", i].Value+"EA     ";
                sum += dataGridView1["영수액", i].Value.ToString()+" won\n";
            }
            if (Money2.Text.Equals(""))
                Money2.Text = "0";
            string insert = "insert into buy(times,productText,totalprice,cash,card) " +
                "value('" + DateTime.Now.ToString("yy-MM-dd") + " (" + GetDayOfWeek(DateTime.Now) + ") " +
                    DateTime.Now.ToString("HH:mm") + "' , " +
                      "'" + sum + "' , "+ Money1.Text+" , "+Money2.Text+" , " +
                      ""+(int.Parse(TotalReceipt.Text) - int.Parse(Money2.Text)).ToString()+");";
                MySqlCommand buy = new MySqlCommand(insert, conn);
                buy.ExecuteNonQuery();
                conn.Close();
            MessageBox.Show("거래가 완료되었습니다.");
            MoneySend(int.Parse(Money1.Text));
            ProductMinus();
        }

        private void ProductMinus()
        {
            MySqlConnection conn = new MySqlConnection(strData);
            conn.Open();
            int Minus = 0;
            for(int i=0;i<dataGridView1.RowCount;i++)
            {
                Minus=int.Parse(dataGridView1["수량", i].Value.ToString());
                string update = "update pos set amount = amount-" + Minus + " where pnum ="+dataGridView1["Num",i].Value.ToString()+";";
                MySqlCommand cm = new MySqlCommand(update, conn);
                cm.ExecuteNonQuery();
            }
            conn.Close();
        }

        private void MoneySend(int v)
        {
            MySqlConnection conn = new MySqlConnection(strData);
            string update = "update money set price = price+" + v + ";";
            conn.Open();
            MySqlCommand cm = new MySqlCommand(update, conn);
            cm.ExecuteNonQuery();
            conn.Close();
        }

        private string GetDayOfWeek(DateTime dateTime) // 결제 날짜 요일체크

        {

            var day = dateTime.DayOfWeek;

            string week = string.Empty;

            switch (day)

            {

                case DayOfWeek.Monday:

                    week = "Mon";

                    break;

                case DayOfWeek.Tuesday:

                    week = "Tue";

                    break;

                case DayOfWeek.Wednesday:

                    week = "Wed";

                    break;

                case DayOfWeek.Thursday:

                    week = "Thu";

                    break;

                case DayOfWeek.Friday:

                    week = "Fri";

                    break;

                case DayOfWeek.Saturday:

                    week = "Sat";
                    break;

                case DayOfWeek.Sunday:

                    week = "Sun";

                    break;

                default:

                    break;

            }

            return week;

        }
        
        private void tradeJoin_Click_1(object sender, EventArgs e) // 저널조회 , 거래조회 페이지 이동
        {
            Receipt ReceiptForm = new Receipt(this);
            ReceiptForm.StartPosition = FormStartPosition.Manual;
            ReceiptForm.Location = new Point(this.Location.X, this.Location.Y);

            ReceiptForm.Shown += (sf, se) => { this.Hide(); };
            ReceiptForm.FormClosing += (sf, se) => { this.Show(); };
            ReceiptForm.Show();
        }
        private void Disposal_Click(object sender, EventArgs e) // 상품관리 페이지 이동
        {
            productUpdate productUpdate_Form = new productUpdate(this);
            productUpdate_Form.StartPosition = FormStartPosition.Manual;
            productUpdate_Form.Location = new Point(this.Location.X, this.Location.Y);

            productUpdate_Form.Shown += (sf, se) => { this.Hide(); };
            productUpdate_Form.FormClosing += (sf, se) => { this.Show(); };
            productUpdate_Form.Show();

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            amountReset();
            cellindex = 0;
            TotalAmount.Text = "0"; TotalDiscount.Text = "0"; TotalReceipt.Text = "0";
            sum = 0;
        }
        private void Current_Click(object sender, EventArgs e) // 포스 현재고 페이지 이동
        {
            Current Current_Form = new Current(this);
            Current_Form.StartPosition = FormStartPosition.Manual;
            Current_Form.Location = new Point(this.Location.X, this.Location.Y);

            Current_Form.Shown += (sf, se) => { this.Hide(); };
            Current_Form.FormClosing += (sf, se) => { this.Show(); };
            Current_Form.Show();
        }
        private void Money2_KeyUp(object sender, KeyEventArgs e)  // 바코드 0~9까지만 입력제한
        {
            try
            {
                if (e.KeyCode==Keys.Enter)
                {
                    TotalMoney += int.Parse(Money1.Text);

                    // Insert into
                    JournalCheck();
                }
                else if (e.KeyCode>=Keys.D0 || e.KeyCode<=Keys.D9 || e.KeyCode == Keys.Back)
                {
                    e.Handled = true;
                }
                Money3.Text = (int.Parse(Money2.Text) - int.Parse(Money1.Text)).ToString();
               
            }
            catch { }
        }
        private void Presetkey_Click(object sender, EventArgs e) // 간편 상품버튼 공개
        {
            PresetClick();
        }
         private void Label1_Click(object sender, EventArgs e) // 
        {
            PresetClick();
        }
        private void PresetClick()
        {
                PresetPanel.Visible = true;
                label2.Visible = false;
                preBtn1.Visible = true;
                preBtn2.Visible = true;
                preBtn3.Visible = true;
                preBtn4.Visible = true;
                preBtn5.Visible = true;
                preBtnExit.Visible = true;
        }

        private void Button5_Click(object sender, EventArgs e) // (PresetKey 닫기) 프리셋화면 off
        {
            PresetPanel.Visible = false;
            label2.Visible = true;
            preBtn1.Visible = false;
            preBtn2.Visible = false;
            preBtn3.Visible = false;
            preBtn4.Visible = false;
            preBtn5.Visible = false;
            preBtnExit.Visible = false;
        }
        bool presetCheck = false;
        private void PreBtn1_Click(object sender, EventArgs e) // PresetKey 상품버튼 이벤트
        {
            PreCal("101" , "bag" , 20 , 1,0 ,"20");
        }

        private void PreBtn2_Click(object sender, EventArgs e)
        {
            PreCal("102", "Jongryangje  20L", 500,1,0,"500");
        }

        private void PreBtn3_Click(object sender, EventArgs e)
        {
            PreCal("103", "Jongryangje  50L", 1150, 1, 0, "1150");
        }

        private void PreBtn4_Click(object sender, EventArgs e)
        {
            PreCal("104", "lighter", 500, 1, 0, "500");
        }

        private void PreBtn5_Click(object sender, EventArgs e)
        {
            PreCal("105", "Turbolighter", 1000, 1, 0, "1000");
        }
        private void PreCal(string num, string name, int p, int a, int t, string r)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1["Num", i].Value.ToString().Equals(num))
                {
                    presetCheck = true;
                    int temp = int.Parse(dataGridView1["수량", i].Value.ToString());
                    dataGridView1["수량", i].Value = (++temp).ToString();
                    dataGridView1["영수액", i].Value = temp * p;
                    discounts();
                }
            }
            if (presetCheck)
                presetCheck = false;

            else
                dataGridView1.Rows.Add(num,name, p, a, t,r);
            discounts();
        }

    }
}