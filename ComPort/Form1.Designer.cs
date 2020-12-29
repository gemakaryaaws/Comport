namespace ComPort
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBPARITYBITS = new System.Windows.Forms.ComboBox();
            this.CBSTOPBITS = new System.Windows.Forms.ComboBox();
            this.CBDATABITS = new System.Windows.Forms.ComboBox();
            this.CBBAUDRATE = new System.Windows.Forms.ComboBox();
            this.CBCOMPORT = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTSENDDATA = new System.Windows.Forms.Button();
            this.BTCLOSE = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BTOPEN = new System.Windows.Forms.Button();
            this.TEXTBOXDATA = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CBPARITYBITS);
            this.groupBox1.Controls.Add(this.CBSTOPBITS);
            this.groupBox1.Controls.Add(this.CBDATABITS);
            this.groupBox1.Controls.Add(this.CBBAUDRATE);
            this.groupBox1.Controls.Add(this.CBCOMPORT);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication Control";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM PORT";
            // 
            // CBPARITYBITS
            // 
            this.CBPARITYBITS.FormattingEnabled = true;
            this.CBPARITYBITS.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.CBPARITYBITS.Location = new System.Drawing.Point(97, 131);
            this.CBPARITYBITS.Name = "CBPARITYBITS";
            this.CBPARITYBITS.Size = new System.Drawing.Size(121, 21);
            this.CBPARITYBITS.TabIndex = 4;
            this.CBPARITYBITS.Text = "None";
            // 
            // CBSTOPBITS
            // 
            this.CBSTOPBITS.FormattingEnabled = true;
            this.CBSTOPBITS.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.CBSTOPBITS.Location = new System.Drawing.Point(97, 104);
            this.CBSTOPBITS.Name = "CBSTOPBITS";
            this.CBSTOPBITS.Size = new System.Drawing.Size(121, 21);
            this.CBSTOPBITS.TabIndex = 3;
            this.CBSTOPBITS.Text = "One";
            // 
            // CBDATABITS
            // 
            this.CBDATABITS.FormattingEnabled = true;
            this.CBDATABITS.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9"});
            this.CBDATABITS.Location = new System.Drawing.Point(97, 77);
            this.CBDATABITS.Name = "CBDATABITS";
            this.CBDATABITS.Size = new System.Drawing.Size(121, 21);
            this.CBDATABITS.TabIndex = 2;
            this.CBDATABITS.Text = "8";
            // 
            // CBBAUDRATE
            // 
            this.CBBAUDRATE.FormattingEnabled = true;
            this.CBBAUDRATE.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.CBBAUDRATE.Location = new System.Drawing.Point(97, 50);
            this.CBBAUDRATE.Name = "CBBAUDRATE";
            this.CBBAUDRATE.Size = new System.Drawing.Size(121, 21);
            this.CBBAUDRATE.TabIndex = 1;
            this.CBBAUDRATE.Text = "9600";
            this.CBBAUDRATE.SelectedIndexChanged += new System.EventHandler(this.CBBAUDRATE_SelectedIndexChanged);
            // 
            // CBCOMPORT
            // 
            this.CBCOMPORT.FormattingEnabled = true;
            this.CBCOMPORT.Location = new System.Drawing.Point(97, 23);
            this.CBCOMPORT.Name = "CBCOMPORT";
            this.CBCOMPORT.Size = new System.Drawing.Size(121, 21);
            this.CBCOMPORT.TabIndex = 0;
            this.CBCOMPORT.SelectedIndexChanged += new System.EventHandler(this.CBCOMPORT_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTSENDDATA);
            this.groupBox2.Controls.Add(this.BTCLOSE);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.BTOPEN);
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // BTSENDDATA
            // 
            this.BTSENDDATA.Location = new System.Drawing.Point(153, 19);
            this.BTSENDDATA.Name = "BTSENDDATA";
            this.BTSENDDATA.Size = new System.Drawing.Size(60, 64);
            this.BTSENDDATA.TabIndex = 4;
            this.BTSENDDATA.Text = "SEND DATA";
            this.BTSENDDATA.UseVisualStyleBackColor = true;
            this.BTSENDDATA.Click += new System.EventHandler(this.BTSENDDATA_Click);
            // 
            // BTCLOSE
            // 
            this.BTCLOSE.Location = new System.Drawing.Point(87, 19);
            this.BTCLOSE.Name = "BTCLOSE";
            this.BTCLOSE.Size = new System.Drawing.Size(60, 23);
            this.BTCLOSE.TabIndex = 3;
            this.BTCLOSE.Text = "CLOSE";
            this.BTCLOSE.UseVisualStyleBackColor = true;
            this.BTCLOSE.Click += new System.EventHandler(this.BTCLOSE_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 57);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(126, 26);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // BTOPEN
            // 
            this.BTOPEN.Location = new System.Drawing.Point(21, 19);
            this.BTOPEN.Name = "BTOPEN";
            this.BTOPEN.Size = new System.Drawing.Size(60, 23);
            this.BTOPEN.TabIndex = 0;
            this.BTOPEN.Text = "OPEN";
            this.BTOPEN.UseVisualStyleBackColor = true;
            this.BTOPEN.Click += new System.EventHandler(this.button1_Click);
            // 
            // TEXTBOXDATA
            // 
            this.TEXTBOXDATA.Location = new System.Drawing.Point(247, 19);
            this.TEXTBOXDATA.Multiline = true;
            this.TEXTBOXDATA.Name = "TEXTBOXDATA";
            this.TEXTBOXDATA.Size = new System.Drawing.Size(197, 261);
            this.TEXTBOXDATA.TabIndex = 2;
            this.TEXTBOXDATA.Text = "e";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 284);
            this.Controls.Add(this.TEXTBOXDATA);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "C# Serial Communication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBPARITYBITS;
        private System.Windows.Forms.ComboBox CBSTOPBITS;
        private System.Windows.Forms.ComboBox CBDATABITS;
        private System.Windows.Forms.ComboBox CBBAUDRATE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTSENDDATA;
        private System.Windows.Forms.Button BTCLOSE;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BTOPEN;
        private System.Windows.Forms.TextBox TEXTBOXDATA;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox CBCOMPORT;
    }
}

