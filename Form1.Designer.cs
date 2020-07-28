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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "MainWin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}

