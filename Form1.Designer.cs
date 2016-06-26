namespace imagelocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homogeneityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.differenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morphologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilatationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segmentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxOutput = new System.Windows.Forms.PictureBox();
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.lblinput = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tspLoca = new System.Windows.Forms.ToolStripButton();
            this.tsbRec = new System.Windows.Forms.ToolStripButton();
            this.tsbInfo = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.processToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edgeDetectionToolStripMenuItem,
            this.morphologyToolStripMenuItem,
            this.locationToolStripMenuItem,
            this.segmentationToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // edgeDetectionToolStripMenuItem
            // 
            this.edgeDetectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cannyToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.homogeneityToolStripMenuItem,
            this.differenceToolStripMenuItem});
            this.edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            this.edgeDetectionToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.edgeDetectionToolStripMenuItem.Text = "Edge detection";
            // 
            // cannyToolStripMenuItem
            // 
            this.cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
            this.cannyToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.cannyToolStripMenuItem.Text = "Canny";
            this.cannyToolStripMenuItem.Click += new System.EventHandler(this.cannyToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // homogeneityToolStripMenuItem
            // 
            this.homogeneityToolStripMenuItem.Name = "homogeneityToolStripMenuItem";
            this.homogeneityToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.homogeneityToolStripMenuItem.Text = "Homogenity";
            this.homogeneityToolStripMenuItem.Click += new System.EventHandler(this.homogeneityToolStripMenuItem_Click);
            // 
            // differenceToolStripMenuItem
            // 
            this.differenceToolStripMenuItem.Name = "differenceToolStripMenuItem";
            this.differenceToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.differenceToolStripMenuItem.Text = "Difference";
            this.differenceToolStripMenuItem.Click += new System.EventHandler(this.differenceToolStripMenuItem_Click);
            // 
            // morphologyToolStripMenuItem
            // 
            this.morphologyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilatationToolStripMenuItem,
            this.erosionToolStripMenuItem,
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem});
            this.morphologyToolStripMenuItem.Name = "morphologyToolStripMenuItem";
            this.morphologyToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.morphologyToolStripMenuItem.Text = "Morphology";
            // 
            // dilatationToolStripMenuItem
            // 
            this.dilatationToolStripMenuItem.Name = "dilatationToolStripMenuItem";
            this.dilatationToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.dilatationToolStripMenuItem.Text = "Dilatation";
            this.dilatationToolStripMenuItem.Click += new System.EventHandler(this.dilatationToolStripMenuItem_Click);
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.erosionToolStripMenuItem.Text = "Erosion";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.openingToolStripMenuItem.Text = "Opening";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.closingToolStripMenuItem.Text = "Closing";
            this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.locationToolStripMenuItem.Text = "Location";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.locationToolStripMenuItem_Click);
            // 
            // segmentationToolStripMenuItem
            // 
            this.segmentationToolStripMenuItem.Name = "segmentationToolStripMenuItem";
            this.segmentationToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.segmentationToolStripMenuItem.Text = "Segmentation";
            this.segmentationToolStripMenuItem.Click += new System.EventHandler(this.segmentationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgrammToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutProgrammToolStripMenuItem
            // 
            this.aboutProgrammToolStripMenuItem.Name = "aboutProgrammToolStripMenuItem";
            this.aboutProgrammToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutProgrammToolStripMenuItem.Text = "About program";
            this.aboutProgrammToolStripMenuItem.Click += new System.EventHandler(this.aboutProgrammToolStripMenuItem_Click);
            // 
            // pictureBoxOutput
            // 
            this.pictureBoxOutput.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOutput.Image")));
            this.pictureBoxOutput.Location = new System.Drawing.Point(522, 102);
            this.pictureBoxOutput.Name = "pictureBoxOutput";
            this.pictureBoxOutput.Size = new System.Drawing.Size(450, 450);
            this.pictureBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOutput.TabIndex = 2;
            this.pictureBoxOutput.TabStop = false;
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxInput.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInput.Image")));
            this.pictureBoxInput.Location = new System.Drawing.Point(12, 102);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(450, 450);
            this.pictureBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInput.TabIndex = 1;
            this.pictureBoxInput.TabStop = false;
            // 
            // lblinput
            // 
            this.lblinput.AutoSize = true;
            this.lblinput.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinput.Location = new System.Drawing.Point(192, 67);
            this.lblinput.Name = "lblinput";
            this.lblinput.Size = new System.Drawing.Size(78, 32);
            this.lblinput.TabIndex = 3;
            this.lblinput.Text = "Input";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(636, 67);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(219, 32);
            this.lblresult.TabIndex = 4;
            this.lblresult.Text = "Result Processing";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(8, 555);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(135, 19);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Image Infomation:";
            this.lblInfo.Visible = false;
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.Location = new System.Drawing.Point(518, 555);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(67, 19);
            this.lblProcess.TabIndex = 6;
            this.lblProcess.Text = "Process:";
            this.lblProcess.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbSave,
            this.tspLoca,
            this.tsbRec,
            this.tsbInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 43);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.AutoSize = false;
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(40, 40);
            this.tsbOpen.Text = "Open";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.AutoSize = false;
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(40, 40);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tspLoca
            // 
            this.tspLoca.AutoSize = false;
            this.tspLoca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspLoca.Image = ((System.Drawing.Image)(resources.GetObject("tspLoca.Image")));
            this.tspLoca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspLoca.Name = "tspLoca";
            this.tspLoca.Size = new System.Drawing.Size(40, 40);
            this.tspLoca.Text = "Location";
            this.tspLoca.Click += new System.EventHandler(this.tspLoca_Click);
            // 
            // tsbRec
            // 
            this.tsbRec.AutoSize = false;
            this.tsbRec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRec.Image = ((System.Drawing.Image)(resources.GetObject("tsbRec.Image")));
            this.tsbRec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRec.Name = "tsbRec";
            this.tsbRec.Size = new System.Drawing.Size(40, 40);
            this.tsbRec.Text = "Recognition";
            this.tsbRec.Click += new System.EventHandler(this.tsbRec_Click);
            // 
            // tsbInfo
            // 
            this.tsbInfo.AutoSize = false;
            this.tsbInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbInfo.Image")));
            this.tsbInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInfo.Name = "tsbInfo";
            this.tsbInfo.Size = new System.Drawing.Size(40, 40);
            this.tsbInfo.Text = "Information";
            this.tsbInfo.Click += new System.EventHandler(this.tsbInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 641);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblinput);
            this.Controls.Add(this.pictureBoxOutput);
            this.Controls.Add(this.pictureBoxInput);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Processing";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgrammToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxOutput;
        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.Label lblinput;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homogeneityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem differenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morphologyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilatationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.ToolStripMenuItem segmentationToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tspLoca;
        private System.Windows.Forms.ToolStripButton tsbRec;
        private System.Windows.Forms.ToolStripButton tsbInfo;
    }
}

