namespace OverCPU
{
    partial class Form1
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
            lblCPU = new Label();
            lblRAM = new Label();
            lblDisk = new Label();
            lblDiskRead = new Label();
            lblDiskWrite = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            lblCPUN = new Label();
            progressBarcpu = new ProgressBar();
            panel2 = new Panel();
            lbltotalram = new Label();
            labelrampercent = new Label();
            progressBarRAM = new ProgressBar();
            panel3 = new Panel();
            label1 = new Label();
            lbldiskn = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblCPU
            // 
            lblCPU.AutoSize = true;
            lblCPU.Location = new Point(19, 25);
            lblCPU.Name = "lblCPU";
            lblCPU.Size = new Size(52, 15);
            lblCPU.TabIndex = 0;
            lblCPU.Text = "CPU: 0%";
            // 
            // lblRAM
            // 
            lblRAM.AutoSize = true;
            lblRAM.Location = new Point(19, 10);
            lblRAM.Name = "lblRAM";
            lblRAM.Size = new Size(66, 15);
            lblRAM.TabIndex = 1;
            lblRAM.Text = "RAM: 0 MB";
            // 
            // lblDisk
            // 
            lblDisk.AutoSize = true;
            lblDisk.Location = new Point(20, 10);
            lblDisk.Name = "lblDisk";
            lblDisk.Size = new Size(58, 15);
            lblDisk.TabIndex = 2;
            lblDisk.Text = "Disco: 0%";
            // 
            // lblDiskRead
            // 
            lblDiskRead.AutoSize = true;
            lblDiskRead.Location = new Point(20, 25);
            lblDiskRead.Name = "lblDiskRead";
            lblDiskRead.Size = new Size(89, 15);
            lblDiskRead.TabIndex = 3;
            lblDiskRead.Text = "Lectura: 0 MB/s";
            // 
            // lblDiskWrite
            // 
            lblDiskWrite.AutoSize = true;
            lblDiskWrite.Location = new Point(20, 40);
            lblDiskWrite.Name = "lblDiskWrite";
            lblDiskWrite.Size = new Size(95, 15);
            lblDiskWrite.TabIndex = 4;
            lblDiskWrite.Text = "Escritura: 0 MB/s";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblCPUN);
            panel1.Controls.Add(progressBarcpu);
            panel1.Controls.Add(lblCPU);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 98);
            panel1.TabIndex = 5;
            // 
            // lblCPUN
            // 
            lblCPUN.AutoSize = true;
            lblCPUN.Location = new Point(3, 0);
            lblCPUN.Name = "lblCPUN";
            lblCPUN.Size = new Size(27, 15);
            lblCPUN.TabIndex = 2;
            lblCPUN.Text = "cpu";
            // 
            // progressBarcpu
            // 
            progressBarcpu.Location = new Point(19, 49);
            progressBarcpu.Name = "progressBarcpu";
            progressBarcpu.Size = new Size(174, 23);
            progressBarcpu.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lbltotalram);
            panel2.Controls.Add(labelrampercent);
            panel2.Controls.Add(progressBarRAM);
            panel2.Controls.Add(lblRAM);
            panel2.Location = new Point(255, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 98);
            panel2.TabIndex = 6;
            // 
            // lbltotalram
            // 
            lbltotalram.AutoSize = true;
            lbltotalram.Location = new Point(19, 30);
            lbltotalram.Name = "lbltotalram";
            lbltotalram.Size = new Size(33, 15);
            lbltotalram.TabIndex = 4;
            lbltotalram.Text = "RAM";
            // 
            // labelrampercent
            // 
            labelrampercent.AutoSize = true;
            labelrampercent.Location = new Point(176, 10);
            labelrampercent.Name = "labelrampercent";
            labelrampercent.Size = new Size(38, 15);
            labelrampercent.TabIndex = 3;
            labelrampercent.Text = "0.00%";
            // 
            // progressBarRAM
            // 
            progressBarRAM.Location = new Point(19, 49);
            progressBarRAM.Name = "progressBarRAM";
            progressBarRAM.Size = new Size(181, 23);
            progressBarRAM.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lbldiskn);
            panel3.Controls.Add(lblDisk);
            panel3.Controls.Add(lblDiskRead);
            panel3.Controls.Add(lblDiskWrite);
            panel3.Location = new Point(491, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(264, 98);
            panel3.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(20, 60);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 6;
            label1.Text = "Modelo:";
            // 
            // lbldiskn
            // 
            lbldiskn.AutoSize = true;
            lbldiskn.Location = new Point(79, 60);
            lbldiskn.Name = "lbldiskn";
            lbldiskn.Size = new Size(28, 15);
            lbldiskn.TabIndex = 5;
            lbldiskn.Text = "disk";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Monitor de Recursos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCPU;
        private Label lblRAM;
        private Label lblDisk;
        private Label lblDiskRead;
        private Label lblDiskWrite;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ProgressBar progressBarcpu;
        private ProgressBar progressBarRAM;
        private Label labelrampercent;
        private Label lbltotalram;
        private Label lblCPUN;
        private Label lbldiskn;
        private Label label1;
    }
}
