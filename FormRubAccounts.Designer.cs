namespace ExcelImportApp
{
    partial class FormRubAccounts
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
            this.buttonCountRubTotal = new System.Windows.Forms.Button();
            this.textBoxRubAccount1 = new System.Windows.Forms.TextBox();
            this.textBoxRubAccount2 = new System.Windows.Forms.TextBox();
            this.textBoxRubAccount3 = new System.Windows.Forms.TextBox();
            this.textBoxRubTotalAmount = new System.Windows.Forms.TextBox();
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
            // buttonCountRubTotal
            // 
            this.buttonCountRubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCountRubTotal.Location = new System.Drawing.Point(165, 221);
            this.buttonCountRubTotal.Name = "buttonCountRubTotal";
            this.buttonCountRubTotal.Size = new System.Drawing.Size(128, 44);
            this.buttonCountRubTotal.TabIndex = 4;
            this.buttonCountRubTotal.Text = "Посчитать";
            this.buttonCountRubTotal.UseVisualStyleBackColor = true;
            this.buttonCountRubTotal.Click += new System.EventHandler(this.buttonCountRubTotal_Click);
            // 
            // textBoxRubAccount1
            // 
            this.textBoxRubAccount1.Location = new System.Drawing.Point(270, 47);
            this.textBoxRubAccount1.Name = "textBoxRubAccount1";
            this.textBoxRubAccount1.Size = new System.Drawing.Size(100, 20);
            this.textBoxRubAccount1.TabIndex = 5;
            // 
            // textBoxRubAccount2
            // 
            this.textBoxRubAccount2.Location = new System.Drawing.Point(270, 79);
            this.textBoxRubAccount2.Name = "textBoxRubAccount2";
            this.textBoxRubAccount2.Size = new System.Drawing.Size(100, 20);
            this.textBoxRubAccount2.TabIndex = 6;
            // 
            // textBoxRubAccount3
            // 
            this.textBoxRubAccount3.Location = new System.Drawing.Point(270, 112);
            this.textBoxRubAccount3.Name = "textBoxRubAccount3";
            this.textBoxRubAccount3.Size = new System.Drawing.Size(100, 20);
            this.textBoxRubAccount3.TabIndex = 7;
            // 
            // textBoxRubTotalAmount
            // 
            this.textBoxRubTotalAmount.Location = new System.Drawing.Point(270, 166);
            this.textBoxRubTotalAmount.Name = "textBoxRubTotalAmount";
            this.textBoxRubTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxRubTotalAmount.TabIndex = 8;
            // 
            // FormRubAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 308);
            this.Controls.Add(this.textBoxRubTotalAmount);
            this.Controls.Add(this.textBoxRubAccount3);
            this.Controls.Add(this.textBoxRubAccount2);
            this.Controls.Add(this.textBoxRubAccount1);
            this.Controls.Add(this.buttonCountRubTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRubAccounts";
            this.Text = "Счета в рос. рублях";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCountRubTotal;
        private System.Windows.Forms.TextBox textBoxRubAccount1;
        private System.Windows.Forms.TextBox textBoxRubAccount2;
        private System.Windows.Forms.TextBox textBoxRubAccount3;
        private System.Windows.Forms.TextBox textBoxRubTotalAmount;
    }
}