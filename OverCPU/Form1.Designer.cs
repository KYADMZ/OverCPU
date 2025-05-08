using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace OverCPU
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCPUN = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.progressBarcpu = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltotalram = new System.Windows.Forms.Label();
            this.labelrampercent = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.progressBarRAM = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbldiskn = new System.Windows.Forms.Label();
            this.lblDisk = new System.Windows.Forms.Label();
            this.lblDiskRead = new System.Windows.Forms.Label();
            this.lblDiskWrite = new System.Windows.Forms.Label();

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 370);
            this.Text = "Monitor de Recursos";
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Size = new System.Drawing.Size(250, 110);
            this.panel1.Controls.Add(this.lblCPUN);
            this.panel1.Controls.Add(this.lblCPU);
            this.panel1.Controls.Add(this.progressBarcpu);

            // 
            // lblCPUN
            // 
            this.lblCPUN.Text = "CPU";
            this.lblCPUN.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblCPUN.Location = new System.Drawing.Point(10, 10);
            this.lblCPUN.Size = new System.Drawing.Size(230, 20);

            // 
            // lblCPU
            // 
            this.lblCPU.Text = "Uso CPU: 0%";
            this.lblCPU.Location = new System.Drawing.Point(10, 35);
            this.lblCPU.Size = new System.Drawing.Size(200, 20);

            // 
            // progressBarcpu
            // 
            this.progressBarcpu.Location = new System.Drawing.Point(10, 65);
            this.progressBarcpu.Size = new System.Drawing.Size(220, 20);
            this.progressBarcpu.ForeColor = System.Drawing.Color.SteelBlue;

            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(10, 130);
            this.panel2.Size = new System.Drawing.Size(250, 110);
            this.panel2.Controls.Add(this.lblRAM);
            this.panel2.Controls.Add(this.labelrampercent);
            this.panel2.Controls.Add(this.lbltotalram);
            this.panel2.Controls.Add(this.progressBarRAM);

            // 
            // lblRAM
            // 
            this.lblRAM.Text = "RAM Disponible: 0 MB";
            this.lblRAM.Location = new System.Drawing.Point(10, 10);
            this.lblRAM.Size = new System.Drawing.Size(230, 20);

            // 
            // labelrampercent
            // 
            this.labelrampercent.Text = "0.00% usada";
            this.labelrampercent.Location = new System.Drawing.Point(10, 30);
            this.labelrampercent.Size = new System.Drawing.Size(100, 20);

            // 
            // lbltotalram
            // 
            this.lbltotalram.Text = "RAM Total: 0 MB";
            this.lbltotalram.Location = new System.Drawing.Point(10, 50);
            this.lbltotalram.Size = new System.Drawing.Size(200, 20);

            // 
            // progressBarRAM
            // 
            this.progressBarRAM.Location = new System.Drawing.Point(10, 75);
            this.progressBarRAM.Size = new System.Drawing.Size(220, 20);
            this.progressBarRAM.ForeColor = System.Drawing.Color.MediumPurple;

            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(10, 250);
            this.panel3.Size = new System.Drawing.Size(250, 110);
            this.panel3.Controls.Add(this.lbldiskn);
            this.panel3.Controls.Add(this.lblDisk);
            this.panel3.Controls.Add(this.lblDiskRead);
            this.panel3.Controls.Add(this.lblDiskWrite);

            // 
            // lbldiskn
            // 
            this.lbldiskn.Text = "Disco";
            this.lbldiskn.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            this.lbldiskn.Location = new System.Drawing.Point(10, 10);
            this.lbldiskn.Size = new System.Drawing.Size(230, 20);

            // 
            // lblDisk
            // 
            this.lblDisk.Text = "Uso Disco: 0%";
            this.lblDisk.Location = new System.Drawing.Point(10, 35);
            this.lblDisk.Size = new System.Drawing.Size(200, 20);

            // 
            // lblDiskRead
            // 
            this.lblDiskRead.Text = "Lectura: 0 MB/s";
            this.lblDiskRead.Location = new System.Drawing.Point(10, 55);
            this.lblDiskRead.Size = new System.Drawing.Size(200, 20);

            // 
            // lblDiskWrite
            // 
            this.lblDiskWrite.Text = "Escritura: 0 MB/s";
            this.lblDiskWrite.Location = new System.Drawing.Point(10, 75);
            this.lblDiskWrite.Size = new System.Drawing.Size(200, 20);

            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // Add panels to Form
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCPUN;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.ProgressBar progressBarcpu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbltotalram;
        private System.Windows.Forms.Label labelrampercent;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.ProgressBar progressBarRAM;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbldiskn;
        private System.Windows.Forms.Label lblDisk;
        private System.Windows.Forms.Label lblDiskRead;
        private System.Windows.Forms.Label lblDiskWrite;

        // You'll need to add the timer1_Tick event handler in your main code
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Your update logic here
        }
    }
}