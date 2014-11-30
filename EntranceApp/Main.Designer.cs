namespace imseWCard2
{
    partial class Main
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Configure = new System.Windows.Forms.TabPage();
            this.entranceTimeLabel = new System.Windows.Forms.Label();
            this.entranceTimeStaticLabel = new System.Windows.Forms.Label();
            this.carPlateLabel = new System.Windows.Forms.Label();
            this.carPlateStaticLabel = new System.Windows.Forms.Label();
            this.cardIdLabel = new System.Windows.Forms.Label();
            this.cardInformationStaticLabel = new System.Windows.Forms.Label();
            this.cardIdStaticLabel = new System.Windows.Forms.Label();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.btnEject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.Configure.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Configure);
            this.tabControl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(447, 395);
            this.tabControl.TabIndex = 0;
            // 
            // Configure
            // 
            this.Configure.BackColor = System.Drawing.Color.LightBlue;
            this.Configure.Controls.Add(this.entranceTimeLabel);
            this.Configure.Controls.Add(this.entranceTimeStaticLabel);
            this.Configure.Controls.Add(this.carPlateLabel);
            this.Configure.Controls.Add(this.carPlateStaticLabel);
            this.Configure.Controls.Add(this.cardIdLabel);
            this.Configure.Controls.Add(this.cardInformationStaticLabel);
            this.Configure.Controls.Add(this.cardIdStaticLabel);
            this.Configure.Controls.Add(this.textBoxMsg);
            this.Configure.Controls.Add(this.btnEject);
            this.Configure.Controls.Add(this.label1);
            this.Configure.Location = new System.Drawing.Point(4, 31);
            this.Configure.Name = "Configure";
            this.Configure.Padding = new System.Windows.Forms.Padding(3);
            this.Configure.Size = new System.Drawing.Size(439, 360);
            this.Configure.TabIndex = 0;
            this.Configure.Text = "Entrance Application";
            // 
            // entranceTimeLabel
            // 
            this.entranceTimeLabel.AutoSize = true;
            this.entranceTimeLabel.Location = new System.Drawing.Point(12, 318);
            this.entranceTimeLabel.Name = "entranceTimeLabel";
            this.entranceTimeLabel.Size = new System.Drawing.Size(186, 22);
            this.entranceTimeLabel.TabIndex = 19;
            this.entranceTimeLabel.Text = "                ";
            // 
            // entranceTimeStaticLabel
            // 
            this.entranceTimeStaticLabel.AutoSize = true;
            this.entranceTimeStaticLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entranceTimeStaticLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.entranceTimeStaticLabel.Location = new System.Drawing.Point(12, 282);
            this.entranceTimeStaticLabel.Name = "entranceTimeStaticLabel";
            this.entranceTimeStaticLabel.Size = new System.Drawing.Size(179, 23);
            this.entranceTimeStaticLabel.TabIndex = 18;
            this.entranceTimeStaticLabel.Text = "Entrance time";
            // 
            // carPlateLabel
            // 
            this.carPlateLabel.AutoSize = true;
            this.carPlateLabel.Location = new System.Drawing.Point(223, 242);
            this.carPlateLabel.Name = "carPlateLabel";
            this.carPlateLabel.Size = new System.Drawing.Size(153, 22);
            this.carPlateLabel.TabIndex = 17;
            this.carPlateLabel.Text = "             ";
            // 
            // carPlateStaticLabel
            // 
            this.carPlateStaticLabel.AutoSize = true;
            this.carPlateStaticLabel.Location = new System.Drawing.Point(11, 242);
            this.carPlateStaticLabel.Name = "carPlateStaticLabel";
            this.carPlateStaticLabel.Size = new System.Drawing.Size(197, 22);
            this.carPlateStaticLabel.TabIndex = 16;
            this.carPlateStaticLabel.Text = "Car Plate Number:";
            // 
            // cardIdLabel
            // 
            this.cardIdLabel.AutoSize = true;
            this.cardIdLabel.Location = new System.Drawing.Point(103, 210);
            this.cardIdLabel.Name = "cardIdLabel";
            this.cardIdLabel.Size = new System.Drawing.Size(153, 22);
            this.cardIdLabel.TabIndex = 10;
            this.cardIdLabel.Text = "             ";
            // 
            // cardInformationStaticLabel
            // 
            this.cardInformationStaticLabel.AutoSize = true;
            this.cardInformationStaticLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardInformationStaticLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cardInformationStaticLabel.Location = new System.Drawing.Point(12, 176);
            this.cardInformationStaticLabel.Name = "cardInformationStaticLabel";
            this.cardInformationStaticLabel.Size = new System.Drawing.Size(218, 23);
            this.cardInformationStaticLabel.TabIndex = 9;
            this.cardInformationStaticLabel.Text = "Card Information";
            // 
            // cardIdStaticLabel
            // 
            this.cardIdStaticLabel.AutoSize = true;
            this.cardIdStaticLabel.Location = new System.Drawing.Point(10, 210);
            this.cardIdStaticLabel.Name = "cardIdStaticLabel";
            this.cardIdStaticLabel.Size = new System.Drawing.Size(87, 22);
            this.cardIdStaticLabel.TabIndex = 8;
            this.cardIdStaticLabel.Text = "CardID:";
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMsg.Location = new System.Drawing.Point(16, 40);
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.Size = new System.Drawing.Size(417, 31);
            this.textBoxMsg.TabIndex = 1;
            this.textBoxMsg.Text = "Please eject card";
            // 
            // btnEject
            // 
            this.btnEject.Enabled = false;
            this.btnEject.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEject.Location = new System.Drawing.Point(126, 90);
            this.btnEject.Name = "btnEject";
            this.btnEject.Size = new System.Drawing.Size(175, 68);
            this.btnEject.TabIndex = 6;
            this.btnEject.Text = "Eject card";
            this.btnEject.UseVisualStyleBackColor = true;
            this.btnEject.Click += new System.EventHandler(this.btnEject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(471, 420);
            this.Controls.Add(this.tabControl);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parking System - Entrance App";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl.ResumeLayout(false);
            this.Configure.ResumeLayout(false);
            this.Configure.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Configure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.Label cardIdLabel;
        private System.Windows.Forms.Label cardInformationStaticLabel;
        private System.Windows.Forms.Label cardIdStaticLabel;
        private System.Windows.Forms.Label carPlateLabel;
        private System.Windows.Forms.Label carPlateStaticLabel;
        private System.Windows.Forms.Button btnEject;
        private System.Windows.Forms.Label entranceTimeStaticLabel;
        private System.Windows.Forms.Label entranceTimeLabel;
    }
}

