﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pokemon_towerdefense.Models;

namespace pokemon_towerdefense
{
    public partial class Load : Form
    {
        // Get Screen Size Resolution
        Size windowSize = Screen.PrimaryScreen.WorkingArea.Size;

        public Load()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.arcanine.Width = ConvertProportionalWidth(700);
            this.arcanine.Height = ConvertProportionalHeight(500);
            this.panel1.Location = new Point((this.Width / 2 - (this.panel1.Width / 2)), ((this.Height / 2) - (this.panel1.Height / 2)));
            this.arcanine.Location = new Point((this.Width - this.arcanine.Width), this.Height - this.arcanine.Height);
            this.logo.Location = new Point((this.Width / 2) - this.logo.Width / 2, ((this.Height / 3 - 100) - this.logo.Height / 2));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game form = new Game();
            form.Show();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private int ConvertProportionalWidth(int value)
        {
            double proportionalWidth = windowSize.Width / 1920.0;

            return Convert.ToInt16(Convert.ToDouble(value) * proportionalWidth);
        }

        private int ConvertProportionalHeight(int value)
        {
            double proportionalHeight = windowSize.Height / 1040.0;

            return Convert.ToInt16(Convert.ToDouble(value) * proportionalHeight);
        }
    }
}
