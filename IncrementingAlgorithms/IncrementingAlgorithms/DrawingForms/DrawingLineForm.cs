using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IncrementingAlgorithms.Figures;

namespace IncrementingAlgorithms.DrawingForms
{
    public partial class DrawingLineForm : FigureForm
    {
        public DrawingLineForm()
        {
            InitializeComponent();
        }
        private void DrawingLineForm_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(x1TextBox.Text);
            int y1 = int.Parse(y1TextBox.Text);
            int x2 = int.Parse(x2TextBox.Text);
            int y2 = int.Parse(y2TextBox.Text);

            


            Figure = new Line(
                new Point(x1, y1),
                new Point(x2, y2)
                );
            
            FigureCreated = true;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            FigureCreated = false;
            this.Close();
        }

   
    }
}
