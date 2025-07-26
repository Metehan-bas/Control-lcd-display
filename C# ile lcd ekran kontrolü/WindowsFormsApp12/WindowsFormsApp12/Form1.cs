using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            String data = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write(textBox1.Text);



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
                comboBox1.Items.Add(port);
        }
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string Veri = serialPort1.ReadLine();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                    serialPort1.Close();

                serialPort1.PortName = comboBox1.SelectedItem.ToString();
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                MessageBox.Show("Bağlantı kuruldu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ""
        }
    }
}
