namespace salty
{
    partial class saltyminer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(saltyminer));
            this.pool_text = new System.Windows.Forms.TextBox();
            this.address_text = new System.Windows.Forms.TextBox();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.roundedPanel3 = new salty.RoundedPanel();
            this.address_label = new System.Windows.Forms.Label();
            this.seperation_line_3 = new System.Windows.Forms.Panel();
            this.set_box = new System.Windows.Forms.TextBox();
            this.enabled_text = new System.Windows.Forms.Label();
            this.enabled_count = new System.Windows.Forms.Label();
            this.extra_gpu_params_text = new System.Windows.Forms.TextBox();
            this.extra_cpu_params_text = new System.Windows.Forms.TextBox();
            this.threads_text = new System.Windows.Forms.TextBox();
            this.mining_button = new System.Windows.Forms.PictureBox();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.roundedPanel2 = new salty.RoundedPanel();
            this.performance_label = new System.Windows.Forms.Label();
            this.seperation_line_2 = new System.Windows.Forms.Panel();
            this.seperation_line_1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.arch_count = new System.Windows.Forms.Label();
            this.cpu_count = new System.Windows.Forms.Label();
            this.arch_text = new System.Windows.Forms.Label();
            this.gpu_text = new System.Windows.Forms.Label();
            this.usage_text = new System.Windows.Forms.Label();
            this.cpu_usage = new System.Windows.Forms.Label();
            this.gpu_count = new System.Windows.Forms.Label();
            this.cpu_cmd_output = new System.Windows.Forms.TextBox();
            this.quit_button = new System.Windows.Forms.PictureBox();
            this.min_button = new System.Windows.Forms.PictureBox();
            this.dash_button = new System.Windows.Forms.PictureBox();
            this.config_button = new System.Windows.Forms.PictureBox();
            this.sm_banner = new System.Windows.Forms.PictureBox();
            this.panel_3 = new System.Windows.Forms.Panel();
            this.output_title = new System.Windows.Forms.Label();
            this.ui_holder_3 = new System.Windows.Forms.PictureBox();
            this.cmd_button = new System.Windows.Forms.PictureBox();
            this.panel_1.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mining_button)).BeginInit();
            this.panel_2.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quit_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dash_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sm_banner)).BeginInit();
            this.panel_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ui_holder_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_button)).BeginInit();
            this.SuspendLayout();
            // 
            // pool_text
            // 
            this.pool_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pool_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pool_text.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pool_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.pool_text.Location = new System.Drawing.Point(175, 90);
            this.pool_text.Name = "pool_text";
            this.pool_text.PlaceholderText = "Insert pool network";
            this.pool_text.Size = new System.Drawing.Size(300, 17);
            this.pool_text.TabIndex = 2;
            this.pool_text.TextChanged += new System.EventHandler(this.pool_text_TextChanged);
            // 
            // address_text
            // 
            this.address_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.address_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.address_text.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.address_text.Location = new System.Drawing.Point(175, 53);
            this.address_text.Name = "address_text";
            this.address_text.PlaceholderText = "Insert custom address";
            this.address_text.Size = new System.Drawing.Size(300, 17);
            this.address_text.TabIndex = 0;
            this.address_text.TextChanged += new System.EventHandler(this.address_text_TextChanged);
            // 
            // panel_1
            // 
            this.panel_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel_1.Controls.Add(this.roundedPanel3);
            this.panel_1.Location = new System.Drawing.Point(-4, 47);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(860, 454);
            this.panel_1.TabIndex = 8;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel3.Controls.Add(this.address_label);
            this.roundedPanel3.Controls.Add(this.seperation_line_3);
            this.roundedPanel3.Controls.Add(this.set_box);
            this.roundedPanel3.Controls.Add(this.enabled_text);
            this.roundedPanel3.Controls.Add(this.enabled_count);
            this.roundedPanel3.Controls.Add(this.extra_gpu_params_text);
            this.roundedPanel3.Controls.Add(this.extra_cpu_params_text);
            this.roundedPanel3.Controls.Add(this.pool_text);
            this.roundedPanel3.Controls.Add(this.threads_text);
            this.roundedPanel3.Controls.Add(this.address_text);
            this.roundedPanel3.Location = new System.Drawing.Point(22, 10);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.panel_color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedPanel3.Size = new System.Drawing.Size(820, 221);
            this.roundedPanel3.TabIndex = 19;
            // 
            // address_label
            // 
            this.address_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.address_label.Font = new System.Drawing.Font("Roboto Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.address_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.address_label.Location = new System.Drawing.Point(175, 22);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(157, 15);
            this.address_label.TabIndex = 21;
            this.address_label.Text = "Miner Instructions:";
            this.address_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.address_label.UseCompatibleTextRendering = true;
            // 
            // seperation_line_3
            // 
            this.seperation_line_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.seperation_line_3.Location = new System.Drawing.Point(147, 12);
            this.seperation_line_3.Name = "seperation_line_3";
            this.seperation_line_3.Size = new System.Drawing.Size(2, 160);
            this.seperation_line_3.TabIndex = 20;
            // 
            // set_box
            // 
            this.set_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.set_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.set_box.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.set_box.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.set_box.Location = new System.Drawing.Point(484, 126);
            this.set_box.Name = "set_box";
            this.set_box.PlaceholderText = "Insert instruction set";
            this.set_box.Size = new System.Drawing.Size(225, 17);
            this.set_box.TabIndex = 20;
            // 
            // enabled_text
            // 
            this.enabled_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.enabled_text.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enabled_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.enabled_text.Location = new System.Drawing.Point(24, 107);
            this.enabled_text.Name = "enabled_text";
            this.enabled_text.Size = new System.Drawing.Size(104, 27);
            this.enabled_text.TabIndex = 17;
            this.enabled_text.Text = "ENABLED";
            this.enabled_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.enabled_text.UseCompatibleTextRendering = true;
            // 
            // enabled_count
            // 
            this.enabled_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.enabled_count.Font = new System.Drawing.Font("Roboto Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enabled_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.enabled_count.Location = new System.Drawing.Point(13, 51);
            this.enabled_count.Name = "enabled_count";
            this.enabled_count.Size = new System.Drawing.Size(128, 56);
            this.enabled_count.TabIndex = 17;
            this.enabled_count.Text = "2/2";
            this.enabled_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.enabled_count.UseCompatibleTextRendering = true;
            // 
            // extra_gpu_params_text
            // 
            this.extra_gpu_params_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.extra_gpu_params_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.extra_gpu_params_text.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.extra_gpu_params_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.extra_gpu_params_text.Location = new System.Drawing.Point(484, 90);
            this.extra_gpu_params_text.Name = "extra_gpu_params_text";
            this.extra_gpu_params_text.PlaceholderText = "Insert GPU parameters";
            this.extra_gpu_params_text.Size = new System.Drawing.Size(300, 17);
            this.extra_gpu_params_text.TabIndex = 18;
            // 
            // extra_cpu_params_text
            // 
            this.extra_cpu_params_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.extra_cpu_params_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.extra_cpu_params_text.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.extra_cpu_params_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.extra_cpu_params_text.Location = new System.Drawing.Point(484, 51);
            this.extra_cpu_params_text.Name = "extra_cpu_params_text";
            this.extra_cpu_params_text.PlaceholderText = "Insert CPU parameters";
            this.extra_cpu_params_text.Size = new System.Drawing.Size(300, 17);
            this.extra_cpu_params_text.TabIndex = 9;
            this.extra_cpu_params_text.TextChanged += new System.EventHandler(this.extra_params_TextChanged);
            // 
            // threads_text
            // 
            this.threads_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.threads_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.threads_text.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.threads_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.threads_text.Location = new System.Drawing.Point(175, 126);
            this.threads_text.Name = "threads_text";
            this.threads_text.PlaceholderText = "Insert usable cores";
            this.threads_text.Size = new System.Drawing.Size(300, 17);
            this.threads_text.TabIndex = 7;
            this.threads_text.TextChanged += new System.EventHandler(this.threads_text_TextChanged);
            // 
            // mining_button
            // 
            this.mining_button.Image = global::salty.Properties.Resources.mine_start;
            this.mining_button.Location = new System.Drawing.Point(331, 5);
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
            this.panel_2.Controls.Add(this.roundedPanel2);
            this.panel_2.Controls.Add(this.mining_button);
            this.panel_2.Location = new System.Drawing.Point(-4, 47);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(860, 457);
            this.panel_2.TabIndex = 7;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel2.Controls.Add(this.performance_label);
            this.roundedPanel2.Controls.Add(this.seperation_line_2);
            this.roundedPanel2.Controls.Add(this.seperation_line_1);
            this.roundedPanel2.Controls.Add(this.label1);
            this.roundedPanel2.Controls.Add(this.arch_count);
            this.roundedPanel2.Controls.Add(this.cpu_count);
            this.roundedPanel2.Controls.Add(this.arch_text);
            this.roundedPanel2.Controls.Add(this.gpu_text);
            this.roundedPanel2.Controls.Add(this.usage_text);
            this.roundedPanel2.Controls.Add(this.cpu_usage);
            this.roundedPanel2.Controls.Add(this.gpu_count);
            this.roundedPanel2.Location = new System.Drawing.Point(101, 211);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.panel_color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedPanel2.Size = new System.Drawing.Size(658, 212);
            this.roundedPanel2.TabIndex = 11;
            // 
            // performance_label
            // 
            this.performance_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.performance_label.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.performance_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.performance_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.performance_label.Location = new System.Drawing.Point(324, 23);
            this.performance_label.Name = "performance_label";
            this.performance_label.Size = new System.Drawing.Size(169, 26);
            this.performance_label.TabIndex = 22;
            this.performance_label.Text = "Performance:";
            this.performance_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.performance_label.UseCompatibleTextRendering = true;
            // 
            // seperation_line_2
            // 
            this.seperation_line_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.seperation_line_2.Location = new System.Drawing.Point(301, 12);
            this.seperation_line_2.Name = "seperation_line_2";
            this.seperation_line_2.Size = new System.Drawing.Size(2, 150);
            this.seperation_line_2.TabIndex = 16;
            // 
            // seperation_line_1
            // 
            this.seperation_line_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.seperation_line_1.Location = new System.Drawing.Point(150, 12);
            this.seperation_line_1.Name = "seperation_line_1";
            this.seperation_line_1.Size = new System.Drawing.Size(2, 150);
            this.seperation_line_1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(188, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "CPU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // arch_count
            // 
            this.arch_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.arch_count.Font = new System.Drawing.Font("Roboto Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arch_count.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.arch_count.Location = new System.Drawing.Point(479, 111);
            this.arch_count.Name = "arch_count";
            this.arch_count.Size = new System.Drawing.Size(107, 32);
            this.arch_count.TabIndex = 7;
            this.arch_count.Text = "X64";
            this.arch_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.arch_count.UseCompatibleTextRendering = true;
            // 
            // cpu_count
            // 
            this.cpu_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cpu_count.Font = new System.Drawing.Font("Roboto Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpu_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.cpu_count.Location = new System.Drawing.Point(187, 47);
            this.cpu_count.Name = "cpu_count";
            this.cpu_count.Size = new System.Drawing.Size(81, 56);
            this.cpu_count.TabIndex = 13;
            this.cpu_count.Text = "1";
            this.cpu_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cpu_count.UseCompatibleTextRendering = true;
            // 
            // arch_text
            // 
            this.arch_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.arch_text.Font = new System.Drawing.Font("Roboto Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arch_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.arch_text.Location = new System.Drawing.Point(324, 111);
            this.arch_text.Name = "arch_text";
            this.arch_text.Size = new System.Drawing.Size(147, 27);
            this.arch_text.TabIndex = 8;
            this.arch_text.Text = "ARCHITECTURE:";
            this.arch_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.arch_text.UseCompatibleTextRendering = true;
            // 
            // gpu_text
            // 
            this.gpu_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.gpu_text.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpu_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.gpu_text.Location = new System.Drawing.Point(35, 98);
            this.gpu_text.Name = "gpu_text";
            this.gpu_text.Size = new System.Drawing.Size(80, 27);
            this.gpu_text.TabIndex = 12;
            this.gpu_text.Text = "GPU";
            this.gpu_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gpu_text.UseCompatibleTextRendering = true;
            // 
            // usage_text
            // 
            this.usage_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.usage_text.Font = new System.Drawing.Font("Roboto Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usage_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.usage_text.Location = new System.Drawing.Point(324, 67);
            this.usage_text.Name = "usage_text";
            this.usage_text.Size = new System.Drawing.Size(135, 27);
            this.usage_text.TabIndex = 10;
            this.usage_text.Text = "CPU USAGE:";
            this.usage_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usage_text.UseCompatibleTextRendering = true;
            // 
            // cpu_usage
            // 
            this.cpu_usage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cpu_usage.Font = new System.Drawing.Font("Roboto Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpu_usage.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cpu_usage.Location = new System.Drawing.Point(517, 65);
            this.cpu_usage.Name = "cpu_usage";
            this.cpu_usage.Size = new System.Drawing.Size(69, 28);
            this.cpu_usage.TabIndex = 9;
            this.cpu_usage.Text = "0%";
            this.cpu_usage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cpu_usage.UseCompatibleTextRendering = true;
            // 
            // gpu_count
            // 
            this.gpu_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.gpu_count.Font = new System.Drawing.Font("Roboto Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpu_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.gpu_count.Location = new System.Drawing.Point(35, 47);
            this.gpu_count.Name = "gpu_count";
            this.gpu_count.Size = new System.Drawing.Size(80, 56);
            this.gpu_count.TabIndex = 12;
            this.gpu_count.Text = "1";
            this.gpu_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gpu_count.UseCompatibleTextRendering = true;
            // 
            // cpu_cmd_output
            // 
            this.cpu_cmd_output.AcceptsReturn = true;
            this.cpu_cmd_output.AcceptsTab = true;
            this.cpu_cmd_output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cpu_cmd_output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cpu_cmd_output.Cursor = System.Windows.Forms.Cursors.Default;
            this.cpu_cmd_output.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpu_cmd_output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.cpu_cmd_output.Location = new System.Drawing.Point(59, 102);
            this.cpu_cmd_output.Multiline = true;
            this.cpu_cmd_output.Name = "cpu_cmd_output";
            this.cpu_cmd_output.ReadOnly = true;
            this.cpu_cmd_output.Size = new System.Drawing.Size(722, 289);
            this.cpu_cmd_output.TabIndex = 11;
            // 
            // quit_button
            // 
            this.quit_button.Image = global::salty.Properties.Resources.exit_icon_dark;
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
            this.min_button.Image = global::salty.Properties.Resources.minimize_icon_dark;
            this.min_button.Location = new System.Drawing.Point(762, 1);
            this.min_button.Name = "min_button";
            this.min_button.Size = new System.Drawing.Size(40, 40);
            this.min_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.min_button.TabIndex = 13;
            this.min_button.TabStop = false;
            this.min_button.Click += new System.EventHandler(this.min_button_Click);
            // 
            // dash_button
            // 
            this.dash_button.Image = global::salty.Properties.Resources.home_button_dark;
            this.dash_button.Location = new System.Drawing.Point(623, 1);
            this.dash_button.Name = "dash_button";
            this.dash_button.Size = new System.Drawing.Size(40, 40);
            this.dash_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dash_button.TabIndex = 14;
            this.dash_button.TabStop = false;
            this.dash_button.Click += new System.EventHandler(this.dash_button_Click);
            // 
            // config_button
            // 
            this.config_button.Image = global::salty.Properties.Resources.config_button_dark;
            this.config_button.Location = new System.Drawing.Point(669, 1);
            this.config_button.Name = "config_button";
            this.config_button.Size = new System.Drawing.Size(40, 40);
            this.config_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.config_button.TabIndex = 15;
            this.config_button.TabStop = false;
            this.config_button.Click += new System.EventHandler(this.config_button_Click);
            // 
            // sm_banner
            // 
            this.sm_banner.Image = global::salty.Properties.Resources.sm_banner_dark;
            this.sm_banner.Location = new System.Drawing.Point(-4, 1);
            this.sm_banner.Name = "sm_banner";
            this.sm_banner.Size = new System.Drawing.Size(150, 50);
            this.sm_banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sm_banner.TabIndex = 16;
            this.sm_banner.TabStop = false;
            // 
            // panel_3
            // 
            this.panel_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel_3.Controls.Add(this.output_title);
            this.panel_3.Controls.Add(this.cpu_cmd_output);
            this.panel_3.Controls.Add(this.ui_holder_3);
            this.panel_3.Location = new System.Drawing.Point(-4, 47);
            this.panel_3.Name = "panel_3";
            this.panel_3.Size = new System.Drawing.Size(860, 454);
            this.panel_3.TabIndex = 18;
            // 
            // output_title
            // 
            this.output_title.AutoSize = true;
            this.output_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.output_title.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.output_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.output_title.Location = new System.Drawing.Point(59, 41);
            this.output_title.Name = "output_title";
            this.output_title.Size = new System.Drawing.Size(93, 39);
            this.output_title.TabIndex = 13;
            this.output_title.Text = "Output";
            this.output_title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.output_title.UseCompatibleTextRendering = true;
            // 
            // ui_holder_3
            // 
            this.ui_holder_3.Image = global::salty.Properties.Resources.ui_2_dark;
            this.ui_holder_3.Location = new System.Drawing.Point(22, 13);
            this.ui_holder_3.Name = "ui_holder_3";
            this.ui_holder_3.Size = new System.Drawing.Size(800, 400);
            this.ui_holder_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ui_holder_3.TabIndex = 12;
            this.ui_holder_3.TabStop = false;
            // 
            // cmd_button
            // 
            this.cmd_button.Image = global::salty.Properties.Resources.cmd_button_dark;
            this.cmd_button.Location = new System.Drawing.Point(715, 1);
            this.cmd_button.Name = "cmd_button";
            this.cmd_button.Size = new System.Drawing.Size(40, 40);
            this.cmd_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmd_button.TabIndex = 19;
            this.cmd_button.TabStop = false;
            this.cmd_button.Click += new System.EventHandler(this.cmd_button_Click);
            // 
            // saltyminer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.cmd_button);
            this.Controls.Add(this.sm_banner);
            this.Controls.Add(this.config_button);
            this.Controls.Add(this.dash_button);
            this.Controls.Add(this.min_button);
            this.Controls.Add(this.quit_button);
            this.Controls.Add(this.panel_2);
            this.Controls.Add(this.panel_3);
            this.Controls.Add(this.panel_1);
            this.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "saltyminer";
            this.Text = "SaltyMiner";
            this.panel_1.ResumeLayout(false);
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mining_button)).EndInit();
            this.panel_2.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quit_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dash_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sm_banner)).EndInit();
            this.panel_3.ResumeLayout(false);
            this.panel_3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ui_holder_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox pool_text;
        public System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.Panel panel_1;
        private System.Windows.Forms.PictureBox mining_button;
        private System.Windows.Forms.Panel panel_2;
        public System.Windows.Forms.TextBox threads_text;
        public System.Windows.Forms.TextBox extra_cpu_params_text;
        private System.Windows.Forms.PictureBox quit_button;
        private System.Windows.Forms.PictureBox min_button;
        private System.Windows.Forms.PictureBox dash_button;
        private System.Windows.Forms.PictureBox config_button;
        private System.Windows.Forms.PictureBox sm_banner;
        private System.Windows.Forms.TextBox cpu_cmd_output;
        private System.Windows.Forms.Label arch_count;
        private System.Windows.Forms.Label arch_text;
        public System.Windows.Forms.Label cpu_usage;
        private System.Windows.Forms.Label usage_text;
        private System.Windows.Forms.Panel panel_3;
        private System.Windows.Forms.Label output_title;
        private System.Windows.Forms.PictureBox ui_holder_3;
        private System.Windows.Forms.PictureBox cmd_button;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label gpu_count;
        private System.Windows.Forms.Label gpu_text;
        private System.Windows.Forms.Label cpu_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel seperation_line_1;
        private System.Windows.Forms.Panel seperation_line_2;
        public System.Windows.Forms.TextBox extra_gpu_params_text;
        private RoundedPanel roundedPanel3;
        private System.Windows.Forms.Label enabled_text;
        private System.Windows.Forms.Label enabled_count;
        private System.Windows.Forms.Panel seperation_line_3;
        public System.Windows.Forms.TextBox set_box;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label performance_label;
    }
}

