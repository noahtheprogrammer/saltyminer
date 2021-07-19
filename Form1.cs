﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace raptoreum_rtminer
{

    // Class that holds the rtm_miner form
    public partial class rtm_miner : Form
    {
        // Gets the information required to round the form edges
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn 
        (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        // Process and info to be used for mining
        Process process;
        ProcessStartInfo processInfo;

        // Instruction set to be used for proper CPU
        public string instruction_set;

        // Bool to remember if CPU is mining
        public bool _ismining = false;

        // String used to hold RTM address
        public string address;

        // String used to hold pool of choice
        public string pool;

        // Initializes the rtm_miner component
        public rtm_miner()
        {
            InitializeComponent();
            dash_button.ForeColor = Color.FromArgb(252, 212, 94);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        // Starts or stops the mining whenever the button is clicked
        private void mining_button_Click(object sender, EventArgs e)
        {
            if (_ismining == false)
            {
                RunMiner();
                ButtonChange();
                _ismining = true;
            }

            else if (_ismining == true)
            {
                QuitMiner();
                ButtonChange();
                _ismining = false;
            }
        }

        // Turns on the CPU miner process
        public void RunMiner()
        {
            processInfo = new ProcessStartInfo(instruction_set +".exe", "-a gr -o " + pool + " -u " + address);
            processInfo.CreateNoWindow = true;
            process = Process.Start(processInfo);
        }

        // Turns off the CPU miner process
        public void QuitMiner()
        {
            process.Kill();
        }

        // Gets the address text to mine
        private void address_text_TextChanged(object sender, EventArgs e)
        {
            address = address_text.Text;
        }

        // Gets the pool text to mine
        private void pool_text_TextChanged(object sender, EventArgs e)
        {
            pool = pool_text.Text;
        }

        // Gets the proper instruction set chosen to mine
        private void set_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            instruction_set = set_box.Text; 
        }

        // Changes button color
        private void ButtonChange()
        {
            if (_ismining == false)
            {
                mining_button.BackColor = Color.FromArgb(255, 192, 192);
                mining_button.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
                mining_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 108, 108);
                mining_button.Image = Properties.Resources.mine_stop;
            }

            if (_ismining == true)
            {
                mining_button.BackColor = Color.FromArgb(128, 255, 128);
                mining_button.FlatAppearance.BorderColor = Color.FromArgb(98, 235, 98);
                mining_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 215, 78);
                mining_button.Image = Properties.Resources.mine_start;
            }
        }

        // Brings the mining panel to the front
        private void dash_button_Click(object sender, EventArgs e)
        {
            panel_2.BringToFront();
            dash_button.ForeColor = Color.FromArgb(252, 212, 94);
            config_button.ForeColor = Color.LightSteelBlue;
        }

        // Brings the configuration panel to the front
        private void config_button_Click(object sender, EventArgs e)
        {
            panel_1.BringToFront();
            config_button.ForeColor = Color.FromArgb(252, 212, 94);
            dash_button.ForeColor = Color.LightSteelBlue;
        }

        // Quits the program on click
        private void quit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}