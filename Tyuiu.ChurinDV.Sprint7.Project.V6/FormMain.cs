﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ChurinDV.Sprint7.Project.V6;

namespace Tyuiu.ChurinDV.Sprint7.Project.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogInfo_CDV.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";

        }

        private void buttonHelp_CDV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDoctors_CDV_Click(object sender, EventArgs e)
        {
            FormDoctors formDoctors = new FormDoctors();
            formDoctors.ShowDialog();
        }

        private void buttonPatients_CDV_Click(object sender, EventArgs e)
        {
            FormPatients formPatients = new FormPatients();
            formPatients.ShowDialog();
        }
    }
}
