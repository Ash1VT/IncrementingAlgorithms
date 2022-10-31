
namespace IncrementingAlgorithms
{
    partial class MainForm
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
            this.drawingPictureBox = new System.Windows.Forms.PictureBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.figuresDrawingPanel = new System.Windows.Forms.Panel();
            this.figuresComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.renderingTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.optionsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleFillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waveFillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineFillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.drawingPictureBox)).BeginInit();
            this.figuresDrawingPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.optionsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingPictureBox
            // 
            this.drawingPictureBox.BackColor = System.Drawing.Color.White;
            this.drawingPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingPictureBox.Location = new System.Drawing.Point(12, 47);
            this.drawingPictureBox.Name = "drawingPictureBox";
            this.drawingPictureBox.Size = new System.Drawing.Size(521, 467);
            this.drawingPictureBox.TabIndex = 0;
            this.drawingPictureBox.TabStop = false;
            // 
            // drawButton
            // 
            this.drawButton.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drawButton.Location = new System.Drawing.Point(13, 99);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(326, 44);
            this.drawButton.TabIndex = 1;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // figuresDrawingPanel
            // 
            this.figuresDrawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.figuresDrawingPanel.Controls.Add(this.figuresComboBox);
            this.figuresDrawingPanel.Controls.Add(this.label1);
            this.figuresDrawingPanel.Controls.Add(this.drawButton);
            this.figuresDrawingPanel.Location = new System.Drawing.Point(555, 47);
            this.figuresDrawingPanel.Name = "figuresDrawingPanel";
            this.figuresDrawingPanel.Size = new System.Drawing.Size(352, 161);
            this.figuresDrawingPanel.TabIndex = 2;
            // 
            // figuresComboBox
            // 
            this.figuresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.figuresComboBox.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.figuresComboBox.FormattingEnabled = true;
            this.figuresComboBox.Location = new System.Drawing.Point(13, 55);
            this.figuresComboBox.Name = "figuresComboBox";
            this.figuresComboBox.Size = new System.Drawing.Size(326, 29);
            this.figuresComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(83, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Figures drawing";
            // 
            // renderingTimer
            // 
            this.renderingTimer.Interval = 20;
            this.renderingTimer.Tick += new System.EventHandler(this.renderingTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Location = new System.Drawing.Point(555, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 171);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(127, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Moving";
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopButton.Location = new System.Drawing.Point(13, 109);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(326, 44);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(13, 59);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(326, 44);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(555, 424);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(352, 90);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // optionsMenuStrip
            // 
            this.optionsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.fillingToolStripMenuItem});
            this.optionsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.optionsMenuStrip.Name = "optionsMenuStrip";
            this.optionsMenuStrip.Size = new System.Drawing.Size(937, 29);
            this.optionsMenuStrip.TabIndex = 5;
            this.optionsMenuStrip.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // fillingToolStripMenuItem
            // 
            this.fillingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleFillingToolStripMenuItem,
            this.waveFillingToolStripMenuItem,
            this.lineFillingToolStripMenuItem});
            this.fillingToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fillingToolStripMenuItem.Name = "fillingToolStripMenuItem";
            this.fillingToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.fillingToolStripMenuItem.Text = "Filling";
            // 
            // simpleFillingToolStripMenuItem
            // 
            this.simpleFillingToolStripMenuItem.Name = "simpleFillingToolStripMenuItem";
            this.simpleFillingToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.simpleFillingToolStripMenuItem.Text = "Simple filling";
            this.simpleFillingToolStripMenuItem.Click += new System.EventHandler(this.simpleFillingToolStripMenuItem_Click);
            // 
            // waveFillingToolStripMenuItem
            // 
            this.waveFillingToolStripMenuItem.Name = "waveFillingToolStripMenuItem";
            this.waveFillingToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.waveFillingToolStripMenuItem.Text = "Wave filling";
            this.waveFillingToolStripMenuItem.Click += new System.EventHandler(this.waveFillingToolStripMenuItem_Click);
            // 
            // lineFillingToolStripMenuItem
            // 
            this.lineFillingToolStripMenuItem.Name = "lineFillingToolStripMenuItem";
            this.lineFillingToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.lineFillingToolStripMenuItem.Text = "Line filling";
            this.lineFillingToolStripMenuItem.Click += new System.EventHandler(this.lineFillingToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 526);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.figuresDrawingPanel);
            this.Controls.Add(this.drawingPictureBox);
            this.Controls.Add(this.optionsMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.optionsMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Drawing";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawingPictureBox)).EndInit();
            this.figuresDrawingPanel.ResumeLayout(false);
            this.figuresDrawingPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.optionsMenuStrip.ResumeLayout(false);
            this.optionsMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawingPictureBox;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Panel figuresDrawingPanel;
        private System.Windows.Forms.ComboBox figuresComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer renderingTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip optionsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleFillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waveFillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineFillingToolStripMenuItem;
    }
}

