namespace Pos
{
    partial class Current
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PosMoney = new System.Windows.Forms.TextBox();
            this.updateTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.MiunsBtn = new System.Windows.Forms.Button();
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 358);
            this.panel1.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(203, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 47);
            this.label4.TabIndex = 25;
            this.label4.Text = "포스잔고";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.PosMoney);
            this.panel4.Controls.Add(this.updateTextBox);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.PlusBtn);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.ResultField);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(-1, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(566, 211);
            this.panel4.TabIndex = 24;
            // 
            // PosMoney
            // 
            this.PosMoney.Enabled = false;
            this.PosMoney.Location = new System.Drawing.Point(263, 45);
            this.PosMoney.Name = "PosMoney";
            this.PosMoney.Size = new System.Drawing.Size(91, 21);
            this.PosMoney.TabIndex = 45;
            this.PosMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // updateTextBox
            // 
            this.updateTextBox.Location = new System.Drawing.Point(263, 80);
            this.updateTextBox.Name = "updateTextBox";
            this.updateTextBox.Size = new System.Drawing.Size(91, 21);
            this.updateTextBox.TabIndex = 44;
            this.updateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updateTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UpdateTextBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 43;
            this.label2.Text = "현재고";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 42;
            this.label1.Text = "변경금액";
            // 
            // PlusBtn
            // 
            this.PlusBtn.BackColor = System.Drawing.Color.White;
            this.PlusBtn.Location = new System.Drawing.Point(111, 167);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PlusBtn.Size = new System.Drawing.Size(75, 32);
            this.PlusBtn.TabIndex = 40;
            this.PlusBtn.Text = "예금";
            this.PlusBtn.UseVisualStyleBackColor = false;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 34;
            this.label3.Text = "수정후금액";
            // 
            // ResultField
            // 
            this.ResultField.Enabled = false;
            this.ResultField.Location = new System.Drawing.Point(263, 116);
            this.ResultField.Name = "ResultField";
            this.ResultField.Size = new System.Drawing.Size(91, 21);
            this.ResultField.TabIndex = 33;
            this.ResultField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.EnterBtn);
            this.panel2.Controls.Add(this.MiunsBtn);
            this.panel2.Controls.Add(this.ModifyBtn);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 211);
            this.panel2.TabIndex = 46;
            // 
            // EnterBtn
            // 
            this.EnterBtn.BackColor = System.Drawing.Color.White;
            this.EnterBtn.Location = new System.Drawing.Point(376, 167);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(75, 32);
            this.EnterBtn.TabIndex = 42;
            this.EnterBtn.Text = "확정";
            this.EnterBtn.UseVisualStyleBackColor = false;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // MiunsBtn
            // 
            this.MiunsBtn.BackColor = System.Drawing.Color.White;
            this.MiunsBtn.Location = new System.Drawing.Point(200, 167);
            this.MiunsBtn.Name = "MiunsBtn";
            this.MiunsBtn.Size = new System.Drawing.Size(75, 32);
            this.MiunsBtn.TabIndex = 36;
            this.MiunsBtn.Text = "출금";
            this.MiunsBtn.UseVisualStyleBackColor = false;
            this.MiunsBtn.Click += new System.EventHandler(this.MiunsBtn_Click);
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.BackColor = System.Drawing.Color.White;
            this.ModifyBtn.Location = new System.Drawing.Point(289, 167);
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.Size = new System.Drawing.Size(75, 32);
            this.ModifyBtn.TabIndex = 41;
            this.ModifyBtn.Text = "수정하기";
            this.ModifyBtn.UseVisualStyleBackColor = false;
            this.ModifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // Current
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 358);
            this.Controls.Add(this.panel1);
            this.Name = "Current";
            this.Text = "Current";
            this.Load += new System.EventHandler(this.Current_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button MiunsBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ModifyBtn;
        private System.Windows.Forms.TextBox PosMoney;
        private System.Windows.Forms.TextBox updateTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EnterBtn;
    }
}