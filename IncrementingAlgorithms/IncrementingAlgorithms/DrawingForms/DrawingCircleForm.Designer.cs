
namespace IncrementingAlgorithms.DrawingForms
{
    partial class DrawingCircleForm
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
            this.ycTextBox = new System.Windows.Forms.TextBox();
            this.xcTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.figureInformationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // figureInformationPanel
            // 
            this.figureInformationPanel.Controls.Add(this.radiusTextBox);
            this.figureInformationPanel.Controls.Add(this.label3);
            this.figureInformationPanel.Controls.Add(this.cancelButton);
            this.figureInformationPanel.Controls.Add(this.okButton);
            this.figureInformationPanel.Controls.Add(this.ycTextBox);
            this.figureInformationPanel.Controls.Add(this.xcTextBox);
            this.figureInformationPanel.Controls.Add(this.label2);
            this.figureInformationPanel.Controls.Add(this.label1);
            this.figureInformationPanel.Location = new System.Drawing.Point(12, 12);
            this.figureInformationPanel.Name = "figureInformationPanel";
            this.figureInformationPanel.Size = new System.Drawing.Size(202, 227);
            this.figureInformationPanel.TabIndex = 14;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(9, 174);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(178, 44);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.okButton.Location = new System.Drawing.Point(9, 124);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(178, 44);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ycTextBox
            // 
            this.ycTextBox.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ycTextBox.Location = new System.Drawing.Point(109, 54);
            this.ycTextBox.Name = "ycTextBox";
            this.ycTextBox.Size = new System.Drawing.Size(78, 25);
            this.ycTextBox.TabIndex = 8;
            // 
            // xcTextBox
            // 
            this.xcTextBox.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xcTextBox.Location = new System.Drawing.Point(109, 14);
            this.xcTextBox.Name = "xcTextBox";
            this.xcTextBox.Size = new System.Drawing.Size(78, 25);
            this.xcTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Xc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Radius:";
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radiusTextBox.Location = new System.Drawing.Point(109, 92);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(78, 25);
            this.radiusTextBox.TabIndex = 14;
            // 
            // CircleDrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 249);
            this.Controls.Add(this.figureInformationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CircleDrawingForm";
            this.Text = "Circle";
            this.Load += new System.EventHandler(this.DrawingCircleForm_Load);
            this.figureInformationPanel.ResumeLayout(false);
            this.figureInformationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel figureInformationPanel;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox ycTextBox;
        private System.Windows.Forms.TextBox xcTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}