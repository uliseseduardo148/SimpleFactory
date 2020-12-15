﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFactory
{
    public partial class NameSplitter : Form
    {
        public NameSplitter()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            Namer nm = NameFactory.getName(txtDatos.Text);
            txtNombre.Text = nm.getFrname();
            txtApellido.Text = nm.getLname();
        }
    }
}
