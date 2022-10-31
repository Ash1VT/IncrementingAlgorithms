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

        private List<Figure> _figures = new List<Figure>();
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
                
                DrawFigure(figure);
                _figures.Add(figure);
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
                    "Polygon",
                    "Moving line"
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

        private void DrawFigure(Figure figure)
        {
            Bitmap bitmap = new Bitmap(drawingPictureBox.Image);
            figure.Draw(bitmap);
            drawingPictureBox.Image = bitmap;
        }

        private void DrawAllFigures()
        {
            _figures.ForEach(DrawFigure);
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
                case "Moving line":
                {
                    DrawingMovingLineForm form = new DrawingMovingLineForm(Utils.GetMovingLines(_figures));
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            ResetDrawingPictureBox();
            if (_figures.Find(x => x is MovingLine) != null)
            {
                List<MovingLine> movingLines = Utils.GetMovingLines(_figures);
                movingLines.ForEach((MovingLine line) => Utils.MoveLine(line, line.RotationalCenter, line.AngularSpeed, timer1.Interval, line.Clockwise));
            }
            DrawAllFigures();

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ResetDrawingPictureBox();
            _figures.Clear();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm form = new InfoForm(_figures);
            form.ShowDialog();
            form.Dispose();
        }
    }
}
