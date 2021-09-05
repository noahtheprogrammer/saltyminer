﻿
namespace raptoreum_rtminer
{
    partial class rtm_miner
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rtm_miner));
            this.address_label = new System.Windows.Forms.Label();
            this.set_box = new System.Windows.Forms.ListBox();
            this.pool_text = new System.Windows.Forms.TextBox();
            this.pool_label = new System.Windows.Forms.Label();
            this.address_text = new System.Windows.Forms.TextBox();
            this.instruction_set_label = new System.Windows.Forms.Label();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new raptoreum_rtminer.RoundedPanel();
            this.extra_params_text = new System.Windows.Forms.TextBox();
            this.seperation_line = new System.Windows.Forms.Label();
            this.extra_params_label = new System.Windows.Forms.Label();
            this.roundedPanel1 = new raptoreum_rtminer.RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.threads_label = new System.Windows.Forms.Label();
            this.threads_text = new System.Windows.Forms.TextBox();
            this.mining_button = new System.Windows.Forms.PictureBox();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.cmd_output = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cpu_usage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.arch_count = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.core_count = new System.Windows.Forms.Label();
            this.quit_button = new System.Windows.Forms.PictureBox();
            this.min_button = new System.Windows.Forms.PictureBox();
            this.dash_button = new System.Windows.Forms.PictureBox();
            this.config_button = new System.Windows.Forms.PictureBox();
            this.sm_banner = new System.Windows.Forms.PictureBox();
            this.panel_1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mining_button)).BeginInit();
            this.panel_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quit_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dash_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sm_banner)).BeginInit();
            this.SuspendLayout();
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.address_label.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.address_label.Location = new System.Drawing.Point(17, 30);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(150, 17);
            this.address_label.TabIndex = 3;
            this.address_label.Text = "Insert payout address:";
            // 
            // set_box
            // 
            this.set_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.set_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.set_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.set_box.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.set_box.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.set_box.FormattingEnabled = true;
            this.set_box.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.set_box.ItemHeight = 14;
            this.set_box.Items.AddRange(new object[] {
            "AVX",
            "AVX2",
            "AVX512",
            "AVX512-SHA",
            "AVX512-SHA-VAES",
            "SSE2",
            "SSE42",
            "SSSE3",
            "ZEN",
            "ZEN2",
            "ZEN3"});
            this.set_box.Location = new System.Drawing.Point(12, 40);
            this.set_box.Name = "set_box";
            this.set_box.Size = new System.Drawing.Size(288, 154);
            this.set_box.TabIndex = 5;
            this.set_box.SelectedIndexChanged += new System.EventHandler(this.set_box_SelectedIndexChanged);
            // 
            // pool_text
            // 
            this.pool_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pool_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pool_text.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pool_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pool_text.Location = new System.Drawing.Point(17, 140);
            this.pool_text.Name = "pool_text";
            this.pool_text.PlaceholderText = "  (ex. stratum+tcp://r-pool.net:3008)";
            this.pool_text.Size = new System.Drawing.Size(348, 15);
            this.pool_text.TabIndex = 2;
            this.pool_text.TextChanged += new System.EventHandler(this.pool_text_TextChanged);
            // 
            // pool_label
            // 
            this.pool_label.AutoSize = true;
            this.pool_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pool_label.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pool_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.pool_label.Location = new System.Drawing.Point(17, 117);
            this.pool_label.Name = "pool_label";
            this.pool_label.Size = new System.Drawing.Size(127, 17);
            this.pool_label.TabIndex = 4;
            this.pool_label.Text = "Insert mining pool:";
            // 
            // address_text
            // 
            this.address_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.address_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.address_text.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.address_text.Location = new System.Drawing.Point(17, 53);
            this.address_text.Name = "address_text";
            this.address_text.PlaceholderText = "  (ex. RWXMEVTEJYNVP2HTJQ97DMYVWYTWUFTI8E)";
            this.address_text.Size = new System.Drawing.Size(348, 15);
            this.address_text.TabIndex = 0;
            this.address_text.TextChanged += new System.EventHandler(this.address_text_TextChanged);
            // 
            // instruction_set_label
            // 
            this.instruction_set_label.AutoSize = true;
            this.instruction_set_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.instruction_set_label.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instruction_set_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.instruction_set_label.Location = new System.Drawing.Point(12, 17);
            this.instruction_set_label.Name = "instruction_set_label";
            this.instruction_set_label.Size = new System.Drawing.Size(155, 17);
            this.instruction_set_label.TabIndex = 6;
            this.instruction_set_label.Text = "Choose instruction set:";
            // 
            // panel_1
            // 
            this.panel_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel_1.Controls.Add(this.label5);
            this.panel_1.Controls.Add(this.roundedPanel2);
            this.panel_1.Controls.Add(this.roundedPanel1);
            this.panel_1.Location = new System.Drawing.Point(-4, 47);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(860, 454);
            this.panel_1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(185, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(510, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Changes during mining will not be applied until the mining process is restarted.";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.Controls.Add(this.extra_params_text);
            this.roundedPanel2.Controls.Add(this.seperation_line);
            this.roundedPanel2.Controls.Add(this.extra_params_label);
            this.roundedPanel2.Controls.Add(this.set_box);
            this.roundedPanel2.Controls.Add(this.instruction_set_label);
            this.roundedPanel2.Location = new System.Drawing.Point(473, 50);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.panel_color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedPanel2.Size = new System.Drawing.Size(330, 326);
            this.roundedPanel2.TabIndex = 8;
            // 
            // extra_params_text
            // 
            this.extra_params_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.extra_params_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.extra_params_text.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.extra_params_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.extra_params_text.Location = new System.Drawing.Point(12, 243);
            this.extra_params_text.Name = "extra_params_text";
            this.extra_params_text.PlaceholderText = "  (ex. --tune-full)";
            this.extra_params_text.Size = new System.Drawing.Size(275, 15);
            this.extra_params_text.TabIndex = 9;
            this.extra_params_text.TextChanged += new System.EventHandler(this.extra_params_TextChanged);
            // 
            // seperation_line
            // 
            this.seperation_line.AutoSize = true;
            this.seperation_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.seperation_line.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seperation_line.ForeColor = System.Drawing.Color.Gray;
            this.seperation_line.Location = new System.Drawing.Point(12, 195);
            this.seperation_line.Name = "seperation_line";
            this.seperation_line.Size = new System.Drawing.Size(282, 14);
            this.seperation_line.TabIndex = 9;
            this.seperation_line.Text = "_______________________________________________________";
            // 
            // extra_params_label
            // 
            this.extra_params_label.AutoSize = true;
            this.extra_params_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.extra_params_label.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.extra_params_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.extra_params_label.Location = new System.Drawing.Point(12, 220);
            this.extra_params_label.Name = "extra_params_label";
            this.extra_params_label.Size = new System.Drawing.Size(96, 17);
            this.extra_params_label.TabIndex = 9;
            this.extra_params_label.Text = "Extra params:";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.label6);
            this.roundedPanel1.Controls.Add(this.threads_label);
            this.roundedPanel1.Controls.Add(this.threads_text);
            this.roundedPanel1.Controls.Add(this.pool_label);
            this.roundedPanel1.Controls.Add(this.pool_text);
            this.roundedPanel1.Controls.Add(this.address_label);
            this.roundedPanel1.Controls.Add(this.address_text);
            this.roundedPanel1.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundedPanel1.Location = new System.Drawing.Point(59, 50);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.panel_color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedPanel1.Size = new System.Drawing.Size(408, 326);
            this.roundedPanel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(17, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "_____________________________________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(17, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "_____________________________________________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label6.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(17, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(352, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "_____________________________________________________________________";
            // 
            // threads_label
            // 
            this.threads_label.AutoSize = true;
            this.threads_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.threads_label.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.threads_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.threads_label.Location = new System.Drawing.Point(17, 192);
            this.threads_label.Name = "threads_label";
            this.threads_label.Size = new System.Drawing.Size(133, 17);
            this.threads_label.TabIndex = 8;
            this.threads_label.Text = "Insert thread count:";
            // 
            // threads_text
            // 
            this.threads_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.threads_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.threads_text.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.threads_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.threads_text.Location = new System.Drawing.Point(17, 216);
            this.threads_text.Name = "threads_text";
            this.threads_text.PlaceholderText = "  (ex. 24)";
            this.threads_text.Size = new System.Drawing.Size(348, 15);
            this.threads_text.TabIndex = 7;
            this.threads_text.TextChanged += new System.EventHandler(this.threads_text_TextChanged);
            // 
            // mining_button
            // 
            this.mining_button.Image = global::raptoreum_rtminer.Properties.Resources.mine_start;
            this.mining_button.Location = new System.Drawing.Point(346, 80);
            this.mining_button.Name = "mining_button";
            this.mining_button.Size = new System.Drawing.Size(200, 200);
            this.mining_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mining_button.TabIndex = 0;
            this.mining_button.TabStop = false;
            this.mining_button.Click += new System.EventHandler(this.mining_button_Click_1);
            // 
            // panel_2
            // 
            this.panel_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel_2.Controls.Add(this.cmd_output);
            this.panel_2.Controls.Add(this.label7);
            this.panel_2.Controls.Add(this.cpu_usage);
            this.panel_2.Controls.Add(this.label4);
            this.panel_2.Controls.Add(this.arch_count);
            this.panel_2.Controls.Add(this.label2);
            this.panel_2.Controls.Add(this.core_count);
            this.panel_2.Controls.Add(this.mining_button);
            this.panel_2.Location = new System.Drawing.Point(-4, 47);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(860, 457);
            this.panel_2.TabIndex = 7;
            // 
            // cmd_output
            // 
            this.cmd_output.AutoSize = true;
            this.cmd_output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.cmd_output.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmd_output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.cmd_output.Location = new System.Drawing.Point(200, 30);
            this.cmd_output.Name = "cmd_output";
            this.cmd_output.Size = new System.Drawing.Size(560, 17);
            this.cmd_output.TabIndex = 11;
            this.cmd_output.Text = "This must display command line output whenever a new line is inputed.";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.label7.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(631, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "USAGE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpu_usage
            // 
            this.cpu_usage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.cpu_usage.Font = new System.Drawing.Font("Roboto Medium", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpu_usage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.cpu_usage.Location = new System.Drawing.Point(573, 331);
            this.cpu_usage.Name = "cpu_usage";
            this.cpu_usage.Size = new System.Drawing.Size(194, 74);
            this.cpu_usage.TabIndex = 9;
            this.cpu_usage.Text = "0%";
            this.cpu_usage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(346, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "ARCHITECTURE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arch_count
            // 
            this.arch_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.arch_count.Font = new System.Drawing.Font("Roboto Medium", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arch_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.arch_count.Location = new System.Drawing.Point(291, 331);
            this.arch_count.Name = "arch_count";
            this.arch_count.Size = new System.Drawing.Size(290, 74);
            this.arch_count.TabIndex = 7;
            this.arch_count.Text = "X86";
            this.arch_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(185, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "CORES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // core_count
            // 
            this.core_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.core_count.Font = new System.Drawing.Font("Roboto Medium", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.core_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.core_count.Location = new System.Drawing.Point(155, 331);
            this.core_count.Name = "core_count";
            this.core_count.Size = new System.Drawing.Size(147, 74);
            this.core_count.TabIndex = 4;
            this.core_count.Text = "0";
            this.core_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quit_button
            // 
            this.quit_button.Image = global::raptoreum_rtminer.Properties.Resources.exit_icon;
            this.quit_button.Location = new System.Drawing.Point(808, 1);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(40, 40);
            this.quit_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.quit_button.TabIndex = 12;
            this.quit_button.TabStop = false;
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // min_button
            // 
            this.min_button.Image = global::raptoreum_rtminer.Properties.Resources.minimize_icon;
            this.min_button.Location = new System.Drawing.Point(769, 1);
            this.min_button.Name = "min_button";
            this.min_button.Size = new System.Drawing.Size(40, 40);
            this.min_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.min_button.TabIndex = 13;
            this.min_button.TabStop = false;
            this.min_button.Click += new System.EventHandler(this.min_button_Click);
            // 
            // dash_button
            // 
            this.dash_button.Image = global::raptoreum_rtminer.Properties.Resources.home_button;
            this.dash_button.Location = new System.Drawing.Point(695, 1);
            this.dash_button.Name = "dash_button";
            this.dash_button.Size = new System.Drawing.Size(40, 40);
            this.dash_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dash_button.TabIndex = 14;
            this.dash_button.TabStop = false;
            this.dash_button.Click += new System.EventHandler(this.dash_button_Click);
            // 
            // config_button
            // 
            this.config_button.Image = global::raptoreum_rtminer.Properties.Resources.config_button;
            this.config_button.Location = new System.Drawing.Point(731, 1);
            this.config_button.Name = "config_button";
            this.config_button.Size = new System.Drawing.Size(40, 40);
            this.config_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.config_button.TabIndex = 15;
            this.config_button.TabStop = false;
            this.config_button.Click += new System.EventHandler(this.config_button_Click);
            // 
            // sm_banner
            // 
            this.sm_banner.Image = global::raptoreum_rtminer.Properties.Resources.sm_banner;
            this.sm_banner.Location = new System.Drawing.Point(-4, 1);
            this.sm_banner.Name = "sm_banner";
            this.sm_banner.Size = new System.Drawing.Size(150, 50);
            this.sm_banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sm_banner.TabIndex = 16;
            this.sm_banner.TabStop = false;
            // 
            // rtm_miner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.panel_2);
            this.Controls.Add(this.sm_banner);
            this.Controls.Add(this.config_button);
            this.Controls.Add(this.dash_button);
            this.Controls.Add(this.min_button);
            this.Controls.Add(this.quit_button);
            this.Controls.Add(this.panel_1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "rtm_miner";
            this.Text = "SaltyMiner";
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mining_button)).EndInit();
            this.panel_2.ResumeLayout(false);
            this.panel_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quit_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dash_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sm_banner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.ListBox set_box;
        private System.Windows.Forms.TextBox pool_text;
        private System.Windows.Forms.Label pool_label;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.Label instruction_set_label;
        private System.Windows.Forms.Panel panel_1;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.PictureBox mining_button;
        private System.Windows.Forms.Panel panel_2;
        private System.Windows.Forms.Label threads_label;
        private System.Windows.Forms.TextBox threads_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label seperation_line;
        private System.Windows.Forms.TextBox extra_params_text;
        private System.Windows.Forms.Label extra_params_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox quit_button;
        private System.Windows.Forms.PictureBox min_button;
        private System.Windows.Forms.PictureBox dash_button;
        private System.Windows.Forms.PictureBox config_button;
        private System.Windows.Forms.PictureBox sm_banner;
        private System.Windows.Forms.Label core_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label arch_count;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cpu_usage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cmd_output;
    }
}

