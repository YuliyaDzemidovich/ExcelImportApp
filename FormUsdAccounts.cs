using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelImportApp
{
    public partial class FormUsdAccounts : Form
    {
        Form mainForm;

        public FormUsdAccounts(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm;
        }

        private void buttonCountUsdTotal_Click(object sender, EventArgs e)
        {
            double account1 = Convert.ToDouble(textBoxUsdAccount1.Text);
            double account2 = Convert.ToDouble(textBoxUsdAccount2.Text);
            double account3 = Convert.ToDouble(textBoxUsdAccount3.Text);

            double totalUsdAmount = account1 + account2 + account3;

            // записываем расчет в текущую форму
            textBoxUsdTotalAmount.Text = totalUsdAmount.ToString();
            // записываем расчет и в главную форму
            TextBox textBoxTotalUsdMainForm = mainForm.Controls.Find("textBoxAmountUsd", true)[0] as TextBox;
            textBoxTotalUsdMainForm.Text = totalUsdAmount.ToString();
        }
    }
}
