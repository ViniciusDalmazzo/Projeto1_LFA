﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            RegrasDeProducao.RowHeadersVisible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string letra = txtAlfabeto.Text;
            
            Alfabeto.Items.Add(letra);
        }
        
    }
}
