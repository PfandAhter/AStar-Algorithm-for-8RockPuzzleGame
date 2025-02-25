using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AStarAlgorithmFor8PuzzleGame
{
    public partial class GameForm : Form
    {

        private int stepIndex = 0;

        private int n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0, n6 = 0, n7 = 0, n8 = 0, n9 = 0, n10 = 0, n11 = 0, n12 = 0, n13 = 0, n14 = 0, n15 = 0, n16=0,n17=0,n18=0;

        private List<BoardState> solutionOfBoardState;
        public GameForm()
        {
            InitializeComponent();
            addPanelsAndButtons();
        }

        public void addPanelsAndButtons()
        {
            this.Controls.Add(panel1);
            this.Controls.Add(panel2);
            this.Controls.Add(panel3);
            this.Controls.Add(panel4);
            this.Controls.Add(panel5);
            this.Controls.Add(panel6);
            this.Controls.Add(panel7);
            this.Controls.Add(panel8);
            this.Controls.Add(panel9);

            button1.BringToFront();
            button2.BringToFront();
            button3.BringToFront();
            button4.BringToFront();
            button5.BringToFront();
            button6.BringToFront();
            button7.BringToFront();
            button8.BringToFront();
            button9.BringToFront();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            checkStartTextBoxIsNumber("txtbxstart1");
            button1.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            checkStartTextBoxIsNumber("txtbxstart2");
            button2.Text = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            checkStartTextBoxIsNumber("txtbxstart3");
            button3.Text = textBox3.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            checkStartTextBoxIsNumber("txtbxstart6");
            button6.Text = textBox6.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            checkStartTextBoxIsNumber("txtbxstart5");
            button5.Text = textBox5.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            checkStartTextBoxIsNumber("txtbxstart4");
            button4.Text = textBox4.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            checkStartTextBoxIsNumber("txtbxstart9");
            button9.Text = textBox9.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            checkStartTextBoxIsNumber("txtbxstart8");
            button8.Text = textBox8.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //CLEAR INPUTS HERE..
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            checkStartTextBoxIsNumber("txtbxstart7");
            button7.Text = textBox7.Text;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            if (stepIndex < solutionOfBoardState.Count)
            {
                updateBoardStatus(solutionOfBoardState[stepIndex]);
                labelStep.Text = $"Step: {stepIndex}";
                labelF.Text = $"F = G + H = {solutionOfBoardState[stepIndex].f}";
                stepIndex++;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void checkStartTextBoxIsNumber(string txtbxNumber)
        {
            try
            {
                if(txtbxNumber.Equals("txtbxstart1") && (textBox1.Text == "" || textBox1.Text == null || !(int.TryParse(textBox1.Text, out n1)))){
                    throw new FormatException("1.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart2") && (textBox2.Text == "" || textBox2.Text == null || !(int.TryParse(textBox2.Text, out n2))))
                {
                    throw new FormatException("1.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart3") && (textBox3.Text == "" || textBox3.Text == null || !(int.TryParse(textBox3.Text, out n3))))
                {
                    throw new FormatException("1.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart4") && (textBox4.Text == "" || textBox4.Text == null || !(int.TryParse(textBox4.Text, out n4))))
                {
                    throw new FormatException("2.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart5") && (textBox5.Text == "" || textBox5.Text == null || !(int.TryParse(textBox5.Text, out n5))))
                {
                    throw new FormatException("2.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart6") && (textBox6.Text == "" || textBox6.Text == null || !(int.TryParse(textBox6.Text, out n6))))
                {
                    throw new FormatException("2.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart7") && (textBox7.Text == "" || textBox7.Text == null || !(int.TryParse(textBox7.Text, out n7))))
                {
                    throw new FormatException("3.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart8") && (textBox8.Text == "" || textBox8.Text == null || !(int.TryParse(textBox8.Text, out n8))))
                {
                    throw new FormatException("3.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart9") && (textBox9.Text == "" || textBox9.Text == null || !(int.TryParse(textBox9.Text, out n9))))
                {
                    throw new FormatException("3.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            checkGoalTextBoxIsNumber("txtbxstart18");
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            checkGoalTextBoxIsNumber("txtbxstart16");
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            checkGoalTextBoxIsNumber("txtbxstart17");
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            checkGoalTextBoxIsNumber("txtbxstart10");
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            checkGoalTextBoxIsNumber("txtbxstart11");
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            checkGoalTextBoxIsNumber("txtbxstart12");
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            checkGoalTextBoxIsNumber("txtbxstart13");
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            checkGoalTextBoxIsNumber("txtbxstart14");
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            checkGoalTextBoxIsNumber("txtbxstart15");
        }

        private void checkGoalTextBoxIsNumber(string txtbxNumber)
        {
            try
            {
                if (txtbxNumber.Equals("txtbxstart10") && (textBox10.Text == "" || textBox10.Text == null || !(int.TryParse(textBox10.Text, out n1))))
                {
                    throw new FormatException("1.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart11") && (textBox11.Text == "" || textBox11.Text == null || !(int.TryParse(textBox11.Text, out n2))))
                {
                    throw new FormatException("1.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart12") && (textBox12.Text == "" || textBox12.Text == null || !(int.TryParse(textBox12.Text, out n3))))
                {
                    throw new FormatException("1.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart13") && (textBox13.Text == "" || textBox13.Text == null || !(int.TryParse(textBox13.Text, out n4))))
                {
                    throw new FormatException("2.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart14") && (textBox14.Text == "" || textBox14.Text == null || !(int.TryParse(textBox14.Text, out n5))))
                {
                    throw new FormatException("2.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart15") && (textBox15.Text == "" || textBox15.Text == null || !(int.TryParse(textBox15.Text, out n6))))
                {
                    throw new FormatException("2.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart16") && (textBox16.Text == "" || textBox16.Text == null || !(int.TryParse(textBox16.Text, out n7))))
                {
                    throw new FormatException("3.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart17") && (textBox17.Text == "" || textBox17.Text == null || !(int.TryParse(textBox17.Text, out n8))))
                {
                    throw new FormatException("3.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart18") && (textBox18.Text == "" || textBox18.Text == null || !(int.TryParse(textBox18.Text, out n9))))
                {
                    throw new FormatException("3.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            checkAllInputs();
            int[,] startState = getStartState();
            int[,] goalState = getGoalState();

            BoardStateSolver solver = new BoardStateSolver(startState, goalState);
            solutionOfBoardState = solver.solveBoard();

            if(solutionOfBoardState != null)
            {
                MessageBox.Show("Solution Found !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                stepIndex = 0;
                timer1.Interval = 2000;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Solution Not Found !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private int[,] getStartState()
        {
            int[,] startState = new int[3,3];

            for(int i = 0; i < 3; i++)
            {
                for(int k = 0; k<3; k++)
                {
                    int.TryParse(this.Controls["textBox" + (i * 3 + k + 1)].Text,out int number);

                    startState[i, k] = number;
                }
            }

            return startState;
        }

        private int[,] getGoalState()
        {
            int[,] goalState = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for(int k =0; k<3; k++)
                {
                    int.TryParse(this.Controls["textBox" + (i * 3 + k + 10)].Text, out int number);
                    goalState[i, k] = number;
                }
            }
            return goalState;
        }

        
        private void checkAllInputs()
        {
            try
            {
                // INITIAL STATE INPUTS LAST CHECK
                if (textBox1.Text == "" || textBox1.Text == null || !(int.TryParse(textBox1.Text, out n1)))
                {
                    throw new FormatException("Initial State 1.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox2.Text == "" || textBox2.Text == null || !(int.TryParse(textBox2.Text, out n2)))
                {
                    throw new FormatException("Initial State 1.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox3.Text == "" || textBox3.Text == null || !(int.TryParse(textBox3.Text, out n3)))
                {
                    throw new FormatException("Initial State 1.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox4.Text == "" || textBox4.Text == null || !(int.TryParse(textBox4.Text, out n4)))
                {
                    throw new FormatException("Initial State 2.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox5.Text == "" || textBox5.Text == null || !(int.TryParse(textBox5.Text, out n5)))
                {
                    throw new FormatException("Initial State 2.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox6.Text == "" || textBox6.Text == null || !(int.TryParse(textBox6.Text, out n6)))
                {
                    throw new FormatException("Initial State 2.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox7.Text == "" || textBox7.Text == null || !(int.TryParse(textBox7.Text, out n7)))
                {
                    throw new FormatException("Initial State 3.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox8.Text == "" || textBox8.Text == null || !(int.TryParse(textBox8.Text, out n8)))
                {
                    throw new FormatException("Initial State 3.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox9.Text == "" || textBox9.Text == null || !(int.TryParse(textBox9.Text, out n9)))
                {
                    throw new FormatException("Initial State 3.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }

                // GOAL STATE INPUTS LAST CHECK
                if (textBox10.Text == "" || textBox10.Text == null || !(int.TryParse(textBox10.Text, out n10)))
                {
                    throw new FormatException("Goal State 1.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox11.Text == "" || textBox11.Text == null || !(int.TryParse(textBox11.Text, out n11)))
                {
                    throw new FormatException("Goal State 1.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox12.Text == "" || textBox12.Text == null || !(int.TryParse(textBox12.Text, out n12)))
                {
                    throw new FormatException("Goal State 1.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox13.Text == "" || textBox13.Text == null || !(int.TryParse(textBox13.Text, out n13)))
                {
                    throw new FormatException("Goal State 2.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox14.Text == "" || textBox14.Text == null || !(int.TryParse(textBox14.Text, out n14)))
                {
                    throw new FormatException("Goal State 2.Row  2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox15.Text == "" || textBox15.Text == null || !(int.TryParse(textBox15.Text, out n15)))
                {
                    throw new FormatException("Goal State 2.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox16.Text == "" || textBox16.Text == null || !(int.TryParse(textBox16.Text, out n16)))
                {
                    throw new FormatException("Goal State 3.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox17.Text == "" || textBox17.Text == null || !(int.TryParse(textBox17.Text, out n17)))
                {
                    throw new FormatException("Goal State 3.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox18.Text == "" || textBox18.Text == null || !(int.TryParse(textBox18.Text, out n18)))
                {
                    throw new FormatException("Goal State 3.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBoardStatus(BoardState boardState)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++) {
                    int number = boardState.tiles[i, k].Value;

                    int index = i * 3 + k + 1;
                    this.Controls["panel" + index].Controls["button" + index].Text = number.ToString();
                    
                }
            }
        }
    }
}
