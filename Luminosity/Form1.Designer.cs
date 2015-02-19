namespace Luminosity
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Red = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(12, 103);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(75, 23);
            this.Red.TabIndex = 0;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.Click += new System.EventHandler(this.red_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Luminosity";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Windows RGB LED controller using an Arduino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "By Niral Bhavsar";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(86, 70);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(117, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.NiralBhavsar.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.orange_button_LinkClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Green";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.green_button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(194, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Blue";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.blue_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "White";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.white_button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(103, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Violet";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.violet_button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(194, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Lime";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(102, 161);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Orange";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.lime_button_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Luminosity - Niral Bhavsar";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(244, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 20);
            this.button7.TabIndex = 11;
            this.button7.Text = "Hide";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.hide_button_Click);
            this.button7.MouseHover += new System.EventHandler(this.button7_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Red);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Luminosity - Niral Bhavsar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button7;
    }
}

