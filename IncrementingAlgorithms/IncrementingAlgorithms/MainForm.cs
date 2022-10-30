using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IncrementingAlgorithms.DrawingForms;
using IncrementingAlgorithms.Figures;

namespace IncrementingAlgorithms
{
    public partial class MainForm : Form
    {
        private MovingLine _line;
        private Circle _test;
        private Circle _test2;

        private Line _test1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitDrawingPictureBox();
            InitFiguresComboBox();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Figure figure = OpenDrawingForm((string)figuresComboBox.SelectedItem);
            if (figure != null)
            {
                if (!figure.Validate(drawingPictureBox.Width, drawingPictureBox.Height))
                {
                    MessageBox.Show("The entered coordinates are outside the drawing area", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               
                int R = int.Parse(rTextBox.Text);
                int G = int.Parse(gTextBox.Text);
                int B = int.Parse(bTextBox.Text);
                Color drawingColor = Color.FromArgb(R, G, B);
                
                DrawFigure(figure, drawingColor);
            }
        }

        private void InitFiguresComboBox()
        {
            figuresComboBox.Items.AddRange(
                new []
                {
                    "Line",
                    "Circle",
                    "Ellipse",
                    "Triangle",
                    "Rectangle",
                    "Polygon"
                });
        }

        private void InitDrawingPictureBox()
        {
            ResetDrawingPictureBox();
        }

        private void ResetDrawingPictureBox()
        {
            int width = drawingPictureBox.Width;
            int height = drawingPictureBox.Height;
            drawingPictureBox.Image = Utils.CreateEmptyImage(width, height, Color.White);
        }

        private void DrawFigure(Figure figure, Color drawingColor)
        {
            Bitmap bitmap = new Bitmap(drawingPictureBox.Image);
            figure.Draw(bitmap, drawingColor);
            drawingPictureBox.Image = bitmap;
        }
        private Figure GetFigureFromForm(FigureForm form)
        {
            form.ShowDialog();
            Figure figure = form.FigureCreated ? form.Figure : null;
            form.Dispose();
            return figure;
        }

        private Figure OpenDrawingForm(string figureName)
        {
            switch (figureName)
            {
                case "Line":
                {
                    DrawingLineForm form = new DrawingLineForm();
                    return GetFigureFromForm(form);
                }
                case "Circle":
                {
                    DrawingCircleForm form = new DrawingCircleForm();
                    return GetFigureFromForm(form);
                }
                case "Ellipse":
                {
                    DrawingEllipseForm form = new DrawingEllipseForm();
                    return GetFigureFromForm(form);
                }
                case "Triangle":
                {
                    DrawingTriangleFrom form = new DrawingTriangleFrom();
                    return GetFigureFromForm(form);
                }
                case "Rectangle":
                {
                    DrawingRectangleForm form = new DrawingRectangleForm();
                    return GetFigureFromForm(form);
                }
                case "Polygon":
                {
                    DrawingPolygonForm form = new DrawingPolygonForm();
                    return GetFigureFromForm(form);
                }
                default:
                {
                    MessageBox.Show("Cannot find figure with this name", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _line = new MovingLine(new Point(200, 200), new Point(100, 200), 80, 30, false);
            _test = new Circle(_line.RotationalCenter, _line.FirstPointRotationalRadius);
            _test2 = new Circle(_line.RotationalCenter, _line.SecondPointRotationalRadius);
            _test1 = new Line(new Point(60, 100), _line.RotationalCenter);
            

            DrawFigure(_line, Color.Black);
            DrawFigure(_test, Color.Aqua);
            DrawFigure(_test2, Color.Aqua);
            DrawFigure(_test1, Color.Red);


            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ResetDrawingPictureBox();
            _line = Utils.MoveLine(_line, timer1.Interval);
            
            DrawFigure(_line, Color.Black);
            DrawFigure(_test, Color.Aqua);
            DrawFigure(_test1, Color.Red);
            DrawFigure(_test2, Color.Aqua);
        }
    }
}
