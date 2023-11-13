using KuisPertemuan14.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuisPertemuan14.Controller
{
    internal class Admi:Model.Conecction
    {
        Conecction koneksi = new Conecction();
        public DataTable getlist(MySqlCommand command)
        {
            command.Connection = koneksi.GetConn();
            DataTable table=new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
    }
}
