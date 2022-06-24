namespace Endassignment
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.CarTimer = new System.Windows.Forms.Timer(this.components);
            this.StartTimer = new System.Windows.Forms.Button();
            this.StopTimer = new System.Windows.Forms.Button();
            this.Kmeters = new System.Windows.Forms.Label();
            this.txtInputKm = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DatePick = new System.Windows.Forms.Label();
            this.Costlbl = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.Calbutton = new System.Windows.Forms.Button();
            this.TimeM = new System.Windows.Forms.Label();
            this.timeMinutes = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdriverN = new System.Windows.Forms.TextBox();
            this.txtdriverD = new System.Windows.Forms.TextBox();
            this.btdriverE = new System.Windows.Forms.Button();
            this.lblDriver = new System.Windows.Forms.Label();
            this.Driver = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.driverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Driver.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartTimer
            // 
            this.StartTimer.Location = new System.Drawing.Point(29, 20);
            this.StartTimer.Name = "StartTimer";
            this.StartTimer.Size = new System.Drawing.Size(60, 31);
            this.StartTimer.TabIndex = 0;
            this.StartTimer.Text = "Start";
            this.StartTimer.UseVisualStyleBackColor = true;
            this.StartTimer.Click += new System.EventHandler(this.StartTimer_Click);
            // 
            // StopTimer
            // 
            this.StopTimer.Location = new System.Drawing.Point(112, 21);
            this.StopTimer.Name = "StopTimer";
            this.StopTimer.Size = new System.Drawing.Size(67, 29);
            this.StopTimer.TabIndex = 1;
            this.StopTimer.Text = "Stop";
            this.StopTimer.UseVisualStyleBackColor = true;
            this.StopTimer.Click += new System.EventHandler(this.StopTimer_Click);
            // 
            // Kmeters
            // 
            this.Kmeters.AutoSize = true;
            this.Kmeters.Location = new System.Drawing.Point(26, 106);
            this.Kmeters.Name = "Kmeters";
            this.Kmeters.Size = new System.Drawing.Size(63, 16);
            this.Kmeters.TabIndex = 3;
            this.Kmeters.Text = "Enter KM:";
            // 
            // txtInputKm
            // 
            this.txtInputKm.Location = new System.Drawing.Point(95, 103);
            this.txtInputKm.Name = "txtInputKm";
            this.txtInputKm.Size = new System.Drawing.Size(100, 22);
            this.txtInputKm.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 133);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // DatePick
            // 
            this.DatePick.AutoSize = true;
            this.DatePick.Location = new System.Drawing.Point(26, 138);
            this.DatePick.Name = "DatePick";
            this.DatePick.Size = new System.Drawing.Size(39, 16);
            this.DatePick.TabIndex = 6;
            this.DatePick.Text = "Date:";
            // 
            // Costlbl
            // 
            this.Costlbl.AutoSize = true;
            this.Costlbl.Location = new System.Drawing.Point(135, 180);
            this.Costlbl.Name = "Costlbl";
            this.Costlbl.Size = new System.Drawing.Size(90, 16);
            this.Costlbl.TabIndex = 7;
            this.Costlbl.Text = "Cost of Travel";
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Location = new System.Drawing.Point(263, 180);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(0, 16);
            this.Cost.TabIndex = 8;
            // 
            // Calbutton
            // 
            this.Calbutton.Location = new System.Drawing.Point(29, 173);
            this.Calbutton.Name = "Calbutton";
            this.Calbutton.Size = new System.Drawing.Size(91, 23);
            this.Calbutton.TabIndex = 9;
            this.Calbutton.Text = "Calculate";
            this.Calbutton.UseVisualStyleBackColor = true;
            this.Calbutton.Click += new System.EventHandler(this.Calbutton_Click);
            // 
            // TimeM
            // 
            this.TimeM.AutoSize = true;
            this.TimeM.Location = new System.Drawing.Point(26, 70);
            this.TimeM.Name = "TimeM";
            this.TimeM.Size = new System.Drawing.Size(41, 16);
            this.TimeM.TabIndex = 10;
            this.TimeM.Text = "Time:";
            // 
            // timeMinutes
            // 
            this.timeMinutes.Location = new System.Drawing.Point(73, 67);
            this.timeMinutes.Name = "timeMinutes";
            this.timeMinutes.Size = new System.Drawing.Size(100, 22);
            this.timeMinutes.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Driver:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Taxi ID:";
            // 
            // txtdriverN
            // 
            this.txtdriverN.Location = new System.Drawing.Point(165, 58);
            this.txtdriverN.Name = "txtdriverN";
            this.txtdriverN.Size = new System.Drawing.Size(100, 22);
            this.txtdriverN.TabIndex = 16;
            // 
            // txtdriverD
            // 
            this.txtdriverD.Location = new System.Drawing.Point(165, 86);
            this.txtdriverD.Name = "txtdriverD";
            this.txtdriverD.Size = new System.Drawing.Size(100, 22);
            this.txtdriverD.TabIndex = 17;
            // 
            // btdriverE
            // 
            this.btdriverE.Location = new System.Drawing.Point(73, 123);
            this.btdriverE.Name = "btdriverE";
            this.btdriverE.Size = new System.Drawing.Size(75, 23);
            this.btdriverE.TabIndex = 18;
            this.btdriverE.Text = "Enter";
            this.btdriverE.UseVisualStyleBackColor = true;
            this.btdriverE.Click += new System.EventHandler(this.driverE_Click);
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Location = new System.Drawing.Point(172, 130);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(0, 16);
            this.lblDriver.TabIndex = 19;
            // 
            // Driver
            // 
            this.Driver.AccessibleName = "";
            this.Driver.Controls.Add(this.tabPage1);
            this.Driver.Controls.Add(this.tabPage2);
            this.Driver.Controls.Add(this.tabPage3);
            this.Driver.Location = new System.Drawing.Point(12, 12);
            this.Driver.Name = "Driver";
            this.Driver.SelectedIndex = 0;
            this.Driver.Size = new System.Drawing.Size(406, 288);
            this.Driver.TabIndex = 20;
            this.Driver.Tag = "";
            this.Driver.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Drivertwo_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblDriver);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtdriverD);
            this.tabPage1.Controls.Add(this.btdriverE);
            this.tabPage1.Controls.Add(this.txtdriverN);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(398, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Driver";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.StartTimer);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.StopTimer);
            this.tabPage2.Controls.Add(this.Cost);
            this.tabPage2.Controls.Add(this.TimeM);
            this.tabPage2.Controls.Add(this.Calbutton);
            this.tabPage2.Controls.Add(this.Costlbl);
            this.tabPage2.Controls.Add(this.timeMinutes);
            this.tabPage2.Controls.Add(this.Kmeters);
            this.tabPage2.Controls.Add(this.txtInputKm);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.DatePick);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(398, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calculation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(398, 259);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DB";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 41);
            this.button1.TabIndex = 21;
            this.button1.Text = "About Us";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "About Us --->";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.toolStripSeparator2,
            this.driverToolStripMenuItem,
            this.calculationToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 166);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.aboutUsToolStripMenuItem.Text = "About us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // driverToolStripMenuItem
            // 
            this.driverToolStripMenuItem.Name = "driverToolStripMenuItem";
            this.driverToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.driverToolStripMenuItem.Text = "Driver";
            this.driverToolStripMenuItem.Click += new System.EventHandler(this.driverToolStripMenuItem_Click);
            // 
            // calculationToolStripMenuItem
            // 
            this.calculationToolStripMenuItem.Name = "calculationToolStripMenuItem";
            this.calculationToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.calculationToolStripMenuItem.Text = "Calculation";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Taxi";
            this.notifyIcon1.Visible = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 328);
            this.Controls.Add(this.Driver);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Driver.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer CarTimer;
        private System.Windows.Forms.Button StartTimer;
        private System.Windows.Forms.Button StopTimer;
        private System.Windows.Forms.Label Kmeters;
        private System.Windows.Forms.TextBox txtInputKm;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DatePick;
        private System.Windows.Forms.Label Costlbl;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Button Calbutton;
        private System.Windows.Forms.Label TimeM;
        private System.Windows.Forms.TextBox timeMinutes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdriverN;
        private System.Windows.Forms.TextBox txtdriverD;
        private System.Windows.Forms.Button btdriverE;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.TabControl Driver;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}