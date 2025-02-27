using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AStarAlgorithmFor8PuzzleGame
{
    public partial class GameForm : Form
    {
        private int stepIndex = 0;
        private Button shiftableButton;
        private List<BoardState> solutionOfBoardState;

        private bool inGame = false;

        private string thema = "#082c30";

        private static GlobalExceptionHandler exceptionHandler;

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        public GameForm()
        {
            InitializeComponent();

            exceptionHandler = new GlobalExceptionHandler(this);

            shiftableButton = new Button();
            shiftableButton.BackColor = Color.LightBlue;
            shiftableButton.Visible = false;
            shiftableButton.FlatAppearance.BorderSize = 0;
            shiftableButton.FlatStyle = FlatStyle.Flat;
            this.Controls.Add(shiftableButton);
            shiftableButton.BringToFront();
            this.BackColor = ColorTranslator.FromHtml(thema);

            // Change the title bar color
            IntPtr hWnd = this.Handle;
            int attrValue = 2; // 2 = dark mode, 1 = light mode
            DwmSetWindowAttribute(hWnd, DWMWA_USE_IMMERSIVE_DARK_MODE, ref attrValue, sizeof(int));
        }
        [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]

        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private void button10_Click(object sender, EventArgs e)
        {
            //CLEAR INPUTS HERE..
            GameForm gameForm = new GameForm();
            this.Hide();
            gameForm.ShowDialog();
            this.Close();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (stepIndex < solutionOfBoardState.Count)
            {
                updateBoardStatus(solutionOfBoardState[stepIndex]);
                labelStep.Text = $"Step: {stepIndex}";
                labelF.Text = $"F = G + H => {solutionOfBoardState[stepIndex].g} + {solutionOfBoardState[stepIndex].h} = {solutionOfBoardState[stepIndex].f}";
                stepIndex++;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (inGame)
            {
                return;
            }

            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                string textBoxName = textBox.Name.ToLower();
                int.TryParse(textBoxName.Replace("textbox", ""), out int number);
                string checkName = "txtbxstart" + textBoxName.Replace("textbox", "");

                Button button = (Button)(this.Controls["Button" + number]);

                if(number > 9)
                {
                    exceptionHandler.checkGoalTextBox(checkName);
                }
                else
                {
                    exceptionHandler.checkStartTextBox(checkName);

                    if(textBox.Text == "0")
                    {
                        button.Visible = false;
                    }
                    else
                    {
                        button.Visible = true;
                    }

                    button.Text = textBox.Text;
                }
                
                if(number == 18)
                {
                    button_start.Focus();
                }

                // Form içindeki kontrolleri bulup TabIndex'e göre sıradakine odaklan
                Control nextControl = GetNextControl(textBox);
                if (nextControl != null)
                    nextControl.Focus();
            }
        }

        private Control GetNextControl(TextBox currentTextBox)
        {
            int nextTabIndex = currentTextBox.TabIndex + 1;
            return this.Controls.Cast<Control>()
                       .FirstOrDefault(c => c.TabIndex == nextTabIndex);
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (inGame)
            {
                return;
            }
            try
            {
                int[,] startState = getStartState();
                int[,] goalState = getGoalState();
                inGame = true;

                button_stop.Visible = true;
                button_stop.Enabled = true;

                exceptionHandler.checkAllTextBox();

                if (startState == goalState)
                {
                    throw new Exception("Initial State and Goal State cannot be the same !");
                }

                var elementsInMatrix2 = goalState.Cast<int>().ToList();

                foreach (int item in startState)
                {
                    if (!elementsInMatrix2.Contains(item))
                    {
                        throw new FormatException("Initial State numbers are not matching with Goal State numbers.");
                    }
                }

                BoardStateSolver solver = new BoardStateSolver(startState, goalState);
                solutionOfBoardState = solver.solveBoard();

                if (solutionOfBoardState != null)
                {
                    MessageBox.Show("Solution Found !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stepIndex = 0;
                    timer1.Interval = 1000; // TIMER INTERVAL
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("Solution Not Found !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                changeEnableInputs(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int[,] getStartState()
        {
            int[,] startState = new int[3, 3];

            bool includeZero = false;

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    int.TryParse(this.Controls["textBox" + (i * 3 + k + 1)].Text, out int number);

                    if (number == 0)
                    {
                        includeZero = true;
                    }

                    startState[i, k] = number;
                }
            }
            if (!includeZero)
            {
                throw new FormatException("Initial state must include zero.");
            }
            else
            {
                return startState;
            }
        }

        private int[,] getGoalState()
        {
            int[,] goalState = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    int.TryParse(this.Controls["textBox" + (i * 3 + k + 10)].Text, out int number);
                    goalState[i, k] = number;
                }
            }
            return goalState;
        }

        private int[] findButtonXandYPoint(Tile[,] tile)
        {
            int oldk;
            int oldm;

            for (int k = 0; k < 3; k++)
            {
                for (int m = 0; m < 3; m++)
                {
                    if (tile[k, m].Value == 0)
                    {
                        oldk = k;
                        oldm = m;
                        int[] array = { k, m };

                        return array;
                    }
                }
            }
            return null;
        }

        private void shiftButton(Button button, Button destinationButton)
        {
            Point destination = destinationButton.Location;
            int x = button.Location.X;
            int y = button.Location.Y;

            button.Refresh();
            System.Threading.Thread.Sleep(600);

            while (x != destination.X || y != destination.Y)
            {
                if (x < destination.X)
                {
                    x++;
                }
                else if (x > destination.X)
                {
                    x--;
                }
                if (y < destination.Y)
                {
                    y++;
                }
                else if (y > destination.Y)
                {
                    y--;
                }
                button.Location = new Point(x, y);
                button.Refresh();
                //System.Threading.Thread.Sleep(1); // Sleep for 1 ms BURASI KAYARKEN KI YAVASLIGI AYARLAMA
            }
        }

        private void updateBoardStatus(BoardState boardState)
        {
            if (boardState.parent != null)
            {
                int[] oldPosition = findButtonXandYPoint(boardState.parent.tiles);
                int[] newPosition = findButtonXandYPoint(boardState.tiles);

                int oldIndex = oldPosition[0] * 3 + oldPosition[1] + 1;
                int newIndex = newPosition[0] * 3 + newPosition[1] + 1;
                Button newButton = (Button)(this.Controls["Button" + newIndex]);
                newButton.BackColor = ColorTranslator.FromHtml(thema);
                Button oldButton = (Button)(this.Controls["Button" + oldIndex]);
                
                oldButton.Visible = false;
                System.Threading.Thread.Sleep(1000);

                shiftableButton.Size = newButton.Size;
                shiftableButton.Location = newButton.Location;
                shiftableButton.Visible = true;
                shiftableButton.BringToFront();
                shiftableButton.Text = newButton.Text;
                shiftableButton.Font = newButton.Font;

                shiftableButton.Visible = true;

                newButton.Visible = false;
                System.Threading.Thread.Sleep(1000);
                shiftButton(shiftableButton, oldButton);

                oldButton.Visible = true;
                newButton.Visible = true;

                shiftableButton.Visible = false;
                System.Threading.Thread.Sleep(1000);
            }

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    int number = boardState.tiles[i, k].Value;
                    int index = i * 3 + k + 1;
                    
                    if(number == 0)
                    {
                        this.Controls["Button" + index].Text = "";
                        this.Controls["Button" + index].Visible = false;
                    }
                    else
                    {
                        this.Controls["Button" + index].Text = number.ToString();
                        this.Controls["Button" + index].BackColor = SystemColors.ControlDark;
                    }
                }
            }

            if (boardState.possibleMoves == null || boardState.possibleMoves.Count == 0)
            {
                changeEnableInputs(true);
                button_stop.Enabled = false;
                inGame = false;
                return; // Burada belki en son bosluk degerinin eski rengine donmesi saglanabilir...
            }

            for (int i = 0; i < boardState.possibleMoves.Count; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    for (int m = 0; m < 3; m++)
                    {
                        if (boardState.possibleMoves[i].tiles[k, m].Value == 0)
                        {
                            int index = k * 3 + m + 1;
                            this.Controls["Button" + index].BackColor = ColorTranslator.FromHtml("#026b46");
                        }
                    }
                }
            }
        }

        private void changeEnableInputs(bool enable)
        {
            for (int i = 1; i < 19; i++)
            {
                this.Controls["textBox" + i].Enabled = enable;
            }

            /*this.Controls["button_start"].Enabled = enable;
            this.Controls["button10"].Enabled = enable;*/

            // BUTTON 10 ENABLED FALSE YAPTIGIMIZ ZAMAN FONT COLOR DEGISTIGI ICIN INGAME GIBI BIR METHOD EKLE... BU INGAME
            //KISMI START BASLADIGINDA IF ICINDE KONTROL ET EGER TRUE ISE RETURN ETSIN YANI BUTONLAR BASILABILIR AMA ISLEVSIZ OLUR..
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            if(button_stop.Text == "PAUSE")
            {
                timer1.Stop();
                button_stop.Text = "CONTINUE";
                button_stop.BackColor = Color.Green;
            }
            else
            {
                timer1.Start();
                button_stop.Text = "PAUSE";
                button_stop.BackColor = Color.Maroon;
            }
        }

    }
}