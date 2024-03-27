namespace Progetto_Bonetalli {
    public partial class Form1: Form {
        private int SIZE = 10;
        private int[,] board;
        private int currentNumber = 1;
        private int PANELSIZE = 60;
        private Panel[,] panels;
        private (int, int) startPosition = (-1, -1);
        private int delay = 500;
        private bool isExecuting = false;
        private int[,] possibleMoves = { { 0, -3 }, { 2, -2 }, { 3, 0 }, { 2, 2 }, { 0, 3 }, { -2, 2 }, { -3, 0 }, { -2, -2 } };
        private List<(int, int)> moves = new List<(int, int)>();

        public Form1() {
            InitializeComponent();
            board = new int[SIZE, SIZE];
            panels = new Panel[SIZE, SIZE];
        }

        private void Form1_Load(object sender, EventArgs e) {
            generateBoard();
        }
        private void generateBoard() {

            for (int col = 0; col < SIZE; col++) {
                for (int row = 0; row < SIZE; row++) {
                    Panel p = new Panel {
                        Size = new Size(PANELSIZE, PANELSIZE),
                        Location = new Point(PANELSIZE * col + (Size.Width / 18), PANELSIZE * row + (Size.Height / 18)),
                        BorderStyle = BorderStyle.FixedSingle,
                    };

                    Label l = new Label {
                        Text = $"",
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill,
                        Size = new Size(PANELSIZE, PANELSIZE),
                        Font = new Font("Inder", 12),
                        Parent = p,
                    };
                    l.Click += new EventHandler(Label_Click);

                    p.Controls.Add(l);

                    panels[col, row] = p;
                    Controls.Add(p);
                    board[col, row] = 0;
                }
            }
        }

        private void Label_Click(object sender, EventArgs e) {
            if (currentNumber == 1) {
                Label label = (Label)sender;
                startPosition = GetRowColFromLocation(label.Parent.Location, PANELSIZE, PANELSIZE / 18);
                UpdateBoard(startPosition.Item1, startPosition.Item2);
                StartButton.Enabled = true;
            }
        }

        private void StartButton_Click(object sender, EventArgs e) {
            if (!isExecuting) {
                isExecuting = true;
                delay = trackBar1.Value;
                SolvePuzzle(startPosition.Item1, startPosition.Item2, ref delay);
                ResetButton.Enabled = true;
            }
        }

        public static void wait(int milliseconds) {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) => {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled) {
                Application.DoEvents();
            }
        }

        private void StartButton_EnabledChanged(object sender, EventArgs e) {
            Button button = (Button)sender;
            if (button.Enabled) {
                label1.Visible = false;
            } else {
                label1.Visible = true;
            }
        }

        private bool IsValidMove(int x, int y) {
            return x >= 0 && x < SIZE && y >= 0 && y < SIZE && board[y, x] == 0;
        }

        private int CountValidMoves(int x, int y, int[,] possibleMoves) {
            int validMoves = 0;
            for (int i = 0; i < possibleMoves.GetLength(0); i++) {
                int nextX = x + possibleMoves[i, 0];
                int nextY = y + possibleMoves[i, 1];
                bool validMove = IsValidMove(nextX, nextY);
                if (validMove) {
                    validMoves++;
                }
            }
            return validMoves;
        }

        private bool SolvePuzzle(int x, int y, ref int delay) {

            if (currentNumber > (SIZE * SIZE)) {

                return true;
            }
            moves.Clear();

            FindNextMoves(x, y, possibleMoves, moves);
            int moveToMake = ChooseNextMove(moves);
            int moveX = 0;
            int moveY = 0;

            try {
                moveX = x + possibleMoves[moveToMake, 0];
                moveY = y + possibleMoves[moveToMake, 1];
            } catch (Exception e) {
                if (e.GetType() == typeof(IndexOutOfRangeException)) {
                    MessageBox.Show("Soluzione non trovata.");
                    ResetBoard();
                    return false;
                }
            }

            if (IsValidMove(moveX, moveY)) {
                UpdateBoard(moveX, moveY);
            }
            wait(delay);

            if (SolvePuzzle(moveX, moveY, ref delay)) {
                isExecuting = false;
                return true;
            }
            return false;
        }

        private void FindNextMoves(int x, int y, int[,] possibleMoves, List<(int, int)> moves) {
            for (int i = 0; i < possibleMoves.GetLength(0); i++) {
                int nextX = x + possibleMoves[i, 0];
                int nextY = y + possibleMoves[i, 1];
                bool validMove = IsValidMove(nextX, nextY);
                if (validMove) {
                    int numberOfPossibleMoves = CountValidMoves(nextX, nextY, possibleMoves);
                    moves.Add((numberOfPossibleMoves, i));
                }
            }
        }

        private int ChooseNextMove(List<(int, int)> moves) {
            int min = int.MaxValue;
            int indexOfMin = -1;
            foreach ((int, int) option in moves) {
                if (option.Item1 < min) {
                    min = option.Item1;
                    indexOfMin = option.Item2;
                }
            }

            return indexOfMin;
        }

        private void UpdateBoard(int x, int y) {

            board[y, x] = currentNumber;
            foreach (Control control in panels[x, y].Controls) {
                if (control.GetType() == typeof(Label)) {
                    control.Text = currentNumber.ToString();
                    control.BackColor = Color.Green;
                }
            }
            currentNumber++;
        }

        private (int, int) GetRowColFromLocation(Point location, int sizeOfControl, int offset) {
            return ((location.X - offset) / sizeOfControl, (location.Y - offset) / sizeOfControl);
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            ResetBoard();
            ResetButton.Enabled = false;
            StartButton.Enabled = false;
        }

        private void ResetBoard() {
            foreach (Panel panel in panels) {
                foreach (Control control in panel.Controls) {
                    if (control.GetType() == typeof(Label)) {
                        control.Text = "";
                        control.BackColor = Color.White;
                    }
                }
                (int, int) position = GetRowColFromLocation(panel.Location, PANELSIZE, PANELSIZE / 18);
                board[position.Item2, position.Item1] = 0;
                currentNumber = 1;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e) {
            label3.Text = $"{(float)trackBar1.Value / 1000,2}s";
            delay = trackBar1.Value;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}