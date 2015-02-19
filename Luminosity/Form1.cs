using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Luminosity
{
    public partial class Form1 : Form
    {
        SerialPort port;

        public Form1()
        {
            InitializeComponent();
            port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            port.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set the WindowState in Normal Mode  
            WindowState = FormWindowState.Normal; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void red_button_Click(object sender, EventArgs e)
        {
            port.Write("a");
        }

        private void green_button_Click(object sender, EventArgs e)
        {
            port.Write("b");
        }

        private void blue_button_Click(object sender, EventArgs e)
        {
            port.Write("c");
        }

        private void white_button_Click(object sender, EventArgs e)
        {
            port.Write("d");
        }

        private void violet_button_Click(object sender, EventArgs e)
        {
            port.Write("e");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            port.Write("f");
        }

        private void lime_button_Click(object sender, EventArgs e)
        {
            port.Write("g");
        }

        private void orange_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.niralbhavsar.com");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Restore the form upon double-click on NotifyIcon control.   
            //Display the Form in normal state  
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void hide_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            //TODO: Notify user hide to taskbar
        }











    }
}
