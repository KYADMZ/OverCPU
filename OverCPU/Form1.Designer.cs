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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            lblCPUN = new Label();
            lblCPU = new Label();
            progressBarcpu = new ProgressBar();
            panel2 = new Panel();
            lblRAM = new Label();
            labelrampercent = new Label();
            lbltotalram = new Label();
            progressBarRAM = new ProgressBar();
            panel3 = new Panel();
            lbldiskn = new Label();
            lblDisk = new Label();
            lblDiskRead = new Label();
            lblDiskWrite = new Label();
            panel4 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblCPUN);
            panel1.Controls.Add(lblCPU);
            panel1.Controls.Add(progressBarcpu);
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 110);
            panel1.TabIndex = 0;
            // 
            // lblCPUN
            // 
            lblCPUN.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCPUN.Location = new Point(10, 10);
            lblCPUN.Name = "lblCPUN";
            lblCPUN.Size = new Size(230, 20);
            lblCPUN.TabIndex = 0;
            lblCPUN.Text = "CPU";
            // 
            // lblCPU
            // 
            lblCPU.Location = new Point(10, 35);
            lblCPU.Name = "lblCPU";
            lblCPU.Size = new Size(200, 20);
            lblCPU.TabIndex = 1;
            lblCPU.Text = "Uso CPU: 0%";
            // 
            // progressBarcpu
            // 
            progressBarcpu.ForeColor = Color.SteelBlue;
            progressBarcpu.Location = new Point(10, 65);
            progressBarcpu.Name = "progressBarcpu";
            progressBarcpu.Size = new Size(220, 20);
            progressBarcpu.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblRAM);
            panel2.Controls.Add(labelrampercent);
            panel2.Controls.Add(lbltotalram);
            panel2.Controls.Add(progressBarRAM);
            panel2.Location = new Point(10, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 110);
            panel2.TabIndex = 1;
            // 
            // lblRAM
            // 
            lblRAM.Location = new Point(10, 10);
            lblRAM.Name = "lblRAM";
            lblRAM.Size = new Size(230, 20);
            lblRAM.TabIndex = 0;
            lblRAM.Text = "RAM Disponible: 0 MB";
            // 
            // labelrampercent
            // 
            labelrampercent.Location = new Point(10, 30);
            labelrampercent.Name = "labelrampercent";
            labelrampercent.Size = new Size(100, 20);
            labelrampercent.TabIndex = 1;
            labelrampercent.Text = "0.00% usada";
            // 
            // lbltotalram
            // 
            lbltotalram.Location = new Point(10, 50);
            lbltotalram.Name = "lbltotalram";
            lbltotalram.Size = new Size(200, 20);
            lbltotalram.TabIndex = 2;
            lbltotalram.Text = "RAM Total: 0 MB";
            // 
            // progressBarRAM
            // 
            progressBarRAM.ForeColor = Color.MediumPurple;
            progressBarRAM.Location = new Point(10, 75);
            progressBarRAM.Name = "progressBarRAM";
            progressBarRAM.Size = new Size(220, 20);
            progressBarRAM.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lbldiskn);
            panel3.Controls.Add(lblDisk);
            panel3.Controls.Add(lblDiskRead);
            panel3.Controls.Add(lblDiskWrite);
            panel3.Location = new Point(10, 250);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 110);
            panel3.TabIndex = 2;
            // 
            // lbldiskn
            // 
            lbldiskn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbldiskn.Location = new Point(10, 10);
            lbldiskn.Name = "lbldiskn";
            lbldiskn.Size = new Size(230, 20);
            lbldiskn.TabIndex = 0;
            lbldiskn.Text = "Disco";
            // 
            // lblDisk
            // 
            lblDisk.Location = new Point(10, 35);
            lblDisk.Name = "lblDisk";
            lblDisk.Size = new Size(200, 20);
            lblDisk.TabIndex = 1;
            lblDisk.Text = "Uso Disco: 0%";
            // 
            // lblDiskRead
            // 
            lblDiskRead.Location = new Point(10, 55);
            lblDiskRead.Name = "lblDiskRead";
            lblDiskRead.Size = new Size(200, 20);
            lblDiskRead.TabIndex = 2;
            lblDiskRead.Text = "Lectura: 0 MB/s";
            // 
            // lblDiskWrite
            // 
            lblDiskWrite.Location = new Point(10, 75);
            lblDiskWrite.Name = "lblDiskWrite";
            lblDiskWrite.Size = new Size(200, 20);
            lblDiskWrite.TabIndex = 3;
            lblDiskWrite.Text = "Escritura: 0 MB/s";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(10, 366);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 110);
            panel4.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(230, 20);
            label1.TabIndex = 0;
            label1.Text = "Batería";
            // 
            // label2
            // 
            label2.Location = new Point(10, 35);
            label2.Name = "label2";
            label2.Size = new Size(200, 62);
            label2.TabIndex = 1;
            label2.Text = "Status: 0%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 531);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Monitor de Recursos";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
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

        private Panel panel4;
        private Label label1;
        private Label label2;
    }
}