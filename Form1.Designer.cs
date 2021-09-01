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
            this.label1 = new System.Windows.Forms.Label();
            this.address_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new raptoreum_rtminer.RoundedPanel();
            this.roundedPanel1 = new raptoreum_rtminer.RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.credit_text = new System.Windows.Forms.Label();
            this.mining_button = new System.Windows.Forms.PictureBox();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.salty_logo = new System.Windows.Forms.PictureBox();
            this.dash_button = new System.Windows.Forms.PictureBox();
            this.config_button = new System.Windows.Forms.PictureBox();
            this.min_button = new System.Windows.Forms.PictureBox();
            this.quit_button = new System.Windows.Forms.PictureBox();
            this.panel_1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mining_button)).BeginInit();
            this.panel_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salty_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dash_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quit_button)).BeginInit();
            this.SuspendLayout();
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.address_label.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.address_label.Location = new System.Drawing.Point(14, 35);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(170, 19);
            this.address_label.TabIndex = 3;
            this.address_label.Text = "Insert payout address:";
            // 
            // set_box
            // 
            this.set_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.set_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.set_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.set_box.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.set_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.set_box.FormattingEnabled = true;
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
            this.set_box.Location = new System.Drawing.Point(12, 67);
            this.set_box.Name = "set_box";
            this.set_box.Size = new System.Drawing.Size(278, 154);
            this.set_box.TabIndex = 5;
            this.set_box.SelectedIndexChanged += new System.EventHandler(this.set_box_SelectedIndexChanged);
            // 
            // pool_text
            // 
            this.pool_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pool_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pool_text.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.pool_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.pool_text.Location = new System.Drawing.Point(14, 172);
            this.pool_text.Name = "pool_text";
            this.pool_text.PlaceholderText = "  (ex. stratum+tcp://r-pool.net:3008)";
            this.pool_text.Size = new System.Drawing.Size(348, 15);
            this.pool_text.TabIndex = 2;
            this.pool_text.TextChanged += new System.EventHandler(this.pool_text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.label1.Location = new System.Drawing.Point(14, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Insert mining pool:";
            // 
            // address_text
            // 
            this.address_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.address_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.address_text.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.address_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.address_text.Location = new System.Drawing.Point(14, 70);
            this.address_text.Name = "address_text";
            this.address_text.PlaceholderText = "  (ex. RWXMEVTEJYNVP2HTJQ97DMYVWYTWUFTI8E)";
            this.address_text.Size = new System.Drawing.Size(348, 15);
            this.address_text.TabIndex = 0;
            this.address_text.TextChanged += new System.EventHandler(this.address_text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.label2.Location = new System.Drawing.Point(14, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose instruction set:";
            // 
            // panel_1
            // 
            this.panel_1.BackColor = System.Drawing.Color.White;
            this.panel_1.Controls.Add(this.label4);
            this.panel_1.Controls.Add(this.label5);
            this.panel_1.Controls.Add(this.roundedPanel2);
            this.panel_1.Controls.Add(this.roundedPanel1);
            this.panel_1.Location = new System.Drawing.Point(-4, 47);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(860, 410);
            this.panel_1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(16, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(826, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "_________________________________________________________________________________" +
    "____________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.label5.Location = new System.Drawing.Point(245, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(374, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Donation address: RWXmeVTEJYNVp2htJQ97DMYvwytWUFTi8E";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.Controls.Add(this.set_box);
            this.roundedPanel2.Controls.Add(this.label2);
            this.roundedPanel2.Location = new System.Drawing.Point(473, 50);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.panel_color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.roundedPanel2.Size = new System.Drawing.Size(321, 285);
            this.roundedPanel2.TabIndex = 8;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.pool_text);
            this.roundedPanel1.Controls.Add(this.address_label);
            this.roundedPanel1.Controls.Add(this.address_text);
            this.roundedPanel1.Location = new System.Drawing.Point(59, 50);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.panel_color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.roundedPanel1.Size = new System.Drawing.Size(408, 267);
            this.roundedPanel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.label3.Location = new System.Drawing.Point(20, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "______________________________________________";
            // 
            // credit_text
            // 
            this.credit_text.AutoSize = true;
            this.credit_text.BackColor = System.Drawing.Color.White;
            this.credit_text.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.credit_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.credit_text.Location = new System.Drawing.Point(237, 379);
            this.credit_text.Name = "credit_text";
            this.credit_text.Size = new System.Drawing.Size(402, 15);
            this.credit_text.TabIndex = 9;
            this.credit_text.Text = "This miner was created by OKprogrammer and is open-source for all.";
            // 
            // mining_button
            // 
            this.mining_button.Image = global::raptoreum_rtminer.Properties.Resources.mine_start;
            this.mining_button.Location = new System.Drawing.Point(329, 85);
            this.mining_button.Name = "mining_button";
            this.mining_button.Size = new System.Drawing.Size(200, 200);
            this.mining_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mining_button.TabIndex = 0;
            this.mining_button.TabStop = false;
            this.mining_button.Click += new System.EventHandler(this.mining_button_Click);
            // 
            // panel_2
            // 
            this.panel_2.BackColor = System.Drawing.Color.White;
            this.panel_2.Controls.Add(this.label6);
            this.panel_2.Controls.Add(this.credit_text);
            this.panel_2.Controls.Add(this.mining_button);
            this.panel_2.Location = new System.Drawing.Point(-4, 47);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(860, 410);
            this.panel_2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Location = new System.Drawing.Point(16, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(826, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "_________________________________________________________________________________" +
    "____________________________________";
            // 
            // salty_logo
            // 
            this.salty_logo.Image = global::raptoreum_rtminer.Properties.Resources.saltyminer_banner;
            this.salty_logo.Location = new System.Drawing.Point(-1, -1);
            this.salty_logo.Name = "salty_logo";
            this.salty_logo.Size = new System.Drawing.Size(180, 60);
            this.salty_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.salty_logo.TabIndex = 12;
            this.salty_logo.TabStop = false;
            // 
            // dash_button
            // 
            this.dash_button.Image = global::raptoreum_rtminer.Properties.Resources.disabled_home;
            this.dash_button.Location = new System.Drawing.Point(696, 12);
            this.dash_button.Name = "dash_button";
            this.dash_button.Size = new System.Drawing.Size(40, 40);
            this.dash_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dash_button.TabIndex = 13;
            this.dash_button.TabStop = false;
            this.dash_button.Click += new System.EventHandler(this.dash_button_Click);
            // 
            // config_button
            // 
            this.config_button.Image = global::raptoreum_rtminer.Properties.Resources.disabled_config;
            this.config_button.Location = new System.Drawing.Point(732, 12);
            this.config_button.Name = "config_button";
            this.config_button.Size = new System.Drawing.Size(40, 40);
            this.config_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.config_button.TabIndex = 14;
            this.config_button.TabStop = false;
            this.config_button.Click += new System.EventHandler(this.config_button_Click);
            // 
            // min_button
            // 
            this.min_button.Image = global::raptoreum_rtminer.Properties.Resources.minimize_icon;
            this.min_button.Location = new System.Drawing.Point(769, 12);
            this.min_button.Name = "min_button";
            this.min_button.Size = new System.Drawing.Size(40, 40);
            this.min_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.min_button.TabIndex = 15;
            this.min_button.TabStop = false;
            this.min_button.Click += new System.EventHandler(this.min_button_Click);
            // 
            // quit_button
            // 
            this.quit_button.Image = global::raptoreum_rtminer.Properties.Resources.exit_icon;
            this.quit_button.Location = new System.Drawing.Point(806, 12);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(40, 40);
            this.quit_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.quit_button.TabIndex = 16;
            this.quit_button.TabStop = false;
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // rtm_miner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.quit_button);
            this.Controls.Add(this.min_button);
            this.Controls.Add(this.config_button);
            this.Controls.Add(this.dash_button);
            this.Controls.Add(this.salty_logo);
            this.Controls.Add(this.panel_2);
            this.Controls.Add(this.panel_1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.salty_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dash_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quit_button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.ListBox set_box;
        private System.Windows.Forms.TextBox pool_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_1;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label credit_text;
        private System.Windows.Forms.PictureBox mining_button;
        private System.Windows.Forms.Panel panel_2;
        private System.Windows.Forms.PictureBox salty_logo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox dash_button;
        private System.Windows.Forms.PictureBox config_button;
        private System.Windows.Forms.PictureBox min_button;
        private System.Windows.Forms.PictureBox quit_button;
    }
}

