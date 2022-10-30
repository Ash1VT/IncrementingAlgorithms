
namespace IncrementingAlgorithms.DrawingForms
{
    partial class DrawingRectangleForm
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
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.figureInformationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // figureInformationPanel
            // 
            this.figureInformationPanel.Controls.Add(this.heightTextBox);
            this.figureInformationPanel.Controls.Add(this.label4);
            this.figureInformationPanel.Controls.Add(this.widthTextBox);
            this.figureInformationPanel.Controls.Add(this.label2);
            this.figureInformationPanel.Controls.Add(this.cancelButton);
            this.figureInformationPanel.Controls.Add(this.okButton);
            this.figureInformationPanel.Controls.Add(this.yTextBox);
            this.figureInformationPanel.Controls.Add(this.xTextBox);
            this.figureInformationPanel.Controls.Add(this.label3);
            this.figureInformationPanel.Controls.Add(this.label1);
            this.figureInformationPanel.Location = new System.Drawing.Point(12, 12);
            this.figureInformationPanel.Name = "figureInformationPanel";
            this.figureInformationPanel.Size = new System.Drawing.Size(211, 275);
            this.figureInformationPanel.TabIndex = 14;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(8, 222);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(194, 44);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.okButton.Location = new System.Drawing.Point(8, 172);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(194, 44);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // yTextBox
            // 
            this.yTextBox.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yTextBox.Location = new System.Drawing.Point(107, 55);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(95, 25);
            this.yTextBox.TabIndex = 9;
            // 
            // xTextBox
            // 
            this.xTextBox.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xTextBox.Location = new System.Drawing.Point(107, 15);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(95, 25);
            this.xTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "X:";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.widthTextBox.Location = new System.Drawing.Point(107, 94);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(95, 25);
            this.widthTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Width:";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heightTextBox.Location = new System.Drawing.Point(107, 131);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(95, 25);
            this.heightTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 27);
            this.label4.TabIndex = 15;
            this.label4.Text = "Height:";
            // 
            // DrawingRectangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 299);
            this.Controls.Add(this.figureInformationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DrawingRectangleForm";
            this.Text = "Rectangle";
            this.Load += new System.EventHandler(this.DrawingRectangleForm_Load);
            this.figureInformationPanel.ResumeLayout(false);
            this.figureInformationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel figureInformationPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label label2;
    }
}