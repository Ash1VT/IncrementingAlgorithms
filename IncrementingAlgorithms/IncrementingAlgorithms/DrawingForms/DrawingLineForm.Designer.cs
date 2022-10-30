
namespace IncrementingAlgorithms.DrawingForms
{
    partial class DrawingLineForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.x1TextBox = new System.Windows.Forms.TextBox();
            this.y1TextBox = new System.Windows.Forms.TextBox();
            this.x2TextBox = new System.Windows.Forms.TextBox();
            this.y2TextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.figureInformationPanel = new System.Windows.Forms.Panel();
            this.figureInformationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "X1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(168, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "X2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(168, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y2:";
            // 
            // x1TextBox
            // 
            this.x1TextBox.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x1TextBox.Location = new System.Drawing.Point(62, 15);
            this.x1TextBox.Name = "x1TextBox";
            this.x1TextBox.Size = new System.Drawing.Size(95, 25);
            this.x1TextBox.TabIndex = 7;
            // 
            // y1TextBox
            // 
            this.y1TextBox.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.y1TextBox.Location = new System.Drawing.Point(222, 15);
            this.y1TextBox.Name = "y1TextBox";
            this.y1TextBox.Size = new System.Drawing.Size(95, 25);
            this.y1TextBox.TabIndex = 8;
            // 
            // x2TextBox
            // 
            this.x2TextBox.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x2TextBox.Location = new System.Drawing.Point(62, 55);
            this.x2TextBox.Name = "x2TextBox";
            this.x2TextBox.Size = new System.Drawing.Size(95, 25);
            this.x2TextBox.TabIndex = 9;
            // 
            // y2TextBox
            // 
            this.y2TextBox.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.y2TextBox.Location = new System.Drawing.Point(222, 55);
            this.y2TextBox.Name = "y2TextBox";
            this.y2TextBox.Size = new System.Drawing.Size(95, 25);
            this.y2TextBox.TabIndex = 10;
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.okButton.Location = new System.Drawing.Point(8, 95);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(160, 44);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(174, 95);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(143, 44);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // figureInformationPanel
            // 
            this.figureInformationPanel.Controls.Add(this.cancelButton);
            this.figureInformationPanel.Controls.Add(this.okButton);
            this.figureInformationPanel.Controls.Add(this.y2TextBox);
            this.figureInformationPanel.Controls.Add(this.x2TextBox);
            this.figureInformationPanel.Controls.Add(this.y1TextBox);
            this.figureInformationPanel.Controls.Add(this.x1TextBox);
            this.figureInformationPanel.Controls.Add(this.label4);
            this.figureInformationPanel.Controls.Add(this.label3);
            this.figureInformationPanel.Controls.Add(this.label2);
            this.figureInformationPanel.Controls.Add(this.label1);
            this.figureInformationPanel.Location = new System.Drawing.Point(9, 12);
            this.figureInformationPanel.Name = "figureInformationPanel";
            this.figureInformationPanel.Size = new System.Drawing.Size(325, 153);
            this.figureInformationPanel.TabIndex = 13;
            // 
            // DrawingLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 175);
            this.Controls.Add(this.figureInformationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DrawingLineForm";
            this.Text = "Line";
            this.Load += new System.EventHandler(this.DrawingLineForm_Load);
            this.figureInformationPanel.ResumeLayout(false);
            this.figureInformationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox x1TextBox;
        private System.Windows.Forms.TextBox y1TextBox;
        private System.Windows.Forms.TextBox x2TextBox;
        private System.Windows.Forms.TextBox y2TextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel figureInformationPanel;
    }
}