﻿using POOP2.Classes;
using POOP2.Formularios;
using System;
using System.Windows.Forms;

namespace POOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExercisesClick(object sender, EventArgs e)
        {
            Form form = null;
            switch ((sender as Button).Name)
            {
                case "btnEx1":
                    form = new Ex01Form();
                    break;
                case "btnEx8":
                    form = new Ex08Form();
                    break;
                case "btnEx10":
                    form = new Ex10Form();
                    break;
                default:
                    break;
            }
            // Chamando o form com null safety check
            form?.Show();
        }
    }
}
