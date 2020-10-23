using MySql.Data.MySqlClient;
using SimpleMySQLViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class Form1 : Form
    {

        SQLConnection connect;
        string serverString;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tableName;
            this.textBox1.Text += "Bringing in the data...";
            textBox1.AppendText(Environment.NewLine);
            try
            {
                tableName = textBox6.Text;
                dataGridView1.DataSource = connect.ShowDataInGridView("Select * From " + tableName, serverString); 
                this.textBox1.Text += "Data gathered successfully!";
                textBox1.AppendText(Environment.NewLine);
            } catch (Exception x)
            {
                this.textBox1.Text += "Failed to gather data. Check the console for stacktrace.";
                textBox1.AppendText(Environment.NewLine);
                Console.WriteLine(x.StackTrace);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            textBox1.AppendText("Closing Connection...");
            textBox1.AppendText(Environment.NewLine);
            try
            {
                connect.closeConnection();
                this.textBox1.Text += "Connection successfully closed.";
                textBox1.AppendText(Environment.NewLine);
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                serverString = "";
                dataGridView1.DataSource = null;
                
                dataGridView1.Refresh();
            } catch (Exception x)
            {
                this.textBox1.Text += "Failed to close connection. Check the console for stacktrace.";
                Console.WriteLine(x.StackTrace);
                textBox1.AppendText(Environment.NewLine);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serverString = "server = " + textBox4.Text + "; uid=" + textBox2.Text + "; pwd=" + textBox3.Text + "; database=" + textBox5.Text + "";
            Console.WriteLine("Attempting to connect...");
            connect = new SQLConnection();
            connect.openConnection(serverString);
            textBox1.Text += "Connection Status:" + connect.verifyConnection();
            textBox1.AppendText(Environment.NewLine);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
