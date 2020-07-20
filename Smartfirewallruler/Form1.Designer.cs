namespace Smartfirewallruler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblFirewallStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cmdRules = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddFilter = new System.Windows.Forms.Button();
            this.cmdPackets = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdDirection = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdAction = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Statuspane = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IPS = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.urlbox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Statuspane.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirewallStatus
            // 
            this.lblFirewallStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirewallStatus.AutoSize = true;
            this.lblFirewallStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblFirewallStatus.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirewallStatus.ForeColor = System.Drawing.Color.White;
            this.lblFirewallStatus.Location = new System.Drawing.Point(308, 0);
            this.lblFirewallStatus.Name = "lblFirewallStatus";
            this.lblFirewallStatus.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblFirewallStatus.Size = new System.Drawing.Size(159, 25);
            this.lblFirewallStatus.TabIndex = 0;
            this.lblFirewallStatus.Text = "Firewall Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.cmdRules);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(23, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 83);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Rule";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(408, 30);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.But_Remove_Rule);
            // 
            // cmdRules
            // 
            this.cmdRules.FormattingEnabled = true;
            this.cmdRules.Location = new System.Drawing.Point(67, 32);
            this.cmdRules.Name = "cmdRules";
            this.cmdRules.Size = new System.Drawing.Size(324, 22);
            this.cmdRules.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Rules :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnAddFilter);
            this.groupBox1.Controls.Add(this.cmdPackets);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmdDirection);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmdAction);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 116);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Rule";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(190, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 38);
            this.panel1.TabIndex = 12;
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.Location = new System.Drawing.Point(216, 68);
            this.btnAddFilter.Name = "btnAddFilter";
            this.btnAddFilter.Size = new System.Drawing.Size(75, 23);
            this.btnAddFilter.TabIndex = 11;
            this.btnAddFilter.Text = "Add Filter";
            this.btnAddFilter.UseVisualStyleBackColor = true;
            this.btnAddFilter.Click += new System.EventHandler(this.But_AddFilter_Click);
            // 
            // cmdPackets
            // 
            this.cmdPackets.FormattingEnabled = true;
            this.cmdPackets.Items.AddRange(new object[] {
            "ICMP",
            "HTTP",
            "HTTPS"});
            this.cmdPackets.Location = new System.Drawing.Point(64, 67);
            this.cmdPackets.Name = "cmdPackets";
            this.cmdPackets.Size = new System.Drawing.Size(121, 22);
            this.cmdPackets.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Packets:";
            // 
            // cmdDirection
            // 
            this.cmdDirection.FormattingEnabled = true;
            this.cmdDirection.Items.AddRange(new object[] {
            "InBound",
            "OutBound"});
            this.cmdDirection.Location = new System.Drawing.Point(675, 35);
            this.cmdDirection.Name = "cmdDirection";
            this.cmdDirection.Size = new System.Drawing.Size(102, 22);
            this.cmdDirection.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direction:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(479, 33);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(133, 20);
            this.txtIP.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Target Ip:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(254, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // cmdAction
            // 
            this.cmdAction.FormattingEnabled = true;
            this.cmdAction.Items.AddRange(new object[] {
            "Allow",
            "Block"});
            this.cmdAction.Location = new System.Drawing.Point(64, 32);
            this.cmdAction.Name = "cmdAction";
            this.cmdAction.Size = new System.Drawing.Size(121, 22);
            this.cmdAction.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Action:";
            // 
            // Statuspane
            // 
            this.Statuspane.BackColor = System.Drawing.Color.Red;
            this.Statuspane.Controls.Add(this.lblFirewallStatus);
            this.Statuspane.Location = new System.Drawing.Point(23, 12);
            this.Statuspane.Name = "Statuspane";
            this.Statuspane.Size = new System.Drawing.Size(783, 30);
            this.Statuspane.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.IPS);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.urlbox);
            this.groupBox3.Location = new System.Drawing.Point(23, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(783, 103);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Find ip";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 14);
            this.label7.TabIndex = 3;
            this.label7.Text = "URL";
            // 
            // IPS
            // 
            this.IPS.AutoSize = true;
            this.IPS.Location = new System.Drawing.Point(503, 16);
            this.IPS.Name = "IPS";
            this.IPS.Size = new System.Drawing.Size(0, 14);
            this.IPS.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.But_Find_Ip);
            // 
            // urlbox
            // 
            this.urlbox.Location = new System.Drawing.Point(67, 19);
            this.urlbox.Name = "urlbox";
            this.urlbox.Size = new System.Drawing.Size(324, 20);
            this.urlbox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(817, 405);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Statuspane);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.Text = "Smart Firewall Ruler";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Statuspane.ResumeLayout(false);
            this.Statuspane.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFirewallStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cmdRules;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddFilter;
        private System.Windows.Forms.ComboBox cmdPackets;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmdDirection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmdAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Statuspane;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox urlbox;
        private System.Windows.Forms.Label IPS;
        private System.Windows.Forms.Label label7;
    }
}

