﻿namespace ExcelImportApp
{
    partial class FormEuroAccounts
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
            this.buttonCountEuroTotal = new System.Windows.Forms.Button();
            this.textBoxEuroAccount1 = new System.Windows.Forms.TextBox();
            this.textBoxEuroAccount2 = new System.Windows.Forms.TextBox();
            this.textBoxEuroAccount3 = new System.Windows.Forms.TextBox();
            this.textBoxEuroTotalAmount = new System.Windows.Forms.TextBox();
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
            // buttonCountEuroTotal
            // 
            this.buttonCountEuroTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCountEuroTotal.Location = new System.Drawing.Point(165, 221);
            this.buttonCountEuroTotal.Name = "buttonCountEuroTotal";
            this.buttonCountEuroTotal.Size = new System.Drawing.Size(128, 44);
            this.buttonCountEuroTotal.TabIndex = 4;
            this.buttonCountEuroTotal.Text = "Посчитать";
            this.buttonCountEuroTotal.UseVisualStyleBackColor = true;
            this.buttonCountEuroTotal.Click += new System.EventHandler(this.buttonCountEuroTotal_Click);
            // 
            // textBoxEuroAccount1
            // 
            this.textBoxEuroAccount1.Location = new System.Drawing.Point(270, 47);
            this.textBoxEuroAccount1.Name = "textBoxEuroAccount1";
            this.textBoxEuroAccount1.Size = new System.Drawing.Size(100, 20);
            this.textBoxEuroAccount1.TabIndex = 5;
            // 
            // textBoxEuroAccount2
            // 
            this.textBoxEuroAccount2.Location = new System.Drawing.Point(270, 79);
            this.textBoxEuroAccount2.Name = "textBoxEuroAccount2";
            this.textBoxEuroAccount2.Size = new System.Drawing.Size(100, 20);
            this.textBoxEuroAccount2.TabIndex = 6;
            // 
            // textBoxEuroAccount3
            // 
            this.textBoxEuroAccount3.Location = new System.Drawing.Point(270, 112);
            this.textBoxEuroAccount3.Name = "textBoxEuroAccount3";
            this.textBoxEuroAccount3.Size = new System.Drawing.Size(100, 20);
            this.textBoxEuroAccount3.TabIndex = 7;
            // 
            // textBoxEuroTotalAmount
            // 
            this.textBoxEuroTotalAmount.Location = new System.Drawing.Point(270, 166);
            this.textBoxEuroTotalAmount.Name = "textBoxEuroTotalAmount";
            this.textBoxEuroTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxEuroTotalAmount.TabIndex = 8;
            // 
            // FormEuroAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 308);
            this.Controls.Add(this.textBoxEuroTotalAmount);
            this.Controls.Add(this.textBoxEuroAccount3);
            this.Controls.Add(this.textBoxEuroAccount2);
            this.Controls.Add(this.textBoxEuroAccount1);
            this.Controls.Add(this.buttonCountEuroTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEuroAccounts";
            this.Text = "Евровые счета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCountEuroTotal;
        private System.Windows.Forms.TextBox textBoxEuroAccount1;
        private System.Windows.Forms.TextBox textBoxEuroAccount2;
        private System.Windows.Forms.TextBox textBoxEuroAccount3;
        private System.Windows.Forms.TextBox textBoxEuroTotalAmount;
    }
}