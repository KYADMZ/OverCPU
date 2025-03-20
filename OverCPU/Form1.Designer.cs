namespace OverCPU
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblCPU = new Label();
            lblRAM = new Label();
            lblDisco = new Label();
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
            lblCPU.Text = "label1";
            // 
            // lblRAM
            // 
            lblRAM.AutoSize = true;
            lblRAM.Location = new Point(291, 50);
            lblRAM.Name = "lblRAM";
            lblRAM.Size = new Size(38, 15);
            lblRAM.TabIndex = 1;
            lblRAM.Text = "label2";
            // 
            // lblDisco
            // 
            lblDisco.AutoSize = true;
            lblDisco.Location = new Point(439, 60);
            lblDisco.Name = "lblDisco";
            lblDisco.Size = new Size(38, 15);
            lblDisco.TabIndex = 2;
            lblDisco.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisco);
            Controls.Add(lblRAM);
            Controls.Add(lblCPU);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCPU;
        private Label lblRAM;
        private Label lblDisco;
        private System.Windows.Forms.Timer timer1;
    }
}
