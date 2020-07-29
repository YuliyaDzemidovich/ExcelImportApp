using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelImportApp
{
    public partial class Form1 : Form
    {
        ExcelHelper excel = new ExcelHelper();

        public Form1()
        {
            InitializeComponent();
            textBoxAmountUsd.Text = 0.ToString();
            textBoxAmountEuro.Text = 0.ToString();
            textBoxAmountRub.Text = 0.ToString();
        }

        private void buttonImportRatesFromExcelSheet_Click(object sender, EventArgs e)
        {
            DataTable data = excel.getDataFromSheet();
            dataGridView1.DataSource = data; // заполняем табличку dataGridView

            textBoxUsdRate.Text = excel.getDataFromCell("b3:b3").Columns[0].ToString();
            textBoxEurRate.Text = excel.getDataFromCell("b4:b4").Columns[0].ToString();
            textBoxRub100Rate.Text = excel.getDataFromCell("b5:b5").Columns[0].ToString();
        }

        private void buttonCountTotalAmountByn_Click(object sender, EventArgs e)
        {
            buttonImportRatesFromExcelSheet.PerformClick();

            double usdRate = Convert.ToDouble(textBoxUsdRate.Text);
            double euroRate = Convert.ToDouble(textBoxEurRate.Text);
            double rub100Rate = Convert.ToDouble(textBoxRub100Rate.Text);

            double usdAmount = Convert.ToDouble(textBoxAmountUsd.Text);
            double euroAmount = Convert.ToDouble(textBoxAmountEuro.Text);
            double rubAmount = Convert.ToDouble(textBoxAmountRub.Text);

            double totalBynAmount = usdAmount * usdRate + euroAmount * euroRate
                + (rubAmount / 100) * rub100Rate;

            textBoxTotalAmountByn.Text = totalBynAmount.ToString();
        }
    }
}
