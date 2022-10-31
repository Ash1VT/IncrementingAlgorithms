
namespace IncrementingAlgorithms.DrawingForms
{
    partial class InfoForm
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
            this.infoListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // infoListBox
            // 
            this.infoListBox.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoListBox.FormattingEnabled = true;
            this.infoListBox.ItemHeight = 23;
            this.infoListBox.Items.AddRange(new object[] {
            ""});
            this.infoListBox.Location = new System.Drawing.Point(0, 0);
            this.infoListBox.Name = "infoListBox";
            this.infoListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.infoListBox.Size = new System.Drawing.Size(487, 418);
            this.infoListBox.TabIndex = 1;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 418);
            this.Controls.Add(this.infoListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoForm";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox infoListBox;
    }
}