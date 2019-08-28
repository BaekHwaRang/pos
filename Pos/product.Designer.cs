namespace Pos
{
    partial class product
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
            this.label1 = new System.Windows.Forms.Label();
            this.barcodeText = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.바코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상품번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상품이름 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.가격 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.barcodeText);
            this.panel1.Controls.Add(this.Enter);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 358);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(220, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 48;
            this.label1.Text = "상품조회";
            // 
            // barcodeText
            // 
            this.barcodeText.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.barcodeText.Location = new System.Drawing.Point(120, 52);
            this.barcodeText.Multiline = true;
            this.barcodeText.Name = "barcodeText";
            this.barcodeText.Size = new System.Drawing.Size(262, 32);
            this.barcodeText.TabIndex = 47;
            this.barcodeText.TabStop = false;
            this.barcodeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.Color.Gainsboro;
            this.Enter.ForeColor = System.Drawing.Color.Black;
            this.Enter.Location = new System.Drawing.Point(399, 52);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(76, 32);
            this.Enter.TabIndex = 45;
            this.Enter.Text = "검색";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(65, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 255);
            this.panel2.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.바코드,
            this.상품번호,
            this.상품이름,
            this.가격,
            this.event11,
            this.event22,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(449, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // 바코드
            // 
            this.바코드.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.바코드.DataPropertyName = "barcode";
            this.바코드.Frozen = true;
            this.바코드.HeaderText = "바코드";
            this.바코드.Name = "바코드";
            this.바코드.ReadOnly = true;
            this.바코드.Width = 66;
            // 
            // 상품번호
            // 
            this.상품번호.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.상품번호.DataPropertyName = "pnum";
            this.상품번호.Frozen = true;
            this.상품번호.HeaderText = "상품번호";
            this.상품번호.Name = "상품번호";
            this.상품번호.ReadOnly = true;
            this.상품번호.Width = 78;
            // 
            // 상품이름
            // 
            this.상품이름.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.상품이름.DataPropertyName = "pname";
            this.상품이름.Frozen = true;
            this.상품이름.HeaderText = "상품이름";
            this.상품이름.Name = "상품이름";
            this.상품이름.ReadOnly = true;
            this.상품이름.Width = 78;
            // 
            // 가격
            // 
            this.가격.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.가격.DataPropertyName = "price";
            this.가격.HeaderText = "가격";
            this.가격.Name = "가격";
            this.가격.ReadOnly = true;
            this.가격.Width = 54;
            // 
            // event11
            // 
            this.event11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.event11.DataPropertyName = "event11";
            this.event11.HeaderText = "1+1";
            this.event11.Name = "event11";
            this.event11.ReadOnly = true;
            this.event11.Width = 48;
            // 
            // event22
            // 
            this.event22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.event22.DataPropertyName = "event22";
            this.event22.HeaderText = "2+1";
            this.event22.Name = "event22";
            this.event22.ReadOnly = true;
            this.event22.Width = 48;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.DataPropertyName = "amount";
            this.Column7.HeaderText = "현재고";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 66;
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 357);
            this.Controls.Add(this.panel1);
            this.Name = "product";
            this.Text = "product";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barcodeText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 바코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품이름;
        private System.Windows.Forms.DataGridViewTextBoxColumn 가격;
        private System.Windows.Forms.DataGridViewTextBoxColumn event11;
        private System.Windows.Forms.DataGridViewTextBoxColumn event22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}