using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AStarAlgorithmFor8PuzzleGame
{
    public class GlobalExceptionHandler
    {
        private static GameForm gameForm;

        public GlobalExceptionHandler(GameForm mainForm)
        {
            gameForm = mainForm;
        }

        public void checkGoalTextBox(string textBoxNo)
        {
            checkGoalTextBoxIsNumber(textBoxNo);
        }

        public void checkStartTextBox(string textBoxNo)
        {
            checkStartTextBoxIsNumber(textBoxNo);
        }

        public void checkAllTextBox()
        {
            checkAllInputs();
        }

        private void checkGoalTextBoxIsNumber(string txtbxNumber)
        {
            try
            {
                if (txtbxNumber.Equals("txtbxstart10") && (gameForm.textBox10.Text == "" || gameForm.textBox10.Text == null || !(int.TryParse(gameForm.textBox10.Text, out int n1))))
                {
                    throw new FormatException("1.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart11") && (gameForm.textBox11.Text == "" || gameForm.textBox11.Text == null || !(int.TryParse(gameForm.textBox11.Text, out int n2))))
                {
                    throw new FormatException("1.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart12") && (gameForm.textBox12.Text == "" || gameForm.textBox12.Text == null || !(int.TryParse(gameForm.textBox12.Text, out int n3))))
                {
                    throw new FormatException("1.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart13") && (gameForm.textBox13.Text == "" || gameForm.textBox13.Text == null || !(int.TryParse(gameForm.textBox13.Text, out int n4))))
                {
                    throw new FormatException("2.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart14") && (gameForm.textBox14.Text == "" || gameForm.textBox14.Text == null || !(int.TryParse(gameForm.textBox14.Text, out int n5))))
                {
                    throw new FormatException("2.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart15") && (gameForm.textBox15.Text == "" || gameForm.textBox15.Text == null || !(int.TryParse(gameForm.textBox15.Text, out int n6))))
                {
                    throw new FormatException("2.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart16") && (gameForm.textBox16.Text == "" || gameForm.textBox16.Text == null || !(int.TryParse(gameForm.textBox16.Text, out int n7))))
                {
                    throw new FormatException("3.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart17") && (gameForm.textBox17.Text == "" || gameForm.textBox17.Text == null || !(int.TryParse(gameForm.textBox17.Text, out int n8))))
                {
                    throw new FormatException("3.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart18") && (gameForm.textBox18.Text == "" || gameForm.textBox18.Text == null || !(int.TryParse(gameForm.textBox18.Text, out int n9))))
                {
                    throw new FormatException("3.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkStartTextBoxIsNumber(string txtbxNumber)
        {
            try
            {
                if (txtbxNumber.Equals("txtbxstart1") && (gameForm.textBox1.Text == "" || gameForm.textBox1.Text == null || !(int.TryParse(gameForm.textBox1.Text, out int n1))))
                {
                    throw new FormatException("1.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart2") && (gameForm.textBox2.Text == "" || gameForm.textBox2.Text == null || !(int.TryParse(gameForm.textBox2.Text, out int n2))))
                {
                    throw new FormatException("1.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart3") && (gameForm.textBox3.Text == "" || gameForm.textBox3.Text == null || !(int.TryParse(gameForm.textBox3.Text, out int n3))))
                {
                    throw new FormatException("1.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart4") && (gameForm.textBox4.Text == "" || gameForm.textBox4.Text == null || !(int.TryParse(gameForm.textBox4.Text, out int n4))))
                {
                    throw new FormatException("2.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart5") && (gameForm.textBox5.Text == "" || gameForm.textBox5.Text == null || !(int.TryParse(gameForm.textBox5.Text, out int n5))))
                {
                    throw new FormatException("2.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart6") && (gameForm.textBox6.Text == "" || gameForm.textBox6.Text == null || !(int.TryParse(gameForm.textBox6.Text, out int n6))))
                {
                    throw new FormatException("2.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart7") && (gameForm.textBox7.Text == "" || gameForm.textBox7.Text == null || !(int.TryParse(gameForm.textBox7.Text, out int n7))))
                {
                    throw new FormatException("3.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart8") && (gameForm.textBox8.Text == "" || gameForm.textBox8.Text == null || !(int.TryParse(gameForm.textBox8.Text, out int n8))))
                {
                    throw new FormatException("3.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart9") && (gameForm.textBox9.Text == "" || gameForm.textBox9.Text == null || !(int.TryParse(gameForm.textBox9.Text, out int n9))))
                {
                    throw new FormatException("3.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkAllInputs()
        {
            try
            {
                // INITIAL STATE INPUTS LAST CHECK
                if (gameForm.textBox1.Text == "" || gameForm.textBox1.Text == null || !(int.TryParse(gameForm.textBox1.Text, out int n1)))
                {
                    throw new FormatException("Initial State 1.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (gameForm.textBox2.Text == "" || gameForm.textBox2.Text == null || !(int.TryParse(gameForm.textBox2.Text, out int n2)))
                {
                    throw new FormatException("Initial State 1.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (gameForm.textBox3.Text == "" || gameForm.textBox3.Text == null || !(int.TryParse(gameForm.textBox3.Text, out int n3)))
                {
                    throw new FormatException("Initial State 1.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (gameForm.textBox4.Text == "" || gameForm.textBox4.Text == null || !(int.TryParse(gameForm.textBox4.Text, out int n4)))
                {
                    throw new FormatException("Initial State 2.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (gameForm.textBox5.Text == "" || gameForm.textBox5.Text == null || !(int.TryParse(gameForm.textBox5.Text, out int n5)))
                {
                    throw new FormatException("Initial State 2.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (gameForm.textBox6.Text == "" || gameForm.textBox6.Text == null || !(int.TryParse(gameForm.textBox6.Text, out int n6)))
                {
                    throw new FormatException("Initial State 2.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (gameForm.textBox7.Text == "" || gameForm.textBox7.Text == null || !(int.TryParse(gameForm.textBox7.Text, out int n7)))
                {
                    throw new FormatException("Initial State 3.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (gameForm.textBox8.Text == "" || gameForm.textBox8.Text == null || !(int.TryParse(gameForm.textBox8.Text, out int n8)))
                {
                    throw new FormatException("Initial State 3.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (gameForm.textBox9.Text == "" || gameForm.textBox9.Text == null || !(int.TryParse(gameForm.textBox9.Text, out int n9)))
                {
                    throw new FormatException("Initial State 3.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }

                // GOAL STATE INPUTS LAST CHECK
                if (gameForm.textBox10.Text == "" || gameForm.textBox10.Text == null || !(int.TryParse(gameForm.textBox10.Text, out int n10)))
                {
                    throw new FormatException("Goal State 1.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (gameForm.textBox11.Text == "" || gameForm.textBox11.Text == null || !(int.TryParse(gameForm.textBox11.Text, out int n11)))
                {
                    throw new FormatException("Goal State 1.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (gameForm.textBox12.Text == "" || gameForm.textBox12.Text == null || !(int.TryParse(gameForm.textBox12.Text, out int n12)))
                {
                    throw new FormatException("Goal State 1.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (gameForm.textBox13.Text == "" || gameForm.textBox13.Text == null || !(int.TryParse(gameForm.textBox13.Text, out int n13)))
                {
                    throw new FormatException("Goal State 2.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (gameForm.textBox14.Text == "" || gameForm.textBox14.Text == null || !(int.TryParse(gameForm.textBox14.Text, out int n14)))
                {
                    throw new FormatException("Goal State 2.Row  2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (gameForm.textBox15.Text == "" || gameForm.textBox15.Text == null || !(int.TryParse(gameForm.textBox15.Text, out int n15)))
                {
                    throw new FormatException("Goal State 2.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (gameForm.textBox16.Text == "" || gameForm.textBox16.Text == null || !(int.TryParse(gameForm.textBox16.Text, out int n16)))
                {
                    throw new FormatException("Goal State 3.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (gameForm.textBox17.Text == "" || gameForm.textBox17.Text == null || !(int.TryParse(gameForm.textBox17.Text, out int n17)))
                {
                    throw new FormatException("Goal State 3.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (gameForm.textBox18.Text == "" || gameForm.textBox18.Text == null || !(int.TryParse(gameForm.textBox18.Text, out int n18)))
                {
                    throw new FormatException("Goal State 3.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
