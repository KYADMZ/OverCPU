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

        public Form1()
        {
            InitializeComponent();
            InitializePerformanceCounters();
        }

        private void InitializePerformanceCounters()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            diskCounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
            diskReadCounter = new PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", "_Total");
            diskWriteCounter = new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "_Total");

            timer1.Interval = 1000; // Se actualiza cada segundo
            timer1.Tick += new EventHandler(UpdatePerformanceData);
            timer1.Start();
        }

        private void UpdatePerformanceData(object sender, EventArgs e)
        {
            float diskReadMB = diskReadCounter.NextValue() / (1024 * 1024); // Convertir bytes a MB
            float diskWriteMB = diskWriteCounter.NextValue() / (1024 * 1024); // Convertir bytes a MB

            lblCPU.Text = $"CPU: {cpuCounter.NextValue():0.00}%";
            lblRAM.Text = $"RAM Disponible: {ramCounter.NextValue()} MB";
            lblDisk.Text = $"Disco: {diskCounter.NextValue():0.00}%";
            lblDiskRead.Text = $"Lectura Disco: {diskReadMB:0.00} MB/s";
            lblDiskWrite.Text = $"Escritura Disco: {diskWriteMB:0.00} MB/s";
        }
    }
}
