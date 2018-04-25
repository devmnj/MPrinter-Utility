using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Runtime.InteropServices;

namespace MPrintter_Utility
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            PrinterSettings setting = new PrinterSettings();
            listBox1.Items.Clear();
            
            foreach (string prntr in PrinterSettings.InstalledPrinters)
            {
                System.Console.WriteLine(prntr);
                listBox1.Items.Add(prntr);

            }
            if (listBox1.Items.Count > 0)
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }


    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrinterSettings setting = new PrinterSettings();
            listBox1.Items.Clear();
            foreach (string prntr in PrinterSettings.InstalledPrinters)
            {
                //System.Console.WriteLine(prntr);
                listBox1.Items.Add(prntr);

            }
            if (listBox1.Items.Count > 0)
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            if (listBox1.Text.Length > 1)
            {
                myPrinters.SetDefaultPrinter(listBox1.Text);
                MessageBox.Show("Default printer changed"); 
            }
            else
            {
                MessageBox.Show("Please select a printer");                
            }
        }
    }
    public static class myPrinters
    {
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDefaultPrinter(string Name);

    }
}
