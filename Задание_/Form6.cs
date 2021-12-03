using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Задание_
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            MySqlConnection connect = new MySqlConnection(conn.stringconnection);
            string dateitimeStud = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string fioStud = textBox1.Text;
            string dateitimeStudFinal = textBox2.Text == "" ? dateitimeStud : textBox2.Text;
            string sql = $"INSERT INTO t_PraktStud (fioStud, datetimeStud) VALUES ('{fioStud}','{dateitimeStudFinal}');";
            int counter = 0;
            try
            {
                connect.Open();
                MySqlCommand command1 = new MySqlCommand(sql, connect);
                counter = command1.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }
            finally
            {
                connect.Close();
                if (counter != 0)
                {
                    MessageBox.Show("Данные добавлены");
                }
            }
        }
    }
}