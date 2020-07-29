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
    public partial class FormRubAccounts : Form
    {
        Form mainForm;

        public FormRubAccounts(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm;
        }

        private void buttonCountRubTotal_Click(object sender, EventArgs e)
        {
            double account1 = Convert.ToDouble(textBoxRubAccount1.Text);
            double account2 = Convert.ToDouble(textBoxRubAccount2.Text);
            double account3 = Convert.ToDouble(textBoxRubAccount3.Text);

            double totalRubAmount = account1 + account2 + account3;

            // записываем расчет в текущую форму
            textBoxRubTotalAmount.Text = totalRubAmount.ToString();
            // записываем расчет и в главную форму
            TextBox textBoxTotalRubMainForm = mainForm.Controls.Find("textBoxAmountRub", true)[0] as TextBox;
            textBoxTotalRubMainForm.Text = totalRubAmount.ToString();
        }
    }
}
