namespace ExcelImportApp
{
    partial class Form1
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
            this.buttonImportRatesFromExcelSheet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUsdRate = new System.Windows.Forms.TextBox();
            this.textBoxEurRate = new System.Windows.Forms.TextBox();
            this.textBoxRub100Rate = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTotalAmountByn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxAmountUsd = new System.Windows.Forms.TextBox();
            this.textBoxAmountEuro = new System.Windows.Forms.TextBox();
            this.textBoxAmountRub = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonCountTotalAmountByn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Курсы валют";
            // 
            // buttonImportRatesFromExcelSheet
            // 
            this.buttonImportRatesFromExcelSheet.Location = new System.Drawing.Point(192, 12);
            this.buttonImportRatesFromExcelSheet.Name = "buttonImportRatesFromExcelSheet";
            this.buttonImportRatesFromExcelSheet.Size = new System.Drawing.Size(160, 24);
            this.buttonImportRatesFromExcelSheet.TabIndex = 1;
            this.buttonImportRatesFromExcelSheet.Text = "импортировать с экселя";
            this.buttonImportRatesFromExcelSheet.UseVisualStyleBackColor = true;
            this.buttonImportRatesFromExcelSheet.Click += new System.EventHandler(this.buttonImportRatesFromExcelSheet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "USD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(189, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "EUR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(348, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "RUB * 100";
            // 
            // textBoxUsdRate
            // 
            this.textBoxUsdRate.Location = new System.Drawing.Point(24, 91);
            this.textBoxUsdRate.Name = "textBoxUsdRate";
            this.textBoxUsdRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsdRate.TabIndex = 5;
            // 
            // textBoxEurRate
            // 
            this.textBoxEurRate.Location = new System.Drawing.Point(192, 91);
            this.textBoxEurRate.Name = "textBoxEurRate";
            this.textBoxEurRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxEurRate.TabIndex = 6;
            // 
            // textBoxRub100Rate
            // 
            this.textBoxRub100Rate.Location = new System.Drawing.Point(351, 91);
            this.textBoxRub100Rate.Name = "textBoxRub100Rate";
            this.textBoxRub100Rate.Size = new System.Drawing.Size(100, 20);
            this.textBoxRub100Rate.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxRub100Rate);
            this.panel1.Controls.Add(this.buttonImportRatesFromExcelSheet);
            this.panel1.Controls.Add(this.textBoxEurRate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxUsdRate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 129);
            this.panel1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 201);
            this.dataGridView1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 277);
            this.panel2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(21, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Импорт целого листа (тест)";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonCountTotalAmountByn);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textBoxAmountRub);
            this.panel3.Controls.Add(this.textBoxAmountEuro);
            this.panel3.Controls.Add(this.textBoxAmountUsd);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBoxTotalAmountByn);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(526, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 425);
            this.panel3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(23, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Посчитаем сколько у нас денег";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(98, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "ИТОГО:";
            // 
            // textBoxTotalAmountByn
            // 
            this.textBoxTotalAmountByn.Location = new System.Drawing.Point(186, 279);
            this.textBoxTotalAmountByn.Name = "textBoxTotalAmountByn";
            this.textBoxTotalAmountByn.ReadOnly = true;
            this.textBoxTotalAmountByn.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalAmountByn.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(304, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "бел.рублей";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Долларовые счета";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Евровые счета";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 29);
            this.button3.TabIndex = 8;
            this.button3.Text = "Счета в рос.рублях";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBoxAmountUsd
            // 
            this.textBoxAmountUsd.Location = new System.Drawing.Point(186, 60);
            this.textBoxAmountUsd.Name = "textBoxAmountUsd";
            this.textBoxAmountUsd.ReadOnly = true;
            this.textBoxAmountUsd.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmountUsd.TabIndex = 9;
            // 
            // textBoxAmountEuro
            // 
            this.textBoxAmountEuro.Location = new System.Drawing.Point(186, 107);
            this.textBoxAmountEuro.Name = "textBoxAmountEuro";
            this.textBoxAmountEuro.ReadOnly = true;
            this.textBoxAmountEuro.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmountEuro.TabIndex = 10;
            // 
            // textBoxAmountRub
            // 
            this.textBoxAmountRub.Location = new System.Drawing.Point(186, 152);
            this.textBoxAmountRub.Name = "textBoxAmountRub";
            this.textBoxAmountRub.ReadOnly = true;
            this.textBoxAmountRub.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmountRub.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(304, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "долларов";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(304, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "евро";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(304, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "рос.рублей";
            // 
            // buttonCountTotalAmountByn
            // 
            this.buttonCountTotalAmountByn.Location = new System.Drawing.Point(186, 334);
            this.buttonCountTotalAmountByn.Name = "buttonCountTotalAmountByn";
            this.buttonCountTotalAmountByn.Size = new System.Drawing.Size(100, 38);
            this.buttonCountTotalAmountByn.TabIndex = 15;
            this.buttonCountTotalAmountByn.Text = "РАССЧИТАТЬ";
            this.buttonCountTotalAmountByn.UseVisualStyleBackColor = true;
            this.buttonCountTotalAmountByn.Click += new System.EventHandler(this.buttonCountTotalAmountByn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 448);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "MainWin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonImportRatesFromExcelSheet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUsdRate;
        private System.Windows.Forms.TextBox textBoxEurRate;
        private System.Windows.Forms.TextBox textBoxRub100Rate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTotalAmountByn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAmountRub;
        private System.Windows.Forms.TextBox textBoxAmountEuro;
        private System.Windows.Forms.TextBox textBoxAmountUsd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCountTotalAmountByn;
    }
}

