﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproj2
{
    public partial class TeacherLogIn : Form
    {
        public TeacherLogIn()
        {
            InitializeComponent();
        }

        private void TeacherLogIn_Load(object sender, EventArgs e)
        {
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void txtbxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtbxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Form MainDashboard = new MainDashboard();
            MainDashboard.Show();
            this.Hide();
        }
    }
}
