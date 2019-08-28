namespace Pos
{
    partial class Receipt
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ReceiptCard = new System.Windows.Forms.Label();
            this.ReceiptCh = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.Content = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ReceiptTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tradeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.거래일자 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래시간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.금액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.times = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 357);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.ReceiptCard);
            this.panel3.Controls.Add(this.ReceiptCh);
            this.panel3.Controls.Add(this.SumLabel);
            this.panel3.Controls.Add(this.Content);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.ReceiptTime);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tradeLabel);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(312, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 342);
            this.panel3.TabIndex = 1;
            // 
            // ReceiptCard
            // 
            this.ReceiptCard.AutoSize = true;
            this.ReceiptCard.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ReceiptCard.Location = new System.Drawing.Point(36, 265);
            this.ReceiptCard.Name = "ReceiptCard";
            this.ReceiptCard.Size = new System.Drawing.Size(0, 25);
            this.ReceiptCard.TabIndex = 11;
            this.ReceiptCard.Visible = false;
            // 
            // ReceiptCh
            // 
            this.ReceiptCh.AutoSize = true;
            this.ReceiptCh.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ReceiptCh.Location = new System.Drawing.Point(79, 245);
            this.ReceiptCh.Name = "ReceiptCh";
            this.ReceiptCh.Size = new System.Drawing.Size(0, 25);
            this.ReceiptCh.TabIndex = 10;
            this.ReceiptCh.Visible = false;
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SumLabel.Location = new System.Drawing.Point(79, 223);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(0, 30);
            this.SumLabel.TabIndex = 9;
            this.SumLabel.Visible = false;
            // 
            // Content
            // 
            this.Content.AutoSize = true;
            this.Content.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Content.Location = new System.Drawing.Point(36, 193);
            this.Content.Name = "Content";
            this.Content.Padding = new System.Windows.Forms.Padding(4);
            this.Content.Size = new System.Drawing.Size(8, 23);
            this.Content.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 36);
            this.label8.TabIndex = 5;
            this.label8.Text = "--------------------------------\r\n상품명             수량             금액\r\n------------" +
    "--------------------";
            // 
            // ReceiptTime
            // 
            this.ReceiptTime.AutoSize = true;
            this.ReceiptTime.Location = new System.Drawing.Point(79, 118);
            this.ReceiptTime.Name = "ReceiptTime";
            this.ReceiptTime.Size = new System.Drawing.Size(0, 12);
            this.ReceiptTime.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "[ 판매 ]";
            // 
            // tradeLabel
            // 
            this.tradeLabel.AutoSize = true;
            this.tradeLabel.Location = new System.Drawing.Point(25, 85);
            this.tradeLabel.Name = "tradeLabel";
            this.tradeLabel.Size = new System.Drawing.Size(29, 12);
            this.tradeLabel.TabIndex = 2;
            this.tradeLabel.Text = "현금";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "사업자명 : OOO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "점명 : 부평OOO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(1, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 342);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.거래일자,
            this.거래번호,
            this.거래시간,
            this.금액});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(312, 283);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Click += new System.EventHandler(this.DataGridView1_Click);
            // 
            // 거래일자
            // 
            this.거래일자.DataPropertyName = "days";
            this.거래일자.HeaderText = "거래일자";
            this.거래일자.Name = "거래일자";
            this.거래일자.ReadOnly = true;
            // 
            // 거래번호
            // 
            this.거래번호.DataPropertyName = "tnum";
            this.거래번호.HeaderText = "거래번호";
            this.거래번호.Name = "거래번호";
            this.거래번호.ReadOnly = true;
            // 
            // 거래시간
            // 
            this.거래시간.DataPropertyName = "times";
            this.거래시간.HeaderText = "거래시간";
            this.거래시간.Name = "거래시간";
            this.거래시간.ReadOnly = true;
            // 
            // 금액
            // 
            this.금액.DataPropertyName = "Price";
            this.금액.HeaderText = "금액";
            this.금액.Name = "금액";
            this.금액.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "저널조회";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tnum,
            this.times,
            this.productText,
            this.totalprice,
            this.cash,
            this.card});
            this.dataGridView2.Location = new System.Drawing.Point(40, 127);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 12;
            // 
            // tnum
            // 
            this.tnum.DataPropertyName = "tnum";
            this.tnum.HeaderText = "tnum";
            this.tnum.Name = "tnum";
            // 
            // times
            // 
            this.times.DataPropertyName = "times";
            this.times.HeaderText = "times";
            this.times.Name = "times";
            // 
            // productText
            // 
            this.productText.DataPropertyName = "productText";
            this.productText.HeaderText = "productText";
            this.productText.Name = "productText";
            // 
            // totalprice
            // 
            this.totalprice.DataPropertyName = "totalprice";
            this.totalprice.HeaderText = "totalprice";
            this.totalprice.Name = "totalprice";
            // 
            // cash
            // 
            this.cash.DataPropertyName = "cash";
            this.cash.HeaderText = "cash";
            this.cash.Name = "cash";
            // 
            // card
            // 
            this.card.DataPropertyName = "card";
            this.card.HeaderText = "card";
            this.card.Name = "card";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 358);
            this.Controls.Add(this.panel1);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ReceiptCh;
        private System.Windows.Forms.Label Content;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ReceiptTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tradeLabel;
        private System.Windows.Forms.Label ReceiptCard;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래일자;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래시간;
        private System.Windows.Forms.DataGridViewTextBoxColumn 금액;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn times;
        private System.Windows.Forms.DataGridViewTextBoxColumn productText;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cash;
        private System.Windows.Forms.DataGridViewTextBoxColumn card;
        private System.Windows.Forms.Label SumLabel;
    }
}