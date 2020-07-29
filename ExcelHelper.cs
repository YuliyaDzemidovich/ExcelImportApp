using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelImportApp
{
    class ExcelHelper
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
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter adapter;

        public DataTable getDataFromCell(String cell)
        {
            connection = new OleDbConnection(constr);
            command = new OleDbCommand("Select * From [" + name + "$" + cell + "]", connection);
            connection.Open();
            adapter = new OleDbDataAdapter(command);
            DataTable oneCellData = new DataTable();
            adapter.Fill(oneCellData);
            connection.Close();
            return oneCellData;
        }

        public DataTable getDataFromSheet()
        {
            connection = new OleDbConnection(constr);
            connection.Open();
            command = new OleDbCommand("Select * From [" + name + "$]", connection);
            adapter = new OleDbDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }
    }
}
