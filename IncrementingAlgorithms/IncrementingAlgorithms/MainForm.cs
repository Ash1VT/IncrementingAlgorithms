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
        private MovingLine _line1;
        private MovingLine _line2;
        private MovingLine _line3;



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

            _line = new MovingLine(new PointF(250, 200), new PointF(150, 200), 0, 30, false);
            _line1 = new MovingLine(new PointF(150, 150), new PointF(150, 250), 50, 50, true);
            _line2 = new MovingLine(new PointF(100, 150), new PointF(150, 150), 50, 20, false);
            _line3 = new MovingLine(new PointF(120, 100), new PointF(120, 200), 50, 90, true);

            _line.Line = _line1;
            _line1.Line = _line2;
            _line2.Line = _line3;

            DrawFigure(_line, Color.Black);
            DrawFigure(_line1, Color.Blue);
            DrawFigure(_line2, Color.Red);
            DrawFigure(_line3, Color.DarkGreen);


            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ResetDrawingPictureBox();
            _line = Utils.MoveLine(_line, _line.RotationalCenter, _line.AngularSpeed, timer1.Interval, _line.Clockwise);
            _line1 = _line.Line;

            _line1 = Utils.MoveLine(_line1, _line1.RotationalCenter, _line1.AngularSpeed, timer1.Interval,
                _line1.Clockwise);
            _line2 = _line1.Line;

            _line2 = Utils.MoveLine(_line2, _line2.RotationalCenter, _line2.AngularSpeed, timer1.Interval,
                _line2.Clockwise);
            _line3 = _line2.Line;

            _line3 = Utils.MoveLine(_line3, _line3.RotationalCenter, _line3.AngularSpeed, timer1.Interval,
               _line3.Clockwise);
            _line.Line = _line1;
            _line1.Line = _line2;
            _line2.Line = _line3;


            DrawFigure(_line, Color.Black);
            DrawFigure(_line1, Color.Blue);
            DrawFigure(_line2, Color.Red);
            DrawFigure(_line3, Color.DarkGreen);

        }
    }
}
