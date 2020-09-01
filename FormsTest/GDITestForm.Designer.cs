namespace Dotto
{
    partial class GDITestForm
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
            this.tmrAppTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlTool = new System.Windows.Forms.Panel();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.trackBarHJitter = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDimensions = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.pnlPicButtons = new System.Windows.Forms.Panel();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.txtColNo = new System.Windows.Forms.TextBox();
            this.txtRowNo = new System.Windows.Forms.TextBox();
            this.lblColNo = new System.Windows.Forms.Label();
            this.lblRowNo = new System.Windows.Forms.Label();
            this.lblJitterX = new System.Windows.Forms.Label();
            this.trackBarVjitter = new System.Windows.Forms.TrackBar();
            this.lblJitterY = new System.Windows.Forms.Label();
            this.pnlTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHJitter)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlPicButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVjitter)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrAppTimer
            // 
            this.tmrAppTimer.Enabled = true;
            this.tmrAppTimer.Interval = 10;
            this.tmrAppTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlTool
            // 
            this.pnlTool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlTool.Controls.Add(this.lblJitterY);
            this.pnlTool.Controls.Add(this.lblJitterX);
            this.pnlTool.Controls.Add(this.btnLoadImage);
            this.pnlTool.Controls.Add(this.trackBarVjitter);
            this.pnlTool.Controls.Add(this.trackBarHJitter);
            this.pnlTool.Controls.Add(this.panel1);
            this.pnlTool.Location = new System.Drawing.Point(12, 12);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(221, 535);
            this.pnlTool.TabIndex = 0;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadImage.Location = new System.Drawing.Point(4, 505);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(214, 23);
            this.btnLoadImage.TabIndex = 2;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // trackBarHJitter
            // 
            this.trackBarHJitter.Location = new System.Drawing.Point(18, 203);
            this.trackBarHJitter.Maximum = 30;
            this.trackBarHJitter.Name = "trackBarHJitter";
            this.trackBarHJitter.Size = new System.Drawing.Size(186, 45);
            this.trackBarHJitter.SmallChange = 2;
            this.trackBarHJitter.TabIndex = 1;
            this.trackBarHJitter.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblDimensions);
            this.panel1.Controls.Add(this.lblRowNo);
            this.panel1.Controls.Add(this.lblColNo);
            this.panel1.Controls.Add(this.lblHeight);
            this.panel1.Controls.Add(this.txtRowNo);
            this.panel1.Controls.Add(this.lblWidth);
            this.panel1.Controls.Add(this.txtColNo);
            this.panel1.Controls.Add(this.txtHeight);
            this.panel1.Controls.Add(this.txtWidth);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 154);
            this.panel1.TabIndex = 0;
            // 
            // lblDimensions
            // 
            this.lblDimensions.AutoSize = true;
            this.lblDimensions.Location = new System.Drawing.Point(11, 9);
            this.lblDimensions.Name = "lblDimensions";
            this.lblDimensions.Size = new System.Drawing.Size(61, 13);
            this.lblDimensions.TabIndex = 2;
            this.lblDimensions.Text = "Dimensions";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(11, 62);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(77, 13);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Canvas Height";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(11, 36);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(74, 13);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Canvas Width";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(100, 59);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 0;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumbersOnly_KeyPress);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(100, 33);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 0;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumbersOnly_KeyPress);
            // 
            // pnlPicture
            // 
            this.pnlPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPicture.Location = new System.Drawing.Point(239, 12);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(567, 498);
            this.pnlPicture.TabIndex = 1;
            // 
            // pnlPicButtons
            // 
            this.pnlPicButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPicButtons.Controls.Add(this.btnSaveImage);
            this.pnlPicButtons.Location = new System.Drawing.Point(239, 516);
            this.pnlPicButtons.Name = "pnlPicButtons";
            this.pnlPicButtons.Size = new System.Drawing.Size(567, 31);
            this.pnlPicButtons.TabIndex = 0;
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveImage.Location = new System.Drawing.Point(489, 3);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(75, 27);
            this.btnSaveImage.TabIndex = 0;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            // 
            // txtColNo
            // 
            this.txtColNo.Location = new System.Drawing.Point(100, 95);
            this.txtColNo.Name = "txtColNo";
            this.txtColNo.Size = new System.Drawing.Size(100, 20);
            this.txtColNo.TabIndex = 0;
            this.txtColNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtColNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumbersOnly_KeyPress);
            // 
            // txtRowNo
            // 
            this.txtRowNo.Location = new System.Drawing.Point(100, 121);
            this.txtRowNo.Name = "txtRowNo";
            this.txtRowNo.Size = new System.Drawing.Size(100, 20);
            this.txtRowNo.TabIndex = 0;
            this.txtRowNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRowNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumbersOnly_KeyPress);
            // 
            // lblColNo
            // 
            this.lblColNo.AutoSize = true;
            this.lblColNo.Location = new System.Drawing.Point(11, 98);
            this.lblColNo.Name = "lblColNo";
            this.lblColNo.Size = new System.Drawing.Size(79, 13);
            this.lblColNo.TabIndex = 1;
            this.lblColNo.Text = "No. of Columns";
            // 
            // lblRowNo
            // 
            this.lblRowNo.AutoSize = true;
            this.lblRowNo.Location = new System.Drawing.Point(11, 124);
            this.lblRowNo.Name = "lblRowNo";
            this.lblRowNo.Size = new System.Drawing.Size(66, 13);
            this.lblRowNo.TabIndex = 1;
            this.lblRowNo.Text = "No. of Rows";
            // 
            // lblJitterX
            // 
            this.lblJitterX.AutoSize = true;
            this.lblJitterX.Location = new System.Drawing.Point(15, 177);
            this.lblJitterX.Name = "lblJitterX";
            this.lblJitterX.Size = new System.Drawing.Size(76, 13);
            this.lblJitterX.TabIndex = 3;
            this.lblJitterX.Text = "Horizontal jitter";
            // 
            // trackBarVjitter
            // 
            this.trackBarVjitter.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBarVjitter.Location = new System.Drawing.Point(18, 267);
            this.trackBarVjitter.Maximum = 30;
            this.trackBarVjitter.Name = "trackBarVjitter";
            this.trackBarVjitter.Size = new System.Drawing.Size(186, 45);
            this.trackBarVjitter.SmallChange = 2;
            this.trackBarVjitter.TabIndex = 1;
            this.trackBarVjitter.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // lblJitterY
            // 
            this.lblJitterY.AutoSize = true;
            this.lblJitterY.Location = new System.Drawing.Point(15, 241);
            this.lblJitterY.Name = "lblJitterY";
            this.lblJitterY.Size = new System.Drawing.Size(64, 13);
            this.lblJitterY.TabIndex = 3;
            this.lblJitterY.Text = "Vertical jitter";
            // 
            // GDITestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 566);
            this.Controls.Add(this.pnlPicButtons);
            this.Controls.Add(this.pnlPicture);
            this.Controls.Add(this.pnlTool);
            this.Name = "GDITestForm";
            this.Text = "GDI+ Tests";
            this.Load += new System.EventHandler(this.GDITestForm_Load);
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHJitter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPicButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVjitter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrAppTimer;
        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDimensions;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.TrackBar trackBarHJitter;
        private System.Windows.Forms.Panel pnlPicButtons;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Label lblRowNo;
        private System.Windows.Forms.Label lblColNo;
        private System.Windows.Forms.TextBox txtRowNo;
        private System.Windows.Forms.TextBox txtColNo;
        private System.Windows.Forms.Label lblJitterY;
        private System.Windows.Forms.Label lblJitterX;
        private System.Windows.Forms.TrackBar trackBarVjitter;
    }
}

