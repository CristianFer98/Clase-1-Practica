﻿using PW3_2022_1C_Clase_1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW3_2022_1C_Clase_1.Winforms
{
    public partial class form1 : Form
    {
        public string text = "";
        public form1()
        {
            InitializeComponent();
           
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form = new Form2();
            form.Show();
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }
    }
}
