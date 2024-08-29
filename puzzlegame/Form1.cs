namespace odev5
{
    public partial class Form1 : Form
    {
        private const int GridSize = 5;
        private Button[,] buttons = new Button[GridSize, GridSize];
        private Point emptySlot;

        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
            ShuffleGrid();
            this.Resize += Form1_Resize; // Resize olayýný yakalayýn
        }

        private void InitializeGrid()
        {
            ResizeButtons();
            AssignNumbersToButtons();
        }

        private void ResizeButtons()
        {
            int buttonWidth = this.ClientSize.Width / GridSize;
            int buttonHeight = this.ClientSize.Height / GridSize;

            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    if (i == GridSize - 1 && j == GridSize - 1)
                    {
                        emptySlot = new Point(i, j);
                        continue;
                    }

                    if (buttons[i, j] == null)
                    {
                        buttons[i, j] = new Button();
                        buttons[i, j].Click += Button_Click;
                        this.Controls.Add(buttons[i, j]);
                    }

                    buttons[i, j].Size = new Size(buttonWidth, buttonHeight);
                    buttons[i, j].Location = new Point(i * buttonWidth, j * buttonHeight);
                }
            }
        }

        private void AssignNumbersToButtons()
        {
            int number = 1;
            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    if (buttons[i, j] != null)
                    {
                        buttons[i, j].Text = number.ToString();
                        number++;
                    }
                }
            }
        }

        private void ShuffleGrid()
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                List<Point> neighbors = GetNeighbors(emptySlot);
                Point swapWith = neighbors[random.Next(neighbors.Count)];
                SwapButtons(emptySlot, swapWith);
                emptySlot = swapWith;
            }
        }

        private List<Point> GetNeighbors(Point p)
        {
            List<Point> neighbors = new List<Point>();

            if (p.X > 0) neighbors.Add(new Point(p.X - 1, p.Y));
            if (p.X < GridSize - 1) neighbors.Add(new Point(p.X + 1, p.Y));
            if (p.Y > 0) neighbors.Add(new Point(p.X, p.Y - 1));
            if (p.Y < GridSize - 1) neighbors.Add(new Point(p.X, p.Y + 1));

            return neighbors;
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                Point buttonPos = GetButtonPosition(clickedButton);
                if (IsNeighbor(buttonPos, emptySlot))
                {
                    SwapButtons(buttonPos, emptySlot);
                    emptySlot = buttonPos;
                    CheckForWin();
                }
            }
        }

        private Point GetButtonPosition(Button? button)
        {
            if (button == null) return Point.Empty;

            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    if (buttons[i, j] == button)
                    {
                        return new Point(i, j);
                    }
                }
            }
            return Point.Empty;
        }

        private bool IsNeighbor(Point p1, Point p2)
        {
            return Math.Abs(p1.X - p2.X) + Math.Abs(p1.Y - p2.Y) == 1;
        }

        private void SwapButtons(Point p1, Point p2)
        {
            Button temp = buttons[p1.X, p1.Y];
            buttons[p1.X, p1.Y] = buttons[p2.X, p2.Y];
            buttons[p2.X, p2.Y] = temp;

            if (buttons[p1.X, p1.Y] != null)
            {
                buttons[p1.X, p1.Y].Location = new Point(p1.X * buttons[p1.X, p1.Y].Width, p1.Y * buttons[p1.X, p1.Y].Height);
            }

            if (buttons[p2.X, p2.Y] != null)
            {
                buttons[p2.X, p2.Y].Location = new Point(p2.X * buttons[p2.X, p2.Y].Width, p2.Y * buttons[p2.X, p2.Y].Height);
            }
        }

        private void CheckForWin()
        {
            bool won = true;
            int number = 1;

            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    if (i == GridSize - 1 && j == GridSize - 1)
                    {
                        continue;
                    }

                    if (buttons[i, j] == null || buttons[i, j].Text != number.ToString())
                    {
                        won = false;
                        break;
                    }
                    number++;
                }
                if (!won) break;
            }

            if (won)
            {
                MessageBox.Show("Congratulations! You've solved the puzzle!");
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeButtons();
        }
    }
}
