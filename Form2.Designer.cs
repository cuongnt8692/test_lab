namespace imagelocation
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblLowThreshold = new System.Windows.Forms.Label();
            this.lblValueLowThresh = new System.Windows.Forms.Label();
            this.tbrLowThreshold = new System.Windows.Forms.TrackBar();
            this.tbrHighThreshold = new System.Windows.Forms.TrackBar();
            this.lblValueHighThresh = new System.Windows.Forms.Label();
            this.lblHighThreshold = new System.Windows.Forms.Label();
            this.btnOKThreshold = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbrLowThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrHighThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLowThreshold
            // 
            this.lblLowThreshold.AutoSize = true;
            this.lblLowThreshold.Location = new System.Drawing.Point(13, 13);
            this.lblLowThreshold.Name = "lblLowThreshold";
            this.lblLowThreshold.Size = new System.Drawing.Size(80, 13);
            this.lblLowThreshold.TabIndex = 0;
            this.lblLowThreshold.Text = "Low Threshold:";
            // 
            // lblValueLowThresh
            // 
            this.lblValueLowThresh.AutoSize = true;
            this.lblValueLowThresh.Location = new System.Drawing.Point(99, 13);
            this.lblValueLowThresh.Name = "lblValueLowThresh";
            this.lblValueLowThresh.Size = new System.Drawing.Size(0, 13);
            this.lblValueLowThresh.TabIndex = 1;
            // 
            // tbrLowThreshold
            // 
            this.tbrLowThreshold.Location = new System.Drawing.Point(16, 30);
            this.tbrLowThreshold.Maximum = 255;
            this.tbrLowThreshold.Name = "tbrLowThreshold";
            this.tbrLowThreshold.Size = new System.Drawing.Size(248, 45);
            this.tbrLowThreshold.TabIndex = 2;
            this.tbrLowThreshold.TickFrequency = 10;
            this.tbrLowThreshold.Scroll += new System.EventHandler(this.tbrLowThreshold_Scroll);
            // 
            // tbrHighThreshold
            // 
            this.tbrHighThreshold.Location = new System.Drawing.Point(16, 95);
            this.tbrHighThreshold.Maximum = 255;
            this.tbrHighThreshold.Name = "tbrHighThreshold";
            this.tbrHighThreshold.Size = new System.Drawing.Size(248, 45);
            this.tbrHighThreshold.TabIndex = 5;
            this.tbrHighThreshold.TickFrequency = 10;
            this.tbrHighThreshold.Scroll += new System.EventHandler(this.tbrHighThreshold_Scroll);
            // 
            // lblValueHighThresh
            // 
            this.lblValueHighThresh.AutoSize = true;
            this.lblValueHighThresh.Location = new System.Drawing.Point(99, 78);
            this.lblValueHighThresh.Name = "lblValueHighThresh";
            this.lblValueHighThresh.Size = new System.Drawing.Size(0, 13);
            this.lblValueHighThresh.TabIndex = 4;
            // 
            // lblHighThreshold
            // 
            this.lblHighThreshold.AutoSize = true;
            this.lblHighThreshold.Location = new System.Drawing.Point(13, 78);
            this.lblHighThreshold.Name = "lblHighThreshold";
            this.lblHighThreshold.Size = new System.Drawing.Size(82, 13);
            this.lblHighThreshold.TabIndex = 3;
            this.lblHighThreshold.Text = "High Threshold:";
            // 
            // btnOKThreshold
            // 
            this.btnOKThreshold.Location = new System.Drawing.Point(102, 146);
            this.btnOKThreshold.Name = "btnOKThreshold";
            this.btnOKThreshold.Size = new System.Drawing.Size(75, 23);
            this.btnOKThreshold.TabIndex = 6;
            this.btnOKThreshold.Text = "OK";
            this.btnOKThreshold.UseVisualStyleBackColor = true;
            this.btnOKThreshold.Click += new System.EventHandler(this.btnOKThreshold_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 189);
            this.Controls.Add(this.btnOKThreshold);
            this.Controls.Add(this.tbrHighThreshold);
            this.Controls.Add(this.lblValueHighThresh);
            this.Controls.Add(this.lblHighThreshold);
            this.Controls.Add(this.tbrLowThreshold);
            this.Controls.Add(this.lblValueLowThresh);
            this.Controls.Add(this.lblLowThreshold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Canny Edge Detector Tool";
            ((System.ComponentModel.ISupportInitialize)(this.tbrLowThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrHighThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLowThreshold;
        private System.Windows.Forms.Label lblValueLowThresh;
        private System.Windows.Forms.TrackBar tbrLowThreshold;
        private System.Windows.Forms.TrackBar tbrHighThreshold;
        private System.Windows.Forms.Label lblValueHighThresh;
        private System.Windows.Forms.Label lblHighThreshold;
        private System.Windows.Forms.Button btnOKThreshold;
    }
}