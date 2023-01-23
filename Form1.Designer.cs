
namespace Performance_Monitor_Serial_to_Arduino
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
            this.labelSerial = new System.Windows.Forms.Label();
            this.serialComboBox = new System.Windows.Forms.ComboBox();
            this.tombolRefresh = new System.Windows.Forms.Button();
            this.tombolPilih = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.intervalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.autoConnectCheckbox = new System.Windows.Forms.CheckBox();
            this.minimalCheckBox = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // labelSerial
            // 
            this.labelSerial.AutoSize = true;
            this.labelSerial.Location = new System.Drawing.Point(12, 22);
            this.labelSerial.Name = "labelSerial";
            this.labelSerial.Size = new System.Drawing.Size(33, 13);
            this.labelSerial.TabIndex = 0;
            this.labelSerial.Text = "Serial";
            // 
            // serialComboBox
            // 
            this.serialComboBox.FormattingEnabled = true;
            this.serialComboBox.Location = new System.Drawing.Point(15, 38);
            this.serialComboBox.Name = "serialComboBox";
            this.serialComboBox.Size = new System.Drawing.Size(121, 21);
            this.serialComboBox.TabIndex = 1;
            // 
            // tombolRefresh
            // 
            this.tombolRefresh.Location = new System.Drawing.Point(142, 37);
            this.tombolRefresh.Name = "tombolRefresh";
            this.tombolRefresh.Size = new System.Drawing.Size(75, 23);
            this.tombolRefresh.TabIndex = 2;
            this.tombolRefresh.Text = "Refresh";
            this.tombolRefresh.UseVisualStyleBackColor = true;
            this.tombolRefresh.Click += new System.EventHandler(this.tombolRefresh_Click);
            // 
            // tombolPilih
            // 
            this.tombolPilih.Location = new System.Drawing.Point(69, 191);
            this.tombolPilih.Name = "tombolPilih";
            this.tombolPilih.Size = new System.Drawing.Size(94, 39);
            this.tombolPilih.TabIndex = 3;
            this.tombolPilih.Text = "Connect";
            this.tombolPilih.UseVisualStyleBackColor = true;
            this.tombolPilih.Click += new System.EventHandler(this.tombolPilih_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // intervalTextBox
            // 
            this.intervalTextBox.Location = new System.Drawing.Point(15, 88);
            this.intervalTextBox.MaxLength = 4;
            this.intervalTextBox.Name = "intervalTextBox";
            this.intervalTextBox.Size = new System.Drawing.Size(121, 20);
            this.intervalTextBox.TabIndex = 4;
            this.intervalTextBox.Text = "3000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Interval (detik)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // autoConnectCheckbox
            // 
            this.autoConnectCheckbox.AutoSize = true;
            this.autoConnectCheckbox.Location = new System.Drawing.Point(15, 121);
            this.autoConnectCheckbox.Name = "autoConnectCheckbox";
            this.autoConnectCheckbox.Size = new System.Drawing.Size(91, 17);
            this.autoConnectCheckbox.TabIndex = 7;
            this.autoConnectCheckbox.Text = "Auto Connect";
            this.autoConnectCheckbox.UseVisualStyleBackColor = true;
            // 
            // minimalCheckBox
            // 
            this.minimalCheckBox.AutoSize = true;
            this.minimalCheckBox.Location = new System.Drawing.Point(15, 144);
            this.minimalCheckBox.Name = "minimalCheckBox";
            this.minimalCheckBox.Size = new System.Drawing.Size(98, 17);
            this.minimalCheckBox.TabIndex = 8;
            this.minimalCheckBox.Text = "Minimal Startup";
            this.minimalCheckBox.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 242);
            this.Controls.Add(this.minimalCheckBox);
            this.Controls.Add(this.autoConnectCheckbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intervalTextBox);
            this.Controls.Add(this.tombolPilih);
            this.Controls.Add(this.tombolRefresh);
            this.Controls.Add(this.serialComboBox);
            this.Controls.Add(this.labelSerial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Serial to Arduino Permon";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSerial;
        private System.Windows.Forms.ComboBox serialComboBox;
        private System.Windows.Forms.Button tombolRefresh;
        private System.Windows.Forms.Button tombolPilih;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox intervalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox autoConnectCheckbox;
        private System.Windows.Forms.CheckBox minimalCheckBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

