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
            checkStartTextBoxIsNumber("txtbxstart4");
            button4.Text = textBox6.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            checkStartTextBoxIsNumber("txtbxstart5");
            button5.Text = textBox5.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            checkStartTextBoxIsNumber("txtbxstart6");
            button6.Text = textBox4.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            checkStartTextBoxIsNumber("txtbxstart7");
            button7.Text = textBox9.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            checkStartTextBoxIsNumber("txtbxstart8");
            button8.Text = textBox8.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            checkStartTextBoxIsNumber("txtbxstart9");
            button9.Text = textBox7.Text;
        }



        private void checkStartTextBoxIsNumber(string txtbxNumber)
        {
            try
            {
                if(txtbxNumber.Equals("txtbxstart1") && (textBox1.Text == "" || textBox1.Text == null || !(int.TryParse(textBox1.Text, out int n1)))){
                    throw new FormatException("1.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart2") && (textBox2.Text == "" || textBox2.Text == null || !(int.TryParse(textBox2.Text, out int n2))))
                {
                    throw new FormatException("1.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart3") && (textBox3.Text == "" || textBox3.Text == null || !(int.TryParse(textBox3.Text, out int n3))))
                {
                    throw new FormatException("1.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart4") && (textBox6.Text == "" || textBox6.Text == null || !(int.TryParse(textBox6.Text, out int n4))))
                {
                    throw new FormatException("2.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart5") && (textBox5.Text == "" || textBox5.Text == null || !(int.TryParse(textBox5.Text, out int n5))))
                {
                    throw new FormatException("2.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart6") && (textBox4.Text == "" || textBox4.Text == null || !(int.TryParse(textBox4.Text, out int n6))))
                {
                    throw new FormatException("2.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart7") && (textBox9.Text == "" || textBox9.Text == null || !(int.TryParse(textBox9.Text, out int n7))))
                {
                    throw new FormatException("3.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart8") && (textBox8.Text == "" || textBox8.Text == null || !(int.TryParse(textBox8.Text, out int n8))))
                {
                    throw new FormatException("3.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart9") && (textBox7.Text == "" || textBox7.Text == null || !(int.TryParse(textBox7.Text, out int n9))))
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
                if (txtbxNumber.Equals("txtbxstart10") && (textBox10.Text == "" || textBox10.Text == null || !(int.TryParse(textBox10.Text, out int n1))))
                {
                    throw new FormatException("1.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart11") && (textBox11.Text == "" || textBox11.Text == null || !(int.TryParse(textBox11.Text, out int n2))))
                {
                    throw new FormatException("1.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart12") && (textBox12.Text == "" || textBox12.Text == null || !(int.TryParse(textBox12.Text, out int n3))))
                {
                    throw new FormatException("1.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart13") && (textBox13.Text == "" || textBox13.Text == null || !(int.TryParse(textBox13.Text, out int n4))))
                {
                    throw new FormatException("2.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart14") && (textBox14.Text == "" || textBox14.Text == null || !(int.TryParse(textBox14.Text, out int n5))))
                {
                    throw new FormatException("2.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart15") && (textBox15.Text == "" || textBox15.Text == null || !(int.TryParse(textBox15.Text, out int n6))))
                {
                    throw new FormatException("2.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart16") && (textBox16.Text == "" || textBox16.Text == null || !(int.TryParse(textBox16.Text, out int n7))))
                {
                    throw new FormatException("3.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart17") && (textBox17.Text == "" || textBox17.Text == null || !(int.TryParse(textBox17.Text, out int n8))))
                {
                    throw new FormatException("3.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (txtbxNumber.Equals("txtbxstart18") && (textBox18.Text == "" || textBox18.Text == null || !(int.TryParse(textBox18.Text, out int n9))))
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
            String test = "Information cannot be left blank or a string expression cannot be written.";
        }

        
        private void checkAllInputs()
        {
            try
            {
                if (textBox1.Text == "" || textBox1.Text == null || !(int.TryParse(textBox1.Text, out int n1)))
                {
                    throw new FormatException("Initial State 1.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox2.Text == "" || textBox2.Text == null || !(int.TryParse(textBox2.Text, out int n2)))
                {
                    throw new FormatException("Initial State 1.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox3.Text == "" || textBox3.Text == null || !(int.TryParse(textBox3.Text, out int n3)))
                {
                    throw new FormatException("Initial State 1.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox6.Text == "" || textBox6.Text == null || !(int.TryParse(textBox6.Text, out int n4)))
                {
                    throw new FormatException("Initial State 2.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox5.Text == "" || textBox5.Text == null || !(int.TryParse(textBox5.Text, out int n5)))
                {
                    throw new FormatException("Initial State 2.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox4.Text == "" || textBox4.Text == null || !(int.TryParse(textBox4.Text, out int n6)))
                {
                    throw new FormatException("Initial State 2.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox9.Text == "" || textBox9.Text == null || !(int.TryParse(textBox9.Text, out int n7)))
                {
                    throw new FormatException("Initial State 3.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox8.Text == "" || textBox8.Text == null || !(int.TryParse(textBox8.Text, out int n8)))
                {
                    throw new FormatException("Initial State 3.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox7.Text == "" || textBox7.Text == null || !(int.TryParse(textBox7.Text, out int n9)))
                {
                    throw new FormatException("Initial State 3.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }


                if (textBox10.Text == "" || textBox10.Text == null || !(int.TryParse(textBox10.Text, out int n10)))
                {
                    throw new FormatException("Goal State 1.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox11.Text == "" || textBox11.Text == null || !(int.TryParse(textBox11.Text, out int n11)))
                {
                    throw new FormatException("Goal State 1.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox12.Text == "" || textBox12.Text == null || !(int.TryParse(textBox12.Text, out int n12)))
                {
                    throw new FormatException("Goal State 1.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox13.Text == "" || textBox13.Text == null || !(int.TryParse(textBox13.Text, out int n13)))
                {
                    throw new FormatException("Goal State 2.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox14.Text == "" || textBox14.Text == null || !(int.TryParse(textBox14.Text, out int n14)))
                {
                    throw new FormatException("Goal State 2.Row  2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox15.Text == "" || textBox15.Text == null || !(int.TryParse(textBox15.Text, out int n15)))
                {
                    throw new FormatException("Goal State 2.Row 3.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox16.Text == "" || textBox16.Text == null || !(int.TryParse(textBox16.Text, out int n16)))
                {
                    throw new FormatException("Goal State 3.Row 1.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox17.Text == "" || textBox17.Text == null || !(int.TryParse(textBox17.Text, out int n17)))
                {
                    throw new FormatException("Goal State 3.Row 2.Column Information cannot be left blank or a string expression cannot be written.");
                }
                if (textBox18.Text == "" || textBox18.Text == null || !(int.TryParse(textBox18.Text, out int n18)))
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
