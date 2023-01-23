using OpenHardwareMonitor.Hardware;
using System;
using System.IO.Ports;

namespace Performance_Monitor_Serial_to_Arduino
{
    class Monitor
    {
        // Serial
        SerialPort serialPort = new SerialPort();

        // OpenHW
        Computer pc = new Computer()
        {
            GPUEnabled = true,
            CPUEnabled = true
        };

        // var
        float cpuTemp = 0, gpuTemp = 0;

        public void KirimStatistikHardware()       
        {
            foreach (var hw in pc.Hardware)
            {
                if (hw.HardwareType == HardwareType.GpuNvidia)
                {
                    hw.Update();
                    foreach (var sensor in hw.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                            gpuTemp = sensor.Value.GetValueOrDefault();

                    }
                }
                if (hw.HardwareType == HardwareType.CPU)
                {
                    hw.Update();
                    foreach (var sensor in hw.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                            cpuTemp = sensor.Value.GetValueOrDefault();
                    }
                }
            }
            try
            {
                serialPort.Write(cpuTemp + "*" + gpuTemp + "#");
            }
            catch(Exception ex)
            {
                // tidak ada
            }
        }

        public bool ConnectKeArduino(string portDipilih)
        {
            try
            {
                serialPort = new SerialPort(portDipilih, 9600, Parity.None, 8, StopBits.One);
                serialPort.Open();
                pc.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public void DisconnectDariArduino()
        {
            serialPort.Close();
            pc.Close();
        }
    }




}
