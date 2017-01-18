namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      this.btnManual = new System.Windows.Forms.Button();
      this.imageDisplay = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tmrCapture = new System.Windows.Forms.Timer(this.components);
      this.btnAutomatic = new System.Windows.Forms.Button();
      this.txtStatus = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).BeginInit();
      this.SuspendLayout();
      // 
      // btnManual
      // 
      this.btnManual.Location = new System.Drawing.Point(27, 33);
      this.btnManual.Name = "btnManual";
      this.btnManual.Size = new System.Drawing.Size(128, 37);
      this.btnManual.TabIndex = 0;
      this.btnManual.Text = "Manual Capture";
      this.btnManual.UseVisualStyleBackColor = true;
      this.btnManual.Click += new System.EventHandler(this.button1_Click);
      // 
      // imageDisplay
      // 
      this.imageDisplay.BackColor = System.Drawing.SystemColors.ControlDark;
      this.imageDisplay.Location = new System.Drawing.Point(27, 106);
      this.imageDisplay.Name = "imageDisplay";
      this.imageDisplay.Size = new System.Drawing.Size(394, 211);
      this.imageDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.imageDisplay.TabIndex = 1;
      this.imageDisplay.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(24, 84);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(101, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Last capture screen";
      // 
      // tmrCapture
      // 
      this.tmrCapture.Interval = 3600000;
      this.tmrCapture.Tick += new System.EventHandler(this.tmrCapture_Tick);
      // 
      // btnAutomatic
      // 
      this.btnAutomatic.Location = new System.Drawing.Point(171, 33);
      this.btnAutomatic.Name = "btnAutomatic";
      this.btnAutomatic.Size = new System.Drawing.Size(128, 37);
      this.btnAutomatic.TabIndex = 4;
      this.btnAutomatic.Text = "Start Automatic Capture ";
      this.btnAutomatic.UseVisualStyleBackColor = true;
      this.btnAutomatic.Click += new System.EventHandler(this.btnAutomatic_Click);
      // 
      // txtStatus
      // 
      this.txtStatus.Location = new System.Drawing.Point(26, 323);
      this.txtStatus.Multiline = true;
      this.txtStatus.Name = "txtStatus";
      this.txtStatus.ReadOnly = true;
      this.txtStatus.Size = new System.Drawing.Size(395, 77);
      this.txtStatus.TabIndex = 5;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(443, 412);
      this.Controls.Add(this.txtStatus);
      this.Controls.Add(this.btnAutomatic);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.imageDisplay);
      this.Controls.Add(this.btnManual);
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "PrintScreen Robot";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.PictureBox imageDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrCapture;
        private System.Windows.Forms.Button btnAutomatic;
    private System.Windows.Forms.TextBox txtStatus;
  }
}

