using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Shapes;

namespace canvasExample
{
    public partial class MainWindow : Window
    {
        private Random random = new Random();
        private bool isFullScreen = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtNumberOfShapes.Text, out int numberOfShapes) &&
                double.TryParse(txtShapeSize.Text, out double shapeSize))
            {
                string shapeType = (cmbShapeType.SelectedItem as ComboBoxItem)?.Content.ToString();
                string fillColorName = (cmbFillColor.SelectedItem as ComboBoxItem)?.Content.ToString();
                string strokeColorName = (cmbStrokeColor.SelectedItem as ComboBoxItem)?.Content.ToString();

                Brush fillBrush = GetBrushFromName(fillColorName);
                Brush strokeBrush = GetBrushFromName(strokeColorName);

                for (int i = 0; i < numberOfShapes; i++)
                {
                    Shape shape;
                    if (shapeType == "Ellipse")
                    {
                        shape = new Ellipse();
                    }
                    else if (shapeType == "Rectangle")
                    {
                        shape = new Rectangle();
                    }
                    else
                    {
                        continue;
                    }

                    shape.Width = shapeSize;
                    shape.Height = shapeSize;
                    shape.Fill = fillBrush;
                    shape.Stroke = strokeBrush;
                    shape.StrokeThickness = 2;

                    if (chkShadow.IsChecked == true)
                    {
                        shape.Effect = new DropShadowEffect()
                        {
                            Color = Colors.Black,
                            Direction = 315,
                            ShadowDepth = 5,
                            Opacity = 0.5
                        };
                    }

                    canvasRajzlap.Children.Add(shape);

                    double left = random.NextDouble() * (canvasRajzlap.ActualWidth - shape.Width);
                    double top = random.NextDouble() * (canvasRajzlap.ActualHeight - shape.Height);
                    Canvas.SetLeft(shape, left);
                    Canvas.SetTop(shape, top);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for the number of shapes and shape size.");
            }
        }

        private Brush GetBrushFromName(string colorName)
        {
            switch (colorName)
            {
                case "Black": return Brushes.Black;
                case "Red": return Brushes.Red;
                case "Green": return Brushes.Green;
                case "Blue": return Brushes.Blue;
                case "Aquamarine": return Brushes.Aquamarine;
                default: return Brushes.Black;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            canvasRajzlap.Children.Clear();
        }

        private void btnFullScreen_Click(object sender, RoutedEventArgs e)
        {
            if (!isFullScreen)
            {
                this.WindowState = WindowState.Maximized;
                this.WindowStyle = WindowStyle.None;
                isFullScreen = true;
            }
            else
            {
                this.WindowState = WindowState.Normal;
                this.WindowStyle = WindowStyle.SingleBorderWindow;
                isFullScreen = false;
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Key == Key.Escape && isFullScreen)
            {
                this.WindowState = WindowState.Normal;
                this.WindowStyle = WindowStyle.SingleBorderWindow;
                isFullScreen = false;
            }
        }
    }
}