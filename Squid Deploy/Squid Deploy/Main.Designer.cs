namespace Squid_Deploy
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optFolder2 = new System.Windows.Forms.RadioButton();
            this.optFolder1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optEnv3 = new System.Windows.Forms.RadioButton();
            this.optEnv2 = new System.Windows.Forms.RadioButton();
            this.optEnv1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Promote";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optFolder2);
            this.groupBox1.Controls.Add(this.optFolder1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folder";
            // 
            // optFolder2
            // 
            this.optFolder2.AutoSize = true;
            this.optFolder2.Location = new System.Drawing.Point(7, 44);
            this.optFolder2.Name = "optFolder2";
            this.optFolder2.Size = new System.Drawing.Size(47, 17);
            this.optFolder2.TabIndex = 1;
            this.optFolder2.Text = "tools";
            this.optFolder2.UseVisualStyleBackColor = true;
            // 
            // optFolder1
            // 
            this.optFolder1.AutoSize = true;
            this.optFolder1.Checked = true;
            this.optFolder1.Location = new System.Drawing.Point(7, 20);
            this.optFolder1.Name = "optFolder1";
            this.optFolder1.Size = new System.Drawing.Size(71, 17);
            this.optFolder1.TabIndex = 0;
            this.optFolder1.TabStop = true;
            this.optFolder1.Text = "resources";
            this.optFolder1.UseVisualStyleBackColor = true;
            this.optFolder1.CheckedChanged += new System.EventHandler(this.optFolder1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optEnv3);
            this.groupBox2.Controls.Add(this.optEnv2);
            this.groupBox2.Controls.Add(this.optEnv1);
            this.groupBox2.Location = new System.Drawing.Point(116, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Environment";
            // 
            // optEnv3
            // 
            this.optEnv3.AutoSize = true;
            this.optEnv3.Location = new System.Drawing.Point(7, 68);
            this.optEnv3.Name = "optEnv3";
            this.optEnv3.Size = new System.Drawing.Size(56, 17);
            this.optEnv3.TabIndex = 2;
            this.optEnv3.Text = "PROD";
            this.optEnv3.UseVisualStyleBackColor = true;
            // 
            // optEnv2
            // 
            this.optEnv2.AutoSize = true;
            this.optEnv2.Location = new System.Drawing.Point(7, 44);
            this.optEnv2.Name = "optEnv2";
            this.optEnv2.Size = new System.Drawing.Size(47, 17);
            this.optEnv2.TabIndex = 1;
            this.optEnv2.Text = "UAT";
            this.optEnv2.UseVisualStyleBackColor = true;
            // 
            // optEnv1
            // 
            this.optEnv1.AutoSize = true;
            this.optEnv1.Checked = true;
            this.optEnv1.Location = new System.Drawing.Point(7, 20);
            this.optEnv1.Name = "optEnv1";
            this.optEnv1.Size = new System.Drawing.Size(47, 17);
            this.optEnv1.TabIndex = 0;
            this.optEnv1.TabStop = true;
            this.optEnv1.Text = "DEV";
            this.optEnv1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 161);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Squid Deploy";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optFolder2;
        private System.Windows.Forms.RadioButton optFolder1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optEnv3;
        private System.Windows.Forms.RadioButton optEnv2;
        private System.Windows.Forms.RadioButton optEnv1;
    }
}

