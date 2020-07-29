namespace ExcelImportApp
{
    partial class FormUsdAccounts
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCountUsdTotal = new System.Windows.Forms.Button();
            this.textBoxUsdAccount1 = new System.Windows.Forms.TextBox();
            this.textBoxUsdAccount2 = new System.Windows.Forms.TextBox();
            this.textBoxUsdAccount3 = new System.Windows.Forms.TextBox();
            this.textBoxUsdTotalAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(68, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Счет 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(68, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Счет 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(68, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Счет 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(68, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Итого на счетах";
            // 
            // buttonCountUsdTotal
            // 
            this.buttonCountUsdTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCountUsdTotal.Location = new System.Drawing.Point(165, 221);
            this.buttonCountUsdTotal.Name = "buttonCountUsdTotal";
            this.buttonCountUsdTotal.Size = new System.Drawing.Size(128, 44);
            this.buttonCountUsdTotal.TabIndex = 4;
            this.buttonCountUsdTotal.Text = "Посчитать";
            this.buttonCountUsdTotal.UseVisualStyleBackColor = true;
            this.buttonCountUsdTotal.Click += new System.EventHandler(this.buttonCountUsdTotal_Click);
            // 
            // textBoxUsdAccount1
            // 
            this.textBoxUsdAccount1.Location = new System.Drawing.Point(270, 47);
            this.textBoxUsdAccount1.Name = "textBoxUsdAccount1";
            this.textBoxUsdAccount1.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsdAccount1.TabIndex = 5;
            // 
            // textBoxUsdAccount2
            // 
            this.textBoxUsdAccount2.Location = new System.Drawing.Point(270, 79);
            this.textBoxUsdAccount2.Name = "textBoxUsdAccount2";
            this.textBoxUsdAccount2.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsdAccount2.TabIndex = 6;
            // 
            // textBoxUsdAccount3
            // 
            this.textBoxUsdAccount3.Location = new System.Drawing.Point(270, 112);
            this.textBoxUsdAccount3.Name = "textBoxUsdAccount3";
            this.textBoxUsdAccount3.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsdAccount3.TabIndex = 7;
            // 
            // textBoxUsdTotalAmount
            // 
            this.textBoxUsdTotalAmount.Location = new System.Drawing.Point(270, 166);
            this.textBoxUsdTotalAmount.Name = "textBoxUsdTotalAmount";
            this.textBoxUsdTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsdTotalAmount.TabIndex = 8;
            // 
            // FormUsdAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 308);
            this.Controls.Add(this.textBoxUsdTotalAmount);
            this.Controls.Add(this.textBoxUsdAccount3);
            this.Controls.Add(this.textBoxUsdAccount2);
            this.Controls.Add(this.textBoxUsdAccount1);
            this.Controls.Add(this.buttonCountUsdTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUsdAccounts";
            this.Text = "Долларовые счета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCountUsdTotal;
        private System.Windows.Forms.TextBox textBoxUsdAccount1;
        private System.Windows.Forms.TextBox textBoxUsdAccount2;
        private System.Windows.Forms.TextBox textBoxUsdAccount3;
        private System.Windows.Forms.TextBox textBoxUsdTotalAmount;
    }
}