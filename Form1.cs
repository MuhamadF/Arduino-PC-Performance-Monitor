using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Performance_Monitor_Serial_to_Arduino
{
    public partial class Form1 : Form
    {
        string portDipilih;
        bool tersambung = false,
             isAutoConnect = false,
             minimalStartup = false;

        // interval default 3 detik
        int interval = 3000;

        Monitor monitor = new Monitor();
        SettingsManager settings = new SettingsManager();

        public Form1()
        {
            InitializeComponent();

            isAutoConnect = Properties.Settings.Default.autoConnect;
            minimalStartup = Properties.Settings.Default.minimal;
            if(minimalStartup)
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                minimalCheckBox.Checked = true;
                this.Hide();
                notifyIcon1.Visible = true;
            } else
            {
                this.WindowState = FormWindowState.Normal;
                TampilPortTersedia();
                minimalCheckBox.Checked = false;
            }
            timer.Interval = interval;

            if(isAutoConnect)
            {
                try
                {
                    tersambung = monitor.ConnectKeArduino(Properties.Settings.Default.comPort);
                    timer.Start();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Set PORT kembali");
                }
            }
        }

        public void TampilPortTersedia()
        {
            serialComboBox.Items.Clear();
            foreach(string port in SerialPort.GetPortNames())
            {
                serialComboBox.Items.Add(port);
                serialComboBox.SelectedItem = port;
                portDipilih = port;
            }
        }

        private void tombolRefresh_Click(object sender, EventArgs e)
        {
            TampilPortTersedia();
        }

        private void tombolPilih_Click(object sender, EventArgs e)
        {
            if(!tersambung) {
                portDipilih = serialComboBox.GetItemText(serialComboBox.SelectedItem);
                settings.SimpanConfigurasi(Properties.Settings.Default.autoConnect, Properties.Settings.Default.minimal, portDipilih);
                tersambung = monitor.ConnectKeArduino(Properties.Settings.Default.comPort);

                if (tersambung)
                {
                    tombolPilih.Text = "Disconnect";
                    MessageBox.Show("Berhasil tersambung ke Arduino");
                    timer.Start();
                } else
                {
                    MessageBox.Show("GAGAL");
                }
            }
            else
            {
                monitor.DisconnectDariArduino();
                tombolPilih.Text = "Connect";
                tersambung = false;
                timer.Stop();
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
            this.ShowInTaskbar = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                if (minimalStartup)
                {
                    this.ShowInTaskbar = false;
                    notifyIcon1.Visible = true;
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            monitor.KirimStatistikHardware();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            interval = Int32.Parse(intervalTextBox.Text);
            timer.Interval = interval;
            settings.SimpanConfigurasi(autoConnectCheckbox.Checked, minimalCheckBox.Checked, portDipilih.ToString());
            MessageBox.Show("Pengaturan Berhasil Disimpan");
            Console.WriteLine(Properties.Settings.Default.minimal);
            Console.WriteLine(Properties.Settings.Default.autoConnect);
            Console.WriteLine(Properties.Settings.Default.comPort);

        }
    }

}
