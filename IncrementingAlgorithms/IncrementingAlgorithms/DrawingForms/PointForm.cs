using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncrementingAlgorithms.DrawingForms
{
    public partial class PointForm : Form
    {
        private int _sidesLeft;

        public List<Point> Points { get; } = new List<Point>();

        public PointForm(int sidesLeft)
        {

            _sidesLeft = sidesLeft;
            InitializeComponent();

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            if (_sidesLeft != 1)
            {
                PointForm form = new PointForm(_sidesLeft - 1);
                form.ShowDialog();
                Points.AddRange(form.Points);
                form.Dispose();
            }

            int x = int.Parse(xTextBox.Text);
            int y = int.Parse(yTextBox.Text);
            Points.Add(new Point(x,y));
            this.Close();


        }
    }
}
