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
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonImportRatesFromExcelSheet_Click(object sender, EventArgs e)
        {
            String name = "Лист1"; //название листа в книге эксель для импорта
            /* книга эксель лежит в корне проекта, а
             * исполняемый файл приложения в /bin/Debug/
             * поэтому для получения доступа к книге эксель
             * переходим на два уровня вверх (два раза ..\\
             * два слеша потому, что один выступает в роли экранирующего символа)
             */
            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                            "..\\..\\datasheet.xlsx" +
                            ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

            OleDbConnection connection = new OleDbConnection(constr);
            OleDbCommand command = new OleDbCommand("Select * From [" + name + "$]", connection);
            connection.Open();

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data; // заполняем табличку dataGridView

            // b3:b3 - значение ячейки; b1:b3 - диапазон ячеек
            OleDbCommand command2 = new OleDbCommand("Select * From [" + name + "$b3:b3]", connection);
            OleDbDataAdapter adapter2 = new OleDbDataAdapter(command2);
            DataTable data2 = new DataTable();
            adapter2.Fill(data2);
            textBoxUsdRate.Text = data2.Columns[0].ToString();

            connection.Close();
        }
    }
}
