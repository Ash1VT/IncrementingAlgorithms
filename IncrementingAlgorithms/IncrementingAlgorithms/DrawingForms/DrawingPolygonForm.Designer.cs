
namespace IncrementingAlgorithms.DrawingForms
{
    partial class DrawingPolygonForm
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
            this.figureInformationPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.sidesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.bLabel = new System.Windows.Forms.Label();
            this.gLabel = new System.Windows.Forms.Label();
            this.rLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.selectColorButton = new System.Windows.Forms.Button();
            this.figureInformationPanel.SuspendLayout();
            this.colorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // figureInformationPanel
            // 
            this.figureInformationPanel.Controls.Add(this.colorPanel);
            this.figureInformationPanel.Controls.Add(this.cancelButton);
            this.figureInformationPanel.Controls.Add(this.okButton);
            this.figureInformationPanel.Controls.Add(this.sidesTextBox);
            this.figureInformationPanel.Controls.Add(this.label1);
            this.figureInformationPanel.Location = new System.Drawing.Point(12, 12);
            this.figureInformationPanel.Name = "figureInformationPanel";
            this.figureInformationPanel.Size = new System.Drawing.Size(326, 266);
            this.figureInformationPanel.TabIndex = 14;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(174, 211);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(143, 44);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.okButton.Location = new System.Drawing.Point(9, 211);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(138, 44);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // sidesTextBox
            // 
            this.sidesTextBox.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sidesTextBox.Location = new System.Drawing.Point(93, 19);
            this.sidesTextBox.Name = "sidesTextBox";
            this.sidesTextBox.Size = new System.Drawing.Size(224, 25);
            this.sidesTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sides:";
            // 
            // colorPanel
            // 
            this.colorPanel.Controls.Add(this.bLabel);
            this.colorPanel.Controls.Add(this.gLabel);
            this.colorPanel.Controls.Add(this.rLabel);
            this.colorPanel.Controls.Add(this.label7);
            this.colorPanel.Controls.Add(this.label8);
            this.colorPanel.Controls.Add(this.label9);
            this.colorPanel.Controls.Add(this.label10);
            this.colorPanel.Controls.Add(this.selectColorButton);
            this.colorPanel.Location = new System.Drawing.Point(0, 50);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(326, 137);
            this.colorPanel.TabIndex = 20;
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bLabel.Location = new System.Drawing.Point(257, 49);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(28, 27);
            this.bLabel.TabIndex = 22;
            this.bLabel.Text = "{}";
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gLabel.Location = new System.Drawing.Point(153, 49);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(28, 27);
            this.gLabel.TabIndex = 21;
            this.gLabel.Text = "{}";
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rLabel.Location = new System.Drawing.Point(49, 49);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(28, 27);
            this.rLabel.TabIndex = 20;
            this.rLabel.Text = "{}";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(218, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 27);
            this.label7.TabIndex = 19;
            this.label7.Text = "B:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(109, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 27);
            this.label8.TabIndex = 18;
            this.label8.Text = "G:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(9, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 27);
            this.label9.TabIndex = 17;
            this.label9.Text = "R:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(71, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 27);
            this.label10.TabIndex = 17;
            this.label10.Text = "Selected color:";
            // 
            // selectColorButton
            // 
            this.selectColorButton.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectColorButton.Location = new System.Drawing.Point(8, 85);
            this.selectColorButton.Name = "selectColorButton";
            this.selectColorButton.Size = new System.Drawing.Size(309, 44);
            this.selectColorButton.TabIndex = 15;
            this.selectColorButton.Text = "Select color";
            this.selectColorButton.UseVisualStyleBackColor = true;
            this.selectColorButton.Click += new System.EventHandler(this.selectColorButton_Click);
            // 
            // DrawingPolygonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 284);
            this.Controls.Add(this.figureInformationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DrawingPolygonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Polygon";
            this.Load += new System.EventHandler(this.DrawingPolygonForm_Load);
            this.figureInformationPanel.ResumeLayout(false);
            this.figureInformationPanel.PerformLayout();
            this.colorPanel.ResumeLayout(false);
            this.colorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel figureInformationPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox sidesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button selectColorButton;
    }
}