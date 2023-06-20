using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Collections.Generic;


namespace BuildGraphics
{
    public partial class Graph : Form
    {
        private List<List<PointF>> values;
        private List<string> namesOfGraphs;
        private List<Pen> graphPens; 
        private float zoombyX;
        private float zoombyY;
        private int graphWidth;
        private int graphHeight;

        public Graph()
        {
            InitializeComponent();
            values = new List<List<PointF>>();
            namesOfGraphs = new List<string>();
            graphPens = new List<Pen>();
            zoombyX = 1;
            zoombyY = 1;
            pictureBoxGraph.Paint += PictureBox_Paint;
            KeyDown += Graph_KeyDown;
            KeyPreview = true;
            graphWidth = 700; 
            graphHeight = 450;    
        }
        
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics g = e.Graphics;
            DrawGraph(g);
        }

        private void btnMaroon_Click(object sender, EventArgs e)
        {
            if(values.Count > 0)
            {
                Color pens = ((Button)sender).BackColor;
                graphPens.Add(new Pen(pens, 1));
            }
            else
            {
                MessageBox.Show("There is no graph to which the color can be attributed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Graph_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right: // "->"
                    zoombyX += 0.1f;
                    break;
                case Keys.Left: // "<-"
                    zoombyX -= 0.1f;
                    zoombyX = Math.Max(0.1f, zoombyX);
                    break;
                case Keys.Up: // "↑"
                    zoombyY += 0.1f;
                    break;
                case Keys.Down: // "↓"
                    zoombyY -= 0.1f;
                    zoombyY = Math.Max(0.1f, zoombyY);
                    break;
                default:
                    return;
            }
            pictureBoxGraph.Invalidate();
        }

        private void DrawGraph(System.Drawing.Graphics g)
            {
            int width = pictureBoxGraph.Width;
            int height = pictureBoxGraph.Height;

            g.Clear(Color.White);
            Pen axisPen = new Pen(Color.Black, 1);
            Font font = new Font(FontFamily.GenericSansSerif, 10);
            Font grid = new Font(FontFamily.GenericSansSerif, 9);
            float xCenter = width / 2; // знаходимо центр pictureBox для відображення осей
            float yCenter = height / 2;

            //малюємо осі координат
            g.DrawLine(axisPen, xCenter, 0, xCenter, height); // вісь OY
            g.DrawLine(axisPen, xCenter - 10, 10, xCenter, 0);
            g.DrawLine(axisPen, xCenter + 10, 10, xCenter, 0);
            g.DrawString("Y", font, Brushes.DarkBlue, xCenter - 20, 0);

            g.DrawLine(axisPen, 0, yCenter, width, yCenter); // вісь OX
            g.DrawLine(axisPen, width - 10, yCenter - 10, width, yCenter);
            g.DrawLine(axisPen, width - 10, yCenter + 10, width, yCenter);
            g.DrawString("X", font, Brushes.DarkBlue, width - 10, yCenter - 20);
            g.DrawString("0", font, Brushes.DarkBlue, xCenter - 10, yCenter + 2);

            // малювання сітки і системи координат
            float spacingY = (height - 30) / 25; 
            float spacingX = (width - 30) / 25;
            Pen linePen = new Pen(Color.Gray, 1);
            int k;
            k = -1;
            for (float i = xCenter - spacingX; i >= 15; i -= spacingX)
            {
                g.DrawLine(linePen, i, 0, i, height);
                g.DrawString(k.ToString(), grid, Brushes.Black, i - 10, yCenter + 2);
                k--;
            }
            k = 1;
            for (float i = xCenter + spacingX; i <= width - 15; i += spacingX)
            {
                g.DrawLine(linePen, i, 0, i, height);
                g.DrawString(k.ToString(), grid, Brushes.Black, i - 10, yCenter + 2);
                k++;
            }
            k = 1;
            for (float i = yCenter - spacingY; i >= 15; i -= spacingY)
            {
                g.DrawLine(linePen, 0, i, width, i);
                g.DrawString(k.ToString(), grid, Brushes.Black, xCenter - 18, i);
                k++;
            }
            k = -1;
            for (float i = yCenter + spacingY; i <= height - 15; i += spacingY)
            {
                g.DrawLine(linePen, 0, i, width, i);
                g.DrawString(k.ToString(), grid, Brushes.Black, xCenter - 18, i);
                k--;
            }

            //малювання графіку
            for (int j = 0; j < values.Count; j++)
            {
                List<PointF> data = values[j];
                Pen pen = graphPens[j];
                for (int i = 1; i < data.Count; i++)
                {
                    PointF p1 = data[i - 1];
                    PointF p2 = data[i];
                    if (!p1.IsEmpty && !p2.IsEmpty)
                    {
                        float x1 = xCenter + p1.X * spacingX*zoombyX;
                        float y1 = yCenter - p1.Y * spacingY*zoombyY;
                        float x2 = xCenter + p2.X * spacingX*zoombyX;
                        float y2 = yCenter - p2.Y * spacingY*zoombyY;
                        g.DrawLine(pen, x1, y1, x2, y2);
                    }
                }
            }
        }

            private List<PointF> ReadFile(string filename)
           {
            List<PointF> data = new List<PointF>();
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] datesforgraph = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (datesforgraph.Length == 2)
                        {
                            if (datesforgraph[1].Equals("empty"))
                            {
                                data.Add(PointF.Empty);
                            }
                            else
                            {
                                if (float.TryParse(datesforgraph[0], out float x) && float.TryParse(datesforgraph[1], out float y)) //TryParse - спроба конвертувати, 
                                {
                                    data.Add(new PointF(x, y));
                                }
                            }
                        }
                    }
                }
                return data;
            }
            catch (Exception ex) // якщо виключення
            {
                MessageBox.Show("Error reading data file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "d:\\Education\\Practice\\Functions\\test\\";
                openFileDialog.Filter = "Text Files|*.txt";
                openFileDialog.RestoreDirectory = true;

                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string filename = openFileDialog.FileName;
                    List<PointF> data = ReadFile(filename);
                    if (data != null)
                    {
                        values.Add(data);
                    }
                }
            }
        }

        private void CreateGraphBtn_Click(object sender, EventArgs e)
        {
            if (values.Count > 0)
            {
                pictureBoxGraph.Invalidate();
                AddLegends();
            }
            else
            {
                MessageBox.Show("Have no data to build", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void AddLegends()
        {
            groupofLegends.Controls.Clear();
            int vertical = 20;

            FlowLayoutPanel positionofLegend = new FlowLayoutPanel();
            positionofLegend.FlowDirection = FlowDirection.LeftToRight;
            positionofLegend.AutoSize = true;
            positionofLegend.AutoSizeMode = AutoSizeMode.GrowAndShrink; // розмір елемента не може бути змінен вручну
            positionofLegend.Location = new Point(10, vertical);

            for (int i = 0; i < namesOfGraphs.Count; i++)
            {
                string graphName = namesOfGraphs[i];
                Pen graphPen = graphPens[i];

                Label Legend = new Label();
                Legend.AutoSize = true;
                Legend.Width = 60;
                Legend.Height = 4;
                Legend.Margin = new Padding(0, 0, 20, 0); // простір між легендами
                Legend.Text = "  - " + graphName;
                Legend.ForeColor = Color.Black;

                Legend.Paint += (sender, e) =>
                {
                    using (Pen linePen = new Pen(graphPen.Color))
                    {
                        int lineY = Legend.Height / 2;
                        e.Graphics.DrawLine(linePen, 0, lineY, 7, lineY);
                    }
                };
                positionofLegend.Controls.Add(Legend);
            }

            groupofLegends.Controls.Add(positionofLegend);
        }

        private void agreebtn_Click(object sender, EventArgs e)
        {
            string name = nameOfGraph.Text;
            if(name != "Name of graph")
            {
                int flag = 0;
                for(int i=0; i < namesOfGraphs.Count; i++)
                {
                    if (namesOfGraphs[i] == name)
                    {
                        flag++; break;
                    }
                }
                if(flag == 0)
                {
                    namesOfGraphs.Add(name);
                }
                else
                {
                    MessageBox.Show("This name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You haven't written anything else in the textfield", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Movegraph_Click(object sender, EventArgs e)
        {
            if(values.Count > 0)
            {
                string graph = namemove.Text;
                string movingX = moveOX.Text;
                string movingY = moveOY.Text;
                if ( !string.IsNullOrEmpty(graph) && !string.IsNullOrEmpty(movingX) && !string.IsNullOrEmpty(movingY))
                {
                    int selected = -1;

                    for (int i = 0; i < namesOfGraphs.Count; i++)
                    {
                        if (graph == namesOfGraphs[i])
                        {
                            selected = i;
                            break;
                        }
                    }

                    if (selected == -1)
                    {
                        MessageBox.Show("There is no such graph of function", "Error");
                    }
                    else
                    {
                        float x = float.Parse(movingX); //конвертація у тип float
                        float y = float.Parse(movingY);
     
                        for(int i = 0; i < values[selected].Count; i++)
                        {
                            values[selected][i] = new PointF(values[selected][i].X + x, values[selected][i].Y + y);
                        }
                        pictureBoxGraph.Invalidate();
                    }
                }
                else
                {
                    MessageBox.Show("You haven't written anything in the text field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("There is no graph to which the title can be attributed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            values.Clear();
            namesOfGraphs.Clear();
            graphPens.Clear();
            groupofLegends.Controls.Clear();
            pictureBoxGraph.Invalidate();
        }

        private void pictureBoxGraph_Paint(object sender, PaintEventArgs e)
        {
            DrawGraph(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e) { }
    }
}

















