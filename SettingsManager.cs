namespace Performance_Monitor_Serial_to_Arduino
{
    class SettingsManager
    {
        public void SimpanConfigurasi(bool isAutoConnect, bool isMinimal, string COM)
        {
            Properties.Settings.Default.autoConnect = isAutoConnect;
            Properties.Settings.Default.minimal = isMinimal;
            Properties.Settings.Default.comPort = COM;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
        }
    }
}
