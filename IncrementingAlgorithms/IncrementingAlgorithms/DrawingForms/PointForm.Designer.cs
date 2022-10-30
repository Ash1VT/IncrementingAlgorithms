
namespace IncrementingAlgorithms.DrawingForms
{
    partial class PointForm
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
            this.nextButton = new System.Windows.Forms.Button();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.figureInformationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // figureInformationPanel
            // 
            this.figureInformationPanel.Controls.Add(this.nextButton);
            this.figureInformationPanel.Controls.Add(this.yTextBox);
            this.figureInformationPanel.Controls.Add(this.xTextBox);
            this.figureInformationPanel.Controls.Add(this.label2);
            this.figureInformationPanel.Controls.Add(this.label1);
            this.figureInformationPanel.Location = new System.Drawing.Point(12, 12);
            this.figureInformationPanel.Name = "figureInformationPanel";
            this.figureInformationPanel.Size = new System.Drawing.Size(170, 153);
            this.figureInformationPanel.TabIndex = 14;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nextButton.Location = new System.Drawing.Point(8, 94);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(149, 44);
            this.nextButton.TabIndex = 11;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // yTextBox
            // 
            this.yTextBox.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yTextBox.Location = new System.Drawing.Point(62, 52);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(95, 25);
            this.yTextBox.TabIndex = 8;
            // 
            // xTextBox
            // 
            this.xTextBox.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xTextBox.Location = new System.Drawing.Point(62, 15);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(95, 25);
            this.xTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y:";
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
            // PointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 172);
            this.Controls.Add(this.figureInformationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PointForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Point";
            this.figureInformationPanel.ResumeLayout(false);
            this.figureInformationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel figureInformationPanel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}