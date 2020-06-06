﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace 农产品物流管理系统
{
    public partial class Form1 : Form
    {
        static String connetStr = "server=127.0.0.1;port=3306;user=root;password=zc000910; database=cls;";
        MySqlConnection conn = new MySqlConnection(connetStr);
        public Form1()
        {
            InitializeComponent();
            try
            {
                conn.Open();
                label4.Text = "连接成功！";

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
          
        }


        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Size=new Size(275,330);//227,275
            pictureBox1.Location = new Point(71, 48);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(227, 275);//227,275
            pictureBox1.Location = new Point(95, 75);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(275, 330);//227,275
            pictureBox2.Location = new Point(477, 48);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(227, 275);//227,275
            pictureBox2.Location = new Point(501, 75);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form2(conn).ShowDialog();
        }
    }
}