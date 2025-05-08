using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace OverCPU
{
    public partial class Form1 : Form
    {
        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;
        private PerformanceCounter diskCounter;
        private PerformanceCounter diskReadCounter;
        private PerformanceCounter diskWriteCounter;
        private PerformanceCounter progcpuCounter;
        private PerformanceCounter programCounter;
        public Form1()
        {
            InitializeComponent();
            InitializePerformanceCounters();
            string cpuName = GetHardwareInfo("wmic cpu get name");
            string diskName = GetHardwareInfo("wmic diskdrive get model");

            lblCPUN.Text = cpuName;
            lbldiskn.Text = diskName;

        }

        private void InitializePerformanceCounters()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            progcpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            programCounter = new PerformanceCounter("Memory", "Available MBytes");
            diskCounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
            diskReadCounter = new PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", "_Total");
            diskWriteCounter = new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "_Total");

            cpuCounter.NextValue();


            timer1.Interval = 1000; // Se actualiza cada segundo
            timer1.Tick += new EventHandler(UpdatePerformanceData);
            timer1.Start();
        }

        private void UpdatePerformanceData(object sender, EventArgs e)
        {
            float diskReadMB = diskReadCounter.NextValue() / (1024 * 1024); // Convertir bytes a MB
            float diskWriteMB = diskWriteCounter.NextValue() / (1024 * 1024); // Convertir bytes a MB
            float cpuUsage = progcpuCounter.NextValue();
            float ramUsage = 100 - ((programCounter.NextValue() / GetTotalRAM()) * 100);

            lblCPU.Text = $"CPU: {cpuCounter.NextValue():0.00}%";
            lblRAM.Text = $"RAM Disponible: {ramCounter.NextValue()} MB";
            lblDisk.Text = $"Disco: {diskCounter.NextValue():0.00}%";
            lblDiskRead.Text = $"Lectura Disco: {diskReadMB:0.00} MB/s";
            lblDiskWrite.Text = $"Escritura Disco: {diskWriteMB:0.00} MB/s";
            labelrampercent.Text = $"{ramUsage:0.00}%";
            lbltotalram.Text = $"RAM Total: {GetTotalRAM()} MB";
            progressBarcpu.Value = (int)Math.Min(cpuUsage, 100);
            progressBarRAM.Value = (int)Math.Min(ramUsage, 100);
            UpdateBatteryStatus();

        }

        private float GetTotalRAM()
        {
            return new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / (1024 * 1024);

        }

        static string GetHardwareInfo(string command)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/C {command}";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                string[] lines = output.Split('\n', StringSplitOptions.RemoveEmptyEntries);
                return lines.Length > 1 ? lines[1].Trim() : "No disponible";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
        private void UpdateBatteryStatus()
        {
            PowerStatus battery = SystemInformation.PowerStatus;

            float batteryLifePercent = battery.BatteryLifePercent * 100;
            string powerLineStatus = battery.PowerLineStatus.ToString(); // Online/Offline
            int batteryLifeRemaining = battery.BatteryLifeRemaining; // Seconds remaining

            string batteryStatus = $"Batería: {batteryLifePercent:0.00}%\n" +
                                   $"Fuente de poder: {powerLineStatus}\n" +
                                   $"Tiempo de vida Restante: {batteryLifeRemaining / 60} minutes";

            // Muestra esta información en un label por ejemplo
            label2.Text = batteryStatus;
        }

      
    }
}
