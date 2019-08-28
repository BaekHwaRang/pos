using System;
using System.Windows.Forms;

namespace Pos
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PresetPanel = new System.Windows.Forms.Panel();
            this.preBtnExit = new System.Windows.Forms.Button();
            this.preBtn5 = new System.Windows.Forms.Button();
            this.preBtn4 = new System.Windows.Forms.Button();
            this.preBtn3 = new System.Windows.Forms.Button();
            this.preBtn2 = new System.Windows.Forms.Button();
            this.preBtn1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Money3 = new System.Windows.Forms.TextBox();
            this.Money2 = new System.Windows.Forms.TextBox();
            this.Money1 = new System.Windows.Forms.TextBox();
            this.tradetext = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AS = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.barcodeText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Enter = new System.Windows.Forms.Button();
            this.Disposal = new System.Windows.Forms.Button();
            this.onecancel = new System.Windows.Forms.Button();
            this.allcancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상품명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.단가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.할인 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.영수액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presetkey = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mainDoun = new System.Windows.Forms.PictureBox();
            this.mainUp = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TotalReceipt = new System.Windows.Forms.TextBox();
            this.TotalDiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Current = new System.Windows.Forms.Button();
            this.tradeJoin = new System.Windows.Forms.Button();
            this.ProductJoin = new System.Windows.Forms.Button();
            this.TotalAmount = new System.Windows.Forms.TextBox();
            this.cashTrade = new System.Windows.Forms.Button();
            this.cardTrade = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.PresetPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Presetkey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDoun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainUp)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(10, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 52);
            this.label2.TabIndex = 26;
            this.label2.Text = "결\r\n제\r\n내\r\n역";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.PresetPanel);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.Money3);
            this.panel3.Controls.Add(this.Money2);
            this.panel3.Controls.Add(this.Money1);
            this.panel3.Controls.Add(this.tradetext);
            this.panel3.Location = new System.Drawing.Point(2, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(482, 78);
            this.panel3.TabIndex = 27;
            // 
            // PresetPanel
            // 
            this.PresetPanel.BackColor = System.Drawing.Color.Cyan;
            this.PresetPanel.Controls.Add(this.preBtnExit);
            this.PresetPanel.Controls.Add(this.preBtn5);
            this.PresetPanel.Controls.Add(this.preBtn4);
            this.PresetPanel.Controls.Add(this.preBtn3);
            this.PresetPanel.Controls.Add(this.preBtn2);
            this.PresetPanel.Controls.Add(this.preBtn1);
            this.PresetPanel.Location = new System.Drawing.Point(1, 0);
            this.PresetPanel.Name = "PresetPanel";
            this.PresetPanel.Size = new System.Drawing.Size(298, 78);
            this.PresetPanel.TabIndex = 46;
            this.PresetPanel.Visible = false;
            // 
            // preBtnExit
            // 
            this.preBtnExit.BackColor = System.Drawing.Color.Azure;
            this.preBtnExit.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.preBtnExit.Location = new System.Drawing.Point(204, 42);
            this.preBtnExit.Name = "preBtnExit";
            this.preBtnExit.Size = new System.Drawing.Size(75, 33);
            this.preBtnExit.TabIndex = 5;
            this.preBtnExit.Text = "닫기";
            this.preBtnExit.UseVisualStyleBackColor = false;
            this.preBtnExit.Visible = false;
            this.preBtnExit.Click += new System.EventHandler(this.Button5_Click);
            // 
            // preBtn5
            // 
            this.preBtn5.BackColor = System.Drawing.Color.Azure;
            this.preBtn5.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.preBtn5.Location = new System.Drawing.Point(109, 42);
            this.preBtn5.Name = "preBtn5";
            this.preBtn5.Size = new System.Drawing.Size(75, 33);
            this.preBtn5.TabIndex = 4;
            this.preBtn5.Text = "터보라이터\r\n1000원\r\n";
            this.preBtn5.UseVisualStyleBackColor = false;
            this.preBtn5.Visible = false;
            this.preBtn5.Click += new System.EventHandler(this.PreBtn5_Click);
            // 
            // preBtn4
            // 
            this.preBtn4.BackColor = System.Drawing.Color.Azure;
            this.preBtn4.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.preBtn4.Location = new System.Drawing.Point(16, 42);
            this.preBtn4.Name = "preBtn4";
            this.preBtn4.Size = new System.Drawing.Size(75, 33);
            this.preBtn4.TabIndex = 3;
            this.preBtn4.Text = "라이터\r\n500원";
            this.preBtn4.UseVisualStyleBackColor = false;
            this.preBtn4.Visible = false;
            this.preBtn4.Click += new System.EventHandler(this.PreBtn4_Click);
            // 
            // preBtn3
            // 
            this.preBtn3.BackColor = System.Drawing.Color.Azure;
            this.preBtn3.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.preBtn3.Location = new System.Drawing.Point(204, 6);
            this.preBtn3.Name = "preBtn3";
            this.preBtn3.Size = new System.Drawing.Size(75, 33);
            this.preBtn3.TabIndex = 2;
            this.preBtn3.Text = "종량제 \r\n50L 1150원";
            this.preBtn3.UseVisualStyleBackColor = false;
            this.preBtn3.Visible = false;
            this.preBtn3.Click += new System.EventHandler(this.PreBtn3_Click);
            // 
            // preBtn2
            // 
            this.preBtn2.BackColor = System.Drawing.Color.Azure;
            this.preBtn2.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.preBtn2.Location = new System.Drawing.Point(109, 6);
            this.preBtn2.Name = "preBtn2";
            this.preBtn2.Size = new System.Drawing.Size(75, 33);
            this.preBtn2.TabIndex = 1;
            this.preBtn2.Text = "종량제 \r\n20L 500원";
            this.preBtn2.UseVisualStyleBackColor = false;
            this.preBtn2.Visible = false;
            this.preBtn2.Click += new System.EventHandler(this.PreBtn2_Click);
            // 
            // preBtn1
            // 
            this.preBtn1.BackColor = System.Drawing.Color.Azure;
            this.preBtn1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.preBtn1.Location = new System.Drawing.Point(16, 6);
            this.preBtn1.Name = "preBtn1";
            this.preBtn1.Size = new System.Drawing.Size(75, 33);
            this.preBtn1.TabIndex = 0;
            this.preBtn1.Text = "비닐봉투\r\n20원";
            this.preBtn1.UseVisualStyleBackColor = false;
            this.preBtn1.Visible = false;
            this.preBtn1.Click += new System.EventHandler(this.PreBtn1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "거스름돈";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "받은금액";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "받을금액";
            // 
            // Money3
            // 
            this.Money3.Enabled = false;
            this.Money3.Location = new System.Drawing.Point(369, 54);
            this.Money3.Multiline = true;
            this.Money3.Name = "Money3";
            this.Money3.Size = new System.Drawing.Size(100, 21);
            this.Money3.TabIndex = 25;
            this.Money3.Text = "0";
            this.Money3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Money2
            // 
            this.Money2.Enabled = false;
            this.Money2.Location = new System.Drawing.Point(369, 29);
            this.Money2.Multiline = true;
            this.Money2.Name = "Money2";
            this.Money2.Size = new System.Drawing.Size(100, 21);
            this.Money2.TabIndex = 24;
            this.Money2.Text = "0";
            this.Money2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Money2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Money2_KeyUp);
            // 
            // Money1
            // 
            this.Money1.Enabled = false;
            this.Money1.Location = new System.Drawing.Point(369, 2);
            this.Money1.Multiline = true;
            this.Money1.Name = "Money1";
            this.Money1.Size = new System.Drawing.Size(100, 21);
            this.Money1.TabIndex = 23;
            this.Money1.Text = "0";
            this.Money1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tradetext
            // 
            this.tradetext.Enabled = false;
            this.tradetext.Location = new System.Drawing.Point(34, 2);
            this.tradetext.Multiline = true;
            this.tradetext.Name = "tradetext";
            this.tradetext.Size = new System.Drawing.Size(265, 74);
            this.tradetext.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.AS);
            this.panel5.Controls.Add(this.button9);
            this.panel5.Controls.Add(this.barcodeText);
            this.panel5.Location = new System.Drawing.Point(1, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(483, 48);
            this.panel5.TabIndex = 24;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pos.Properties.Resources.iconfinder_warning_22829;
            this.pictureBox3.Location = new System.Drawing.Point(14, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(33, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "상품을 등록해주세요.";
            // 
            // AS
            // 
            this.AS.BackColor = System.Drawing.Color.DodgerBlue;
            this.AS.ForeColor = System.Drawing.Color.White;
            this.AS.Location = new System.Drawing.Point(176, 3);
            this.AS.Name = "AS";
            this.AS.Size = new System.Drawing.Size(105, 43);
            this.AS.TabIndex = 15;
            this.AS.Text = "A/S\r\n연락처";
            this.AS.UseVisualStyleBackColor = false;
            this.AS.Click += new System.EventHandler(this.Button10_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.Location = new System.Drawing.Point(435, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(44, 41);
            this.button9.TabIndex = 14;
            this.button9.Text = "←";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // barcodeText
            // 
            this.barcodeText.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.barcodeText.Location = new System.Drawing.Point(287, 4);
            this.barcodeText.Multiline = true;
            this.barcodeText.Name = "barcodeText";
            this.barcodeText.Size = new System.Drawing.Size(142, 41);
            this.barcodeText.TabIndex = 13;
            this.barcodeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Enter);
            this.panel1.Controls.Add(this.Disposal);
            this.panel1.Controls.Add(this.onecancel);
            this.panel1.Controls.Add(this.allcancel);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Presetkey);
            this.panel1.Controls.Add(this.mainDoun);
            this.panel1.Controls.Add(this.mainUp);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 358);
            this.panel1.TabIndex = 25;
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.Color.Gainsboro;
            this.Enter.ForeColor = System.Drawing.Color.Black;
            this.Enter.Location = new System.Drawing.Point(486, 163);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(76, 41);
            this.Enter.TabIndex = 45;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.EnterBtn);
            // 
            // Disposal
            // 
            this.Disposal.BackColor = System.Drawing.Color.Gainsboro;
            this.Disposal.Location = new System.Drawing.Point(485, 112);
            this.Disposal.Name = "Disposal";
            this.Disposal.Size = new System.Drawing.Size(76, 41);
            this.Disposal.TabIndex = 26;
            this.Disposal.Text = "상품관리";
            this.Disposal.UseVisualStyleBackColor = false;
            this.Disposal.Click += new System.EventHandler(this.Disposal_Click);
            // 
            // onecancel
            // 
            this.onecancel.BackColor = System.Drawing.Color.Gainsboro;
            this.onecancel.Location = new System.Drawing.Point(485, 63);
            this.onecancel.Name = "onecancel";
            this.onecancel.Size = new System.Drawing.Size(76, 41);
            this.onecancel.TabIndex = 25;
            this.onecancel.Text = "지정취소";
            this.onecancel.UseVisualStyleBackColor = false;
            this.onecancel.Click += new System.EventHandler(this.onecancel_Click);
            // 
            // allcancel
            // 
            this.allcancel.BackColor = System.Drawing.Color.Gainsboro;
            this.allcancel.Location = new System.Drawing.Point(485, 13);
            this.allcancel.Name = "allcancel";
            this.allcancel.Size = new System.Drawing.Size(76, 41);
            this.allcancel.TabIndex = 0;
            this.allcancel.Text = "일괄취소";
            this.allcancel.UseVisualStyleBackColor = false;
            this.allcancel.Click += new System.EventHandler(this.allcancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.상품명,
            this.단가,
            this.수량,
            this.할인,
            this.영수액});
            this.dataGridView1.Location = new System.Drawing.Point(0, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(483, 133);
            this.dataGridView1.TabIndex = 21;
            // 
            // Num
            // 
            this.Num.DataPropertyName = "pnum";
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Width = 40;
            // 
            // 상품명
            // 
            this.상품명.DataPropertyName = "pname";
            this.상품명.HeaderText = "상품명";
            this.상품명.Name = "상품명";
            this.상품명.ReadOnly = true;
            this.상품명.Width = 80;
            // 
            // 단가
            // 
            this.단가.DataPropertyName = "price";
            this.단가.HeaderText = "단가";
            this.단가.Name = "단가";
            this.단가.ReadOnly = true;
            this.단가.Width = 80;
            // 
            // 수량
            // 
            this.수량.DataPropertyName = "수량";
            this.수량.HeaderText = "수량";
            this.수량.Name = "수량";
            this.수량.ReadOnly = true;
            this.수량.Width = 80;
            // 
            // 할인
            // 
            this.할인.DataPropertyName = "할인";
            this.할인.HeaderText = "할인";
            this.할인.Name = "할인";
            this.할인.ReadOnly = true;
            this.할인.Width = 80;
            // 
            // 영수액
            // 
            this.영수액.DataPropertyName = "영수액";
            this.영수액.HeaderText = "영수액";
            this.영수액.Name = "영수액";
            this.영수액.ReadOnly = true;
            this.영수액.Width = 80;
            // 
            // Presetkey
            // 
            this.Presetkey.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Presetkey.Controls.Add(this.label1);
            this.Presetkey.ForeColor = System.Drawing.Color.Gainsboro;
            this.Presetkey.Location = new System.Drawing.Point(94, 153);
            this.Presetkey.Name = "Presetkey";
            this.Presetkey.Size = new System.Drawing.Size(84, 33);
            this.Presetkey.TabIndex = 20;
            this.Presetkey.Click += new System.EventHandler(this.Presetkey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRESETKEY";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // mainDoun
            // 
            this.mainDoun.BackColor = System.Drawing.Color.Gainsboro;
            this.mainDoun.Image = global::Pos.Properties.Resources.buttom;
            this.mainDoun.Location = new System.Drawing.Point(48, 152);
            this.mainDoun.Name = "mainDoun";
            this.mainDoun.Size = new System.Drawing.Size(39, 33);
            this.mainDoun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainDoun.TabIndex = 19;
            this.mainDoun.TabStop = false;
            // 
            // mainUp
            // 
            this.mainUp.BackColor = System.Drawing.Color.Gainsboro;
            this.mainUp.Image = global::Pos.Properties.Resources.top;
            this.mainUp.Location = new System.Drawing.Point(5, 152);
            this.mainUp.Name = "mainUp";
            this.mainUp.Size = new System.Drawing.Size(39, 33);
            this.mainUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainUp.TabIndex = 18;
            this.mainUp.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.TotalReceipt);
            this.panel4.Controls.Add(this.TotalDiscount);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.Current);
            this.panel4.Controls.Add(this.tradeJoin);
            this.panel4.Controls.Add(this.ProductJoin);
            this.panel4.Controls.Add(this.TotalAmount);
            this.panel4.Controls.Add(this.cashTrade);
            this.panel4.Controls.Add(this.cardTrade);
            this.panel4.Location = new System.Drawing.Point(-1, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(484, 211);
            this.panel4.TabIndex = 24;
            // 
            // TotalReceipt
            // 
            this.TotalReceipt.Enabled = false;
            this.TotalReceipt.Location = new System.Drawing.Point(389, 16);
            this.TotalReceipt.Name = "TotalReceipt";
            this.TotalReceipt.Size = new System.Drawing.Size(82, 21);
            this.TotalReceipt.TabIndex = 0;
            this.TotalReceipt.Text = "0";
            this.TotalReceipt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalDiscount
            // 
            this.TotalDiscount.Enabled = false;
            this.TotalDiscount.Location = new System.Drawing.Point(339, 16);
            this.TotalDiscount.Name = "TotalDiscount";
            this.TotalDiscount.Size = new System.Drawing.Size(53, 21);
            this.TotalDiscount.TabIndex = 7;
            this.TotalDiscount.Text = "0";
            this.TotalDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "합계\r\n수량/할인/영수액\r\n";
            // 
            // Current
            // 
            this.Current.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Current.Location = new System.Drawing.Point(372, 172);
            this.Current.Name = "Current";
            this.Current.Size = new System.Drawing.Size(75, 33);
            this.Current.TabIndex = 4;
            this.Current.Text = "포스잔고";
            this.Current.UseVisualStyleBackColor = true;
            this.Current.Click += new System.EventHandler(this.Current_Click);
            // 
            // tradeJoin
            // 
            this.tradeJoin.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tradeJoin.Location = new System.Drawing.Point(284, 172);
            this.tradeJoin.Name = "tradeJoin";
            this.tradeJoin.Size = new System.Drawing.Size(75, 33);
            this.tradeJoin.TabIndex = 3;
            this.tradeJoin.Text = "저널조회";
            this.tradeJoin.UseVisualStyleBackColor = true;
            this.tradeJoin.Click += new System.EventHandler(this.tradeJoin_Click_1);
            // 
            // ProductJoin
            // 
            this.ProductJoin.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProductJoin.Location = new System.Drawing.Point(197, 172);
            this.ProductJoin.Name = "ProductJoin";
            this.ProductJoin.Size = new System.Drawing.Size(75, 33);
            this.ProductJoin.TabIndex = 2;
            this.ProductJoin.Text = "상품조회";
            this.ProductJoin.UseVisualStyleBackColor = true;
            this.ProductJoin.Click += new System.EventHandler(this.productJoin_Click);
            // 
            // TotalAmount
            // 
            this.TotalAmount.Enabled = false;
            this.TotalAmount.Location = new System.Drawing.Point(287, 16);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(53, 21);
            this.TotalAmount.TabIndex = 6;
            this.TotalAmount.Text = "0";
            this.TotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cashTrade
            // 
            this.cashTrade.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cashTrade.Location = new System.Drawing.Point(19, 172);
            this.cashTrade.Name = "cashTrade";
            this.cashTrade.Size = new System.Drawing.Size(75, 33);
            this.cashTrade.TabIndex = 0;
            this.cashTrade.Text = "현금결제";
            this.cashTrade.UseVisualStyleBackColor = true;
            this.cashTrade.Click += new System.EventHandler(this.cashTrade_Click_1);
            // 
            // cardTrade
            // 
            this.cardTrade.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cardTrade.Location = new System.Drawing.Point(109, 172);
            this.cardTrade.Name = "cardTrade";
            this.cardTrade.Size = new System.Drawing.Size(75, 33);
            this.cardTrade.TabIndex = 1;
            this.cardTrade.Text = "카드결제";
            this.cardTrade.UseVisualStyleBackColor = true;
            this.cardTrade.Click += new System.EventHandler(this.CardTrade_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 358);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PresetPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Presetkey.ResumeLayout(false);
            this.Presetkey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDoun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainUp)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Money3;
        private System.Windows.Forms.TextBox Money2;
        private System.Windows.Forms.TextBox Money1;
        private System.Windows.Forms.TextBox tradetext;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AS;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox barcodeText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Disposal;
        private System.Windows.Forms.Button onecancel;
        private System.Windows.Forms.Button allcancel;
        private System.Windows.Forms.Panel Presetkey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox mainDoun;
        private System.Windows.Forms.PictureBox mainUp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TotalReceipt;
        private System.Windows.Forms.TextBox TotalDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Current;
        private System.Windows.Forms.Button tradeJoin;
        private System.Windows.Forms.Button ProductJoin;
        private System.Windows.Forms.TextBox TotalAmount;
        private System.Windows.Forms.Button cashTrade;
        private System.Windows.Forms.Button cardTrade;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 단가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 할인;
        private System.Windows.Forms.DataGridViewTextBoxColumn 영수액;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Panel PresetPanel;
        private Button preBtnExit;
        private Button preBtn5;
        private Button preBtn4;
        private Button preBtn3;
        private Button preBtn2;
        private Button preBtn1;
    }
}