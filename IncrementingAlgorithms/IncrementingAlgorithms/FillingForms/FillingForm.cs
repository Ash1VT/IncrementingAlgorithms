using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncrementingAlgorithms.FillingForms
{
    public partial class FillingForm : Form
    {

        public int X { get; private set; }
        public int Y { get; private set; }

        public Color FillingColor { get; private set; }
        public FillingForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            X = int.Parse(xTextBox.Text);
            Y = int.Parse(yTextBox.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void selectColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FillingColor = dialog.Color;
            }
            dialog.Dispose();
            InitRgbLabels();
        }

        private void InitRgbLabels()
        {
            rLabel.Text = FillingColor.R.ToString();
            gLabel.Text = FillingColor.G.ToString();
            bLabel.Text = FillingColor.B.ToString();
        }

        private void FillingForm_Load(object sender, EventArgs e)
        {
            FillingColor = Color.Black;
            InitRgbLabels();
        }
    }
}
