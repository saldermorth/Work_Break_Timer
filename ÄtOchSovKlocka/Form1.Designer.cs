
namespace ÄtOchSovKlocka
{
    partial class Timer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            this.startWorkButton = new System.Windows.Forms.Button();
            this.startBreakButton = new System.Windows.Forms.Button();
            this.stopOneButton = new System.Windows.Forms.Button();
            this.stopTwoButton = new System.Windows.Forms.Button();
            this.workValue = new System.Windows.Forms.TextBox();
            this.breakValue = new System.Windows.Forms.TextBox();
            this.workTimer = new System.Windows.Forms.Timer(this.components);
            this.breakTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectRingToneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startWorkButton
            // 
            this.startWorkButton.BackColor = System.Drawing.Color.Black;
            this.startWorkButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startWorkButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.startWorkButton.Location = new System.Drawing.Point(83, 200);
            this.startWorkButton.Name = "startWorkButton";
            this.startWorkButton.Size = new System.Drawing.Size(179, 75);
            this.startWorkButton.TabIndex = 0;
            this.startWorkButton.Text = "Start Work";
            this.startWorkButton.UseVisualStyleBackColor = false;
            this.startWorkButton.Click += new System.EventHandler(this.workButton);
            // 
            // startBreakButton
            // 
            this.startBreakButton.BackColor = System.Drawing.Color.Black;
            this.startBreakButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startBreakButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.startBreakButton.Location = new System.Drawing.Point(470, 200);
            this.startBreakButton.Name = "startBreakButton";
            this.startBreakButton.Size = new System.Drawing.Size(179, 75);
            this.startBreakButton.TabIndex = 0;
            this.startBreakButton.Text = "Start Break";
            this.startBreakButton.UseVisualStyleBackColor = false;
            this.startBreakButton.Click += new System.EventHandler(this.breakButton);
            // 
            // stopOneButton
            // 
            this.stopOneButton.BackColor = System.Drawing.Color.Black;
            this.stopOneButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopOneButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.stopOneButton.Location = new System.Drawing.Point(269, 200);
            this.stopOneButton.Name = "stopOneButton";
            this.stopOneButton.Size = new System.Drawing.Size(81, 75);
            this.stopOneButton.TabIndex = 1;
            this.stopOneButton.Text = "Stop";
            this.stopOneButton.UseVisualStyleBackColor = false;
            this.stopOneButton.Click += new System.EventHandler(this.stopOne);
            // 
            // stopTwoButton
            // 
            this.stopTwoButton.BackColor = System.Drawing.Color.Black;
            this.stopTwoButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopTwoButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.stopTwoButton.Location = new System.Drawing.Point(655, 200);
            this.stopTwoButton.Name = "stopTwoButton";
            this.stopTwoButton.Size = new System.Drawing.Size(81, 75);
            this.stopTwoButton.TabIndex = 1;
            this.stopTwoButton.Text = "Stop";
            this.stopTwoButton.UseVisualStyleBackColor = false;
            this.stopTwoButton.Click += new System.EventHandler(this.stopTwo);
            // 
            // workValue
            // 
            this.workValue.BackColor = System.Drawing.Color.Black;
            this.workValue.Font = new System.Drawing.Font("Segoe UI", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.workValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.workValue.Location = new System.Drawing.Point(98, 27);
            this.workValue.Multiline = true;
            this.workValue.Name = "workValue";
            this.workValue.Size = new System.Drawing.Size(226, 116);
            this.workValue.TabIndex = 2;
            this.workValue.Text = "52:00";
            this.workValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // breakValue
            // 
            this.breakValue.BackColor = System.Drawing.Color.Black;
            this.breakValue.Font = new System.Drawing.Font("Segoe UI", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.breakValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.breakValue.Location = new System.Drawing.Point(485, 27);
            this.breakValue.Multiline = true;
            this.breakValue.Name = "breakValue";
            this.breakValue.Size = new System.Drawing.Size(226, 116);
            this.breakValue.TabIndex = 2;
            this.breakValue.Text = "16:00";
            this.breakValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // workTimer
            // 
            this.workTimer.Interval = 1000;
            this.workTimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // breakTimer
            // 
            this.breakTimer.Interval = 1000;
            this.breakTimer.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectRingToneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectRingToneToolStripMenuItem
            // 
            this.selectRingToneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.selectRingToneToolStripMenuItem.Name = "selectRingToneToolStripMenuItem";
            this.selectRingToneToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.selectRingToneToolStripMenuItem.Text = "Select ring tone";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(783, 314);
            this.Controls.Add(this.breakValue);
            this.Controls.Add(this.workValue);
            this.Controls.Add(this.stopTwoButton);
            this.Controls.Add(this.stopOneButton);
            this.Controls.Add(this.startBreakButton);
            this.Controls.Add(this.startWorkButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Timer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startWorkButton;
        private System.Windows.Forms.Button startBreakButton;
        private System.Windows.Forms.Button stopOneButton;
        private System.Windows.Forms.Button stopTwoButton;
        private System.Windows.Forms.TextBox workValue;
        private System.Windows.Forms.TextBox breakValue;
        private System.Windows.Forms.Timer workTimer;
        private System.Windows.Forms.Timer breakTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectRingToneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}

