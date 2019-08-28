namespace Pos
{
    partial class productUpdate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.바코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상품명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.단가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnePlus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TwoPlus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.Event = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.priceField = new System.Windows.Forms.TextBox();
            this.twoPlus_one = new System.Windows.Forms.Button();
            this.onePlus_one = new System.Windows.Forms.Button();
            this.none = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.amountField = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.barcodeText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 358);
            this.panel1.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.바코드,
            this.Num,
            this.상품명,
            this.단가,
            this.OnePlus,
            this.TwoPlus,
            this.수량});
            this.dataGridView1.Location = new System.Drawing.Point(0, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(565, 133);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // 바코드
            // 
            this.바코드.DataPropertyName = "barcode";
            this.바코드.HeaderText = "바코드";
            this.바코드.Name = "바코드";
            this.바코드.ReadOnly = true;
            // 
            // Num
            // 
            this.Num.DataPropertyName = "pnum";
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // 상품명
            // 
            this.상품명.DataPropertyName = "pname";
            this.상품명.HeaderText = "상품명";
            this.상품명.Name = "상품명";
            this.상품명.ReadOnly = true;
            // 
            // 단가
            // 
            this.단가.DataPropertyName = "price";
            this.단가.HeaderText = "단가";
            this.단가.Name = "단가";
            this.단가.ReadOnly = true;
            // 
            // OnePlus
            // 
            this.OnePlus.DataPropertyName = "event11";
            this.OnePlus.HeaderText = "OnePlus";
            this.OnePlus.Name = "OnePlus";
            this.OnePlus.ReadOnly = true;
            // 
            // TwoPlus
            // 
            this.TwoPlus.DataPropertyName = "event22";
            this.TwoPlus.HeaderText = "TwoPlus";
            this.TwoPlus.Name = "TwoPlus";
            this.TwoPlus.ReadOnly = true;
            // 
            // 수량
            // 
            this.수량.DataPropertyName = "수량";
            this.수량.HeaderText = "수량";
            this.수량.Name = "수량";
            this.수량.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.InsertBtn);
            this.panel4.Controls.Add(this.DeleteBtn);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.UpdateBtn);
            this.panel4.Controls.Add(this.Event);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.nameField);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.priceField);
            this.panel4.Controls.Add(this.twoPlus_one);
            this.panel4.Controls.Add(this.onePlus_one);
            this.panel4.Controls.Add(this.none);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.amountField);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(-1, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(566, 211);
            this.panel4.TabIndex = 24;
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.Aquamarine;
            this.InsertBtn.Location = new System.Drawing.Point(139, 171);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InsertBtn.Size = new System.Drawing.Size(75, 32);
            this.InsertBtn.TabIndex = 40;
            this.InsertBtn.Text = "추가하기";
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Aquamarine;
            this.DeleteBtn.Location = new System.Drawing.Point(360, 171);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 32);
            this.DeleteBtn.TabIndex = 39;
            this.DeleteBtn.Text = "삭제하기";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(486, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(73, 164);
            this.panel3.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(1, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(73, 164);
            this.panel2.TabIndex = 37;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Aquamarine;
            this.UpdateBtn.Location = new System.Drawing.Point(248, 171);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 32);
            this.UpdateBtn.TabIndex = 36;
            this.UpdateBtn.Text = "변경하기";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // Event
            // 
            this.Event.AutoSize = true;
            this.Event.Location = new System.Drawing.Point(265, 110);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(41, 12);
            this.Event.TabIndex = 35;
            this.Event.Text = "이벤트";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 34;
            this.label3.Text = "상품명";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(123, 79);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(91, 21);
            this.nameField.TabIndex = 33;
            this.nameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 32;
            this.label1.Text = "가격";
            // 
            // priceField
            // 
            this.priceField.Location = new System.Drawing.Point(241, 79);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(91, 21);
            this.priceField.TabIndex = 31;
            this.priceField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // twoPlus_one
            // 
            this.twoPlus_one.BackColor = System.Drawing.Color.White;
            this.twoPlus_one.Location = new System.Drawing.Point(360, 132);
            this.twoPlus_one.Name = "twoPlus_one";
            this.twoPlus_one.Size = new System.Drawing.Size(75, 23);
            this.twoPlus_one.TabIndex = 30;
            this.twoPlus_one.Text = "2+1";
            this.twoPlus_one.UseVisualStyleBackColor = false;
            this.twoPlus_one.Click += new System.EventHandler(this.TwoPlus_one_Click);
            // 
            // onePlus_one
            // 
            this.onePlus_one.BackColor = System.Drawing.Color.White;
            this.onePlus_one.Location = new System.Drawing.Point(248, 132);
            this.onePlus_one.Name = "onePlus_one";
            this.onePlus_one.Size = new System.Drawing.Size(75, 23);
            this.onePlus_one.TabIndex = 29;
            this.onePlus_one.Text = "1+1";
            this.onePlus_one.UseVisualStyleBackColor = false;
            this.onePlus_one.Click += new System.EventHandler(this.OnePlus_one_Click);
            // 
            // none
            // 
            this.none.BackColor = System.Drawing.Color.White;
            this.none.Location = new System.Drawing.Point(138, 132);
            this.none.Name = "none";
            this.none.Size = new System.Drawing.Size(75, 23);
            this.none.TabIndex = 28;
            this.none.Text = "None";
            this.none.UseVisualStyleBackColor = false;
            this.none.Click += new System.EventHandler(this.None_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "수량";
            // 
            // amountField
            // 
            this.amountField.Location = new System.Drawing.Point(359, 79);
            this.amountField.Name = "amountField";
            this.amountField.Size = new System.Drawing.Size(91, 21);
            this.amountField.TabIndex = 26;
            this.amountField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.EnterBtn);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.BackBtn);
            this.panel5.Controls.Add(this.barcodeText);
            this.panel5.Location = new System.Drawing.Point(1, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(565, 48);
            this.panel5.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "변경할 상품의 \r\n바코드를 입력해주세요.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(485, 4);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(75, 41);
            this.EnterBtn.TabIndex = 18;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pos.Properties.Resources.iconfinder_warning_22829;
            this.pictureBox3.Location = new System.Drawing.Point(81, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BackBtn.Location = new System.Drawing.Point(435, 4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(44, 41);
            this.BackBtn.TabIndex = 14;
            this.BackBtn.Text = "←";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // barcodeText
            // 
            this.barcodeText.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.barcodeText.Location = new System.Drawing.Point(287, 3);
            this.barcodeText.Multiline = true;
            this.barcodeText.Name = "barcodeText";
            this.barcodeText.Size = new System.Drawing.Size(142, 41);
            this.barcodeText.TabIndex = 13;
            this.barcodeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // productUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 359);
            this.Controls.Add(this.panel1);
            this.Name = "productUpdate";
            this.Text = "productUpdate";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox barcodeText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amountField;
        private System.Windows.Forms.Button twoPlus_one;
        private System.Windows.Forms.Button onePlus_one;
        private System.Windows.Forms.Button none;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label Event;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn 바코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 단가;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnePlus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TwoPlus;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수량;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button InsertBtn;
    }
}