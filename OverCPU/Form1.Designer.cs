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
            SuspendLayout();

            // 
            // lblCPU
            // 
            lblCPU.AutoSize = true;
            lblCPU.Location = new Point(100, 49);
            lblCPU.Name = "lblCPU";
            lblCPU.Size = new Size(38, 15);
            lblCPU.TabIndex = 0;
            lblCPU.Text = "CPU: 0%";

            // 
            // lblRAM
            // 
            lblRAM.AutoSize = true;
            lblRAM.Location = new Point(291, 50);
            lblRAM.Name = "lblRAM";
            lblRAM.Size = new Size(38, 15);
            lblRAM.TabIndex = 1;
            lblRAM.Text = "RAM: 0 MB";

            // 
            // lblDisk
            // 
            lblDisk.AutoSize = true;
            lblDisk.Location = new Point(491, 50);
            lblDisk.Name = "lblDisk";
            lblDisk.Size = new Size(38, 15);
            lblDisk.TabIndex = 2;
            lblDisk.Text = "Disco: 0%";

            // 
            // lblDiskRead
            // 
            lblDiskRead.AutoSize = true;
            lblDiskRead.Location = new Point(491, 70);
            lblDiskRead.Name = "lblDiskRead";
            lblDiskRead.Size = new Size(100, 15);
            lblDiskRead.TabIndex = 3;
            lblDiskRead.Text = "Lectura: 0 MB/s";

            // 
            // lblDiskWrite
            // 
            lblDiskWrite.AutoSize = true;
            lblDiskWrite.Location = new Point(491, 90);
            lblDiskWrite.Name = "lblDiskWrite";
            lblDiskWrite.Size = new Size(100, 15);
            lblDiskWrite.TabIndex = 4;
            lblDiskWrite.Text = "Escritura: 0 MB/s";

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisk);
            Controls.Add(lblRAM);
            Controls.Add(lblCPU);
            Controls.Add(lblDiskRead);
            Controls.Add(lblDiskWrite);
            Name = "Form1";
            Text = "Monitor de Recursos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCPU;
        private Label lblRAM;
        private Label lblDisk;
        private Label lblDiskRead;
        private Label lblDiskWrite;
        private System.Windows.Forms.Timer timer1;
    }
}
