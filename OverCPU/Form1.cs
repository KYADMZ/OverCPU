using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace OverCPU

{
    public partial class Form1 : Form
    {
        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;

        public Form1()
        {
            InitializeComponent();
            InitializePerformanceCounters();
        }

        private void InitializePerformanceCounters()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            timer1.Interval = 1000; // Se actualiza cada segundo
            timer1.Tick += new EventHandler(UpdatePerformanceData);
            timer1.Start();
        }

        private void UpdatePerformanceData(object sender, EventArgs e)
        {
            lblCPU.Text = $"CPU: {cpuCounter.NextValue():0.00}%";
            lblRAM.Text = $"RAM Disponible: {ramCounter.NextValue()} MB";
        }
    }
}
