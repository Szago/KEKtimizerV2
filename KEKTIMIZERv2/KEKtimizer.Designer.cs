namespace KEKTIMIZERv2
{
    partial class KEKtimizer
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KEKtimizer));
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.selectedPathTextBox = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(230, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "KEKTIMIZE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 398);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(600, 31);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(224, 28);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Create Registry Backup";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(12, 46);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(175, 28);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Optimize Registry";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(12, 80);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(250, 28);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Optimize Clocks and Ticks";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(12, 114);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(238, 28);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Optimize Power Scheme";
            this.checkBox4.UseVisualStyleBackColor = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // selectedPathTextBox
            // 
            this.selectedPathTextBox.Location = new System.Drawing.Point(242, 16);
            this.selectedPathTextBox.Name = "selectedPathTextBox";
            this.selectedPathTextBox.ReadOnly = true;
            this.selectedPathTextBox.Size = new System.Drawing.Size(192, 20);
            this.selectedPathTextBox.TabIndex = 7;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackColor = System.Drawing.Color.Transparent;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox5.ForeColor = System.Drawing.Color.White;
            this.checkBox5.Location = new System.Drawing.Point(12, 148);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(257, 28);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "Disable Windows Defender";
            this.checkBox5.UseVisualStyleBackColor = false;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.BackColor = System.Drawing.Color.Transparent;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox6.ForeColor = System.Drawing.Color.White;
            this.checkBox6.Location = new System.Drawing.Point(12, 182);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(267, 28);
            this.checkBox6.TabIndex = 9;
            this.checkBox6.Text = "Remove \"Activate Windows\"";
            this.checkBox6.UseVisualStyleBackColor = false;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.BackColor = System.Drawing.Color.Transparent;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox7.ForeColor = System.Drawing.Color.White;
            this.checkBox7.Location = new System.Drawing.Point(12, 216);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(288, 28);
            this.checkBox7.TabIndex = 10;
            this.checkBox7.Text = "Deactivate Mouse Acceleration";
            this.checkBox7.UseVisualStyleBackColor = false;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.BackColor = System.Drawing.Color.Transparent;
            this.checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox8.ForeColor = System.Drawing.Color.White;
            this.checkBox8.Location = new System.Drawing.Point(12, 250);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(302, 28);
            this.checkBox8.TabIndex = 11;
            this.checkBox8.Text = "Disable Windows Search bullshit";
            this.checkBox8.UseVisualStyleBackColor = false;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(12, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 55);
            this.button3.TabIndex = 12;
            this.button3.Text = "Select Important";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(90, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 55);
            this.button4.TabIndex = 13;
            this.button4.Text = "Uncheck All";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.BackColor = System.Drawing.Color.Transparent;
            this.checkBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox9.ForeColor = System.Drawing.Color.White;
            this.checkBox9.Location = new System.Drawing.Point(12, 284);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(302, 28);
            this.checkBox9.TabIndex = 14;
            this.checkBox9.Text = "Disable Scheduled Maintenance";
            this.checkBox9.UseVisualStyleBackColor = false;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.BackColor = System.Drawing.Color.Transparent;
            this.checkBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox10.ForeColor = System.Drawing.Color.White;
            this.checkBox10.Location = new System.Drawing.Point(320, 80);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(114, 28);
            this.checkBox10.TabIndex = 15;
            this.checkBox10.Text = "GodMode";
            this.checkBox10.UseVisualStyleBackColor = false;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.BackColor = System.Drawing.Color.Transparent;
            this.checkBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox11.ForeColor = System.Drawing.Color.White;
            this.checkBox11.Location = new System.Drawing.Point(320, 46);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(284, 28);
            this.checkBox11.TabIndex = 16;
            this.checkBox11.Text = "Disable Windows Auto-Update";
            this.checkBox11.UseVisualStyleBackColor = false;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // KEKtimizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.selectedPathTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KEKtimizer";
            this.Text = "KEKtimizer";
            this.Load += new System.EventHandler(this.KEKtimizer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox selectedPathTextBox;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
    }
}

