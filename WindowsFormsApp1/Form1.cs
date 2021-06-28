﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private object btnPrintNumbers;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;

            Thread workerThread = new Thread(TimeConsumingWork);
            workerThread.Start();

            button1.Enabled = true;
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <=10; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void TimeConsumingWork()
        {
            Thread.Sleep(5000);
        }
    }
}
