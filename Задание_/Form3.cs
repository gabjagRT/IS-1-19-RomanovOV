﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public class Connection
        {
            public MySqlConnection Connect()
            {
                string connStr = "server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass;";
                conn = new MySqlConnection(connStr);
                return conn;
            }
            MySqlConnection conn;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();

            try
            {
                connection.Connect().Open();
            }
            catch
            {
                MessageBox.Show($"Соединение прервано");
            }
            finally
            {
                MessageBox.Show("Соединение установлено");
                connection.Connect().Close();
            }
        }
    }

 
}