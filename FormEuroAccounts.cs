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
    public partial class FormEuroAccounts : Form
    {
        Form mainForm;

        public FormEuroAccounts(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm;
        }

        private void buttonCountEuroTotal_Click(object sender, EventArgs e)
        {
            double account1 = Convert.ToDouble(textBoxEuroAccount1.Text);
            double account2 = Convert.ToDouble(textBoxEuroAccount2.Text);
            double account3 = Convert.ToDouble(textBoxEuroAccount3.Text);

            double totalEuroAmount = account1 + account2 + account3;

            // записываем расчет в текущую форму
            textBoxEuroTotalAmount.Text = totalEuroAmount.ToString();
            // записываем расчет и в главную форму
            TextBox textBoxTotalEuroMainForm = mainForm.Controls.Find("textBoxAmountEuro", true)[0] as TextBox;
            textBoxTotalEuroMainForm.Text = totalEuroAmount.ToString();
        }
    }
}
