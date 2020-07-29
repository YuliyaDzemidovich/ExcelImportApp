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
        }

        private void buttonImportRatesFromExcelSheet_Click(object sender, EventArgs e)
        {
            DataTable data = excel.getDataFromSheet();
            dataGridView1.DataSource = data; // заполняем табличку dataGridView

            //DataTable data2 = excel.getDataFromCell("b3:b3");
            //textBoxUsdRate.Text = data2.Columns[0].ToString();

            textBoxUsdRate.Text = excel.getDataFromCell("b3:b3").Columns[0].ToString();
            textBoxEurRate.Text = excel.getDataFromCell("b4:b4").Columns[0].ToString();
            textBoxRub100Rate.Text = excel.getDataFromCell("b5:b5").Columns[0].ToString();
        }
    }
}
