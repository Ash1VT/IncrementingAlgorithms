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
    public partial class InfoForm : Form
    {
        private List<Figure> _figures;
        public InfoForm(List<Figure> figures)
        {
            _figures = figures;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            infoListBox.Items.Clear();
            
            foreach (var figure in _figures)
            {
                infoListBox.Items.AddRange(figure.GetFullCharacteristics().Split('\n'));
                infoListBox.Items.Add(String.Empty);
            }
            
            
        }
    }
}
