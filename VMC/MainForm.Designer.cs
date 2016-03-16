namespace VMC
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fader1 = new System.Windows.Forms.TrackBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLayer1 = new System.Windows.Forms.Button();
            this.fader2 = new System.Windows.Forms.TrackBar();
            this.fader3 = new System.Windows.Forms.TrackBar();
            this.fader4 = new System.Windows.Forms.TrackBar();
            this.fader5 = new System.Windows.Forms.TrackBar();
            this.fader8 = new System.Windows.Forms.TrackBar();
            this.fader7 = new System.Windows.Forms.TrackBar();
            this.fader6 = new System.Windows.Forms.TrackBar();
            this.btnLayer2 = new System.Windows.Forms.Button();
            this.btnLayer3 = new System.Windows.Forms.Button();
            this.btnLayer4 = new System.Windows.Forms.Button();
            this.btnMute1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.trackPan = new System.Windows.Forms.TrackBar();
            this.textChannel = new System.Windows.Forms.TextBox();
            this.trackAuxSend = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSOF = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fader1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fader2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fader3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fader4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fader5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fader8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fader7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fader6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackAuxSend)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(792, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.connectToolStripMenuItem.Text = "Connect...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fader1
            // 
            this.fader1.Location = new System.Drawing.Point(100, 102);
            this.fader1.Maximum = 100;
            this.fader1.Name = "fader1";
            this.fader1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.fader1.Size = new System.Drawing.Size(53, 350);
            this.fader1.TabIndex = 4;
            this.fader1.TickFrequency = 10;
            this.fader1.ValueChanged += new System.EventHandler(this.fader1_ValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 545);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(792, 23);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(49, 18);
            this.statusLabel.Text = "Ready";
            // 
            // btnLayer1
            // 
            this.btnLayer1.Location = new System.Drawing.Point(12, 110);
            this.btnLayer1.Name = "btnLayer1";
            this.btnLayer1.Size = new System.Drawing.Size(75, 23);
            this.btnLayer1.TabIndex = 6;
            this.btnLayer1.Text = "1-8";
            this.btnLayer1.UseVisualStyleBackColor = true;

            // 
            // fader2
            // 
            this.fader2.Location = new System.Drawing.Point(145, 102);
            this.fader2.Maximum = 100;
            this.fader2.Name = "fader2";
            this.fader2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.fader2.Size = new System.Drawing.Size(53, 350);
            this.fader2.TabIndex = 7;
            this.fader2.TickFrequency = 10;
            this.fader2.ValueChanged += new System.EventHandler(this.fader2_ValueChanged);
            // 
            // fader3
            // 
            this.fader3.Location = new System.Drawing.Point(190, 102);
            this.fader3.Maximum = 100;
            this.fader3.Name = "fader3";
            this.fader3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.fader3.Size = new System.Drawing.Size(53, 350);
            this.fader3.TabIndex = 8;
            this.fader3.TickFrequency = 10;
            this.fader3.ValueChanged += new System.EventHandler(this.fader3_ValueChanged);
            // 
            // fader4
            // 
            this.fader4.Location = new System.Drawing.Point(235, 102);
            this.fader4.Maximum = 100;
            this.fader4.Name = "fader4";
            this.fader4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.fader4.Size = new System.Drawing.Size(53, 350);
            this.fader4.TabIndex = 9;
            this.fader4.TickFrequency = 10;
            this.fader4.ValueChanged += new System.EventHandler(this.fader4_ValueChanged);
            // 
            // fader5
            // 
            this.fader5.Location = new System.Drawing.Point(281, 102);
            this.fader5.Maximum = 100;
            this.fader5.Name = "fader5";
            this.fader5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.fader5.Size = new System.Drawing.Size(53, 350);
            this.fader5.TabIndex = 10;
            this.fader5.TickFrequency = 10;
            this.fader5.ValueChanged += new System.EventHandler(this.fader5_ValueChanged);
            // 
            // fader8
            // 
            this.fader8.Location = new System.Drawing.Point(415, 102);
            this.fader8.Maximum = 100;
            this.fader8.Name = "fader8";
            this.fader8.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.fader8.Size = new System.Drawing.Size(53, 350);
            this.fader8.TabIndex = 13;
            this.fader8.TickFrequency = 10;
            this.fader8.ValueChanged += new System.EventHandler(this.fader8_ValueChanged);
            // 
            // fader7
            // 
            this.fader7.Location = new System.Drawing.Point(370, 102);
            this.fader7.Maximum = 100;
            this.fader7.Name = "fader7";
            this.fader7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.fader7.Size = new System.Drawing.Size(53, 350);
            this.fader7.TabIndex = 12;
            this.fader7.TickFrequency = 10;
            this.fader7.ValueChanged += new System.EventHandler(this.fader7_ValueChanged);
            // 
            // fader6
            // 
            this.fader6.Location = new System.Drawing.Point(325, 102);
            this.fader6.Maximum = 100;
            this.fader6.Name = "fader6";
            this.fader6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.fader6.Size = new System.Drawing.Size(53, 350);
            this.fader6.TabIndex = 11;
            this.fader6.TickFrequency = 10;
            this.fader6.ValueChanged += new System.EventHandler(this.fader6_ValueChanged);
            // 
            // btnLayer2
            // 
            this.btnLayer2.Location = new System.Drawing.Point(12, 139);
            this.btnLayer2.Name = "btnLayer2";
            this.btnLayer2.Size = new System.Drawing.Size(75, 23);
            this.btnLayer2.TabIndex = 14;
            this.btnLayer2.Text = "9-16";
            this.btnLayer2.UseVisualStyleBackColor = true;

            // 
            // btnLayer3
            // 
            this.btnLayer3.Location = new System.Drawing.Point(12, 168);
            this.btnLayer3.Name = "btnLayer3";
            this.btnLayer3.Size = new System.Drawing.Size(75, 23);
            this.btnLayer3.TabIndex = 15;
            this.btnLayer3.Text = "17-24";
            this.btnLayer3.UseVisualStyleBackColor = true;

            // 
            // btnLayer4
            // 
            this.btnLayer4.Location = new System.Drawing.Point(12, 197);
            this.btnLayer4.Name = "btnLayer4";
            this.btnLayer4.Size = new System.Drawing.Size(75, 23);
            this.btnLayer4.TabIndex = 16;
            this.btnLayer4.Text = "25-32";
            this.btnLayer4.UseVisualStyleBackColor = true;

            // 
            // btnMute1
            // 
            this.btnMute1.BackColor = System.Drawing.SystemColors.Control;
            this.btnMute1.Location = new System.Drawing.Point(100, 458);
            this.btnMute1.Name = "btnMute1";
            this.btnMute1.Size = new System.Drawing.Size(23, 23);
            this.btnMute1.TabIndex = 17;
            this.btnMute1.Text = "M";
            this.btnMute1.UseVisualStyleBackColor = false;
            this.btnMute1.Click += new System.EventHandler(this.btnMute1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(145, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "M";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(190, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "M";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(235, 458);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "M";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(281, 458);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "M";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(325, 458);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "M";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(370, 458);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "M";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(415, 458);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(23, 23);
            this.button7.TabIndex = 24;
            this.button7.Text = "M";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 429);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 25;
            this.btnTest.Text = "Meters";
            this.btnTest.UseMnemonic = false;
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // trackPan
            // 
            this.trackPan.Location = new System.Drawing.Point(100, 489);
            this.trackPan.Maximum = 100;
            this.trackPan.Name = "trackPan";
            this.trackPan.Size = new System.Drawing.Size(338, 53);
            this.trackPan.TabIndex = 26;
            this.trackPan.TickFrequency = 10;
            this.trackPan.Value = 50;
            this.trackPan.ValueChanged += new System.EventHandler(this.trackPan_ValueChanged);
            // 
            // textChannel
            // 
            this.textChannel.Location = new System.Drawing.Point(50, 489);
            this.textChannel.Name = "textChannel";
            this.textChannel.Size = new System.Drawing.Size(37, 22);
            this.textChannel.TabIndex = 27;
            this.textChannel.Text = "1";
            // 
            // trackAuxSend
            // 
            this.trackAuxSend.Location = new System.Drawing.Point(727, 298);
            this.trackAuxSend.Maximum = 100;
            this.trackAuxSend.Name = "trackAuxSend";
            this.trackAuxSend.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackAuxSend.Size = new System.Drawing.Size(53, 183);
            this.trackAuxSend.TabIndex = 28;
            this.trackAuxSend.TickFrequency = 10;
            this.trackAuxSend.ValueChanged += new System.EventHandler(this.trackAuxSend_ValueChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(680, 489);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 20);
            this.progressBar1.TabIndex = 29;
            // 
            // btnSOF
            // 
            this.btnSOF.Location = new System.Drawing.Point(12, 330);
            this.btnSOF.Name = "btnSOF";
            this.btnSOF.Size = new System.Drawing.Size(75, 23);
            this.btnSOF.TabIndex = 30;
            this.btnSOF.Text = "S.O.F";
            this.btnSOF.UseVisualStyleBackColor = true;
            this.btnSOF.Click += new System.EventHandler(this.btnSOF_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 568);
            this.Controls.Add(this.btnSOF);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.trackAuxSend);
            this.Controls.Add(this.textChannel);
            this.Controls.Add(this.trackPan);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMute1);
            this.Controls.Add(this.btnLayer4);
            this.Controls.Add(this.btnLayer3);
            this.Controls.Add(this.btnLayer2);
            this.Controls.Add(this.fader8);
            this.Controls.Add(this.fader7);
            this.Controls.Add(this.fader6);
            this.Controls.Add(this.fader5);
            this.Controls.Add(this.fader4);
            this.Controls.Add(this.fader3);
            this.Controls.Add(this.fader2);
            this.Controls.Add(this.btnLayer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.fader1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Virtual Mixing Console";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fader1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fader2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fader3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fader4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fader5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fader8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fader7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fader6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackAuxSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TrackBar fader1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button btnLayer1;
        private System.Windows.Forms.TrackBar fader2;
        private System.Windows.Forms.TrackBar fader3;
        private System.Windows.Forms.TrackBar fader4;
        private System.Windows.Forms.TrackBar fader5;
        private System.Windows.Forms.TrackBar fader8;
        private System.Windows.Forms.TrackBar fader7;
        private System.Windows.Forms.TrackBar fader6;
        private System.Windows.Forms.Button btnLayer2;
        private System.Windows.Forms.Button btnLayer3;
        private System.Windows.Forms.Button btnLayer4;
        private System.Windows.Forms.Button btnMute1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TrackBar trackPan;
        private System.Windows.Forms.TextBox textChannel;
        private System.Windows.Forms.TrackBar trackAuxSend;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSOF;

    }
}

