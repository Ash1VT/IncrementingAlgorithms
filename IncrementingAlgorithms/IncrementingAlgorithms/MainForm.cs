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
using IncrementingAlgorithms.FillingAlgorithms;
using IncrementingAlgorithms.FillingForms;

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

        private void ApplyFillingAlgorithm(FillingAlgorithm algorithm)
        {
             Bitmap bitmap = new Bitmap(drawingPictureBox.Image);
             algorithm.Fill(bitmap);
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

        private void startButton_Click(object sender, EventArgs e)
        {
            renderingTimer.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            renderingTimer.Stop();
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

        private void renderingTimer_Tick(object sender, EventArgs e)
        {
            ResetDrawingPictureBox();
            if (_figures.Find(x => x is MovingLine) != null)
            {
                List<MovingLine> movingLines = Utils.GetMovingLines(_figures);
                movingLines.ForEach((MovingLine line) => Utils.MoveLine(line, line.RotationalCenter, line.AngularSpeed, renderingTimer.Interval, line.Clockwise));
            }
            DrawAllFigures();
        }

        private void simpleFillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillingForm form = new FillingForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Point startPoint = new Point(form.X, form.Y);
                Color fillingColor = form.FillingColor;

                SimpleFilling algorithm = new SimpleFilling(startPoint, fillingColor);
                ApplyFillingAlgorithm(algorithm);
            }
            form.Dispose();

        }

        private void waveFillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillingForm form = new FillingForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Point startPoint = new Point(form.X, form.Y);
                Color fillingColor = form.FillingColor;

                WaveFilling algorithm = new WaveFilling(startPoint, fillingColor);
                ApplyFillingAlgorithm(algorithm);
            }
            form.Dispose();
        }

        private void lineFillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillingForm form = new FillingForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Point startPoint = new Point(form.X, form.Y);
                Color fillingColor = form.FillingColor;

                LineFilling algorithm = new LineFilling(startPoint, fillingColor);
                ApplyFillingAlgorithm(algorithm);
            }
            form.Dispose();
        }
    }
}
