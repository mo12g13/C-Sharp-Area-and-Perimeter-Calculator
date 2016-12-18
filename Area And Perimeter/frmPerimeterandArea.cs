using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * C# Sharp Project 4.1
 * This application calculates the area and perimeter of a triangle
 * Author: Momo Johnson
 * */
namespace Area_And_Perimeter
{

    public partial class frmPerimeterandArea : Form

    {
        
        double length = 0;//A variable that reprensents the length
        double width = 0;//A Variable that represents the width
        
        public frmPerimeterandArea()
        {
            InitializeComponent();
        }
        // A event handler for the length and width textbox
        private void lengthAndWidth_TextChanged(object sender, EventArgs e)
        {
            txtPerimeterCalculate.Clear();
            txtAreaCalculate.Clear();
        }
        //An event handler that calculate the area and perimeter
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidData())
                {
                    /*Testing to see if the value entered in the text input area is convertible.
                    If the String can be coverted, the values are assigned to the variable length and width.
                    Otherwise, a message is display asking the user to enter the a valid number*/
                    if ((Double.TryParse(txtLengthInput.Text, out length)) && (Double.TryParse(txtWidthInput.Text, out width)))
                    {
                        double perimeter;//A Variable that stored the perimeter being calculated
                        double area;//A variabe that stored the perimeter being calculated

                        area = length * width;//Calculating of the area
                        txtAreaCalculate.Text = "" + area;//Setting of the area value in the textArea
                        perimeter = (2 * length) + (2 * width);//Calculating of the perimeter 
                        txtPerimeterCalculate.Text = "" + perimeter;//Setting of the perimeter in the perimeter calculated area

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTextBox();
                txtLengthInput.Focus();

            }
            
        }
        //A method that checks to make sure the textbox is not empty
        private bool isPresent(TextBox textbox, string name)
        {
            if (textbox.Text == "")
            {
                MessageBox.Show(name + "is a required field", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
                textbox.Focus();                
                return false;
            }
            else
            {
                return true;
            }
        }
        //A method that checks to make sure the input entered by the user is valid
        private bool isValidInput(TextBox textBox, string name)
        {
            try
            {
                if (Decimal.Parse(textBox.Text) > 0 && Decimal.Parse(textBox.Text) <= 100)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(name + " must be between 0-100 inclusively", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBox.Clear();
                    textBox.Focus();
                    return false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a number", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            textBox.Clear();
            textBox.Focus();
            return false;
            }              
            
        }
        //A method that validates the inputs entered by the user
        private bool isValidData()
        {
            return(isPresent(txtLengthInput, "Length")) &&
                (isValidInput(txtLengthInput, "Length")) &&
                (isPresent(txtWidthInput, "Width")) &&
                (isValidInput(txtWidthInput, "Width"));
        }
        //A event handler that exits the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //A event handler that clears the various control
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }
        //A method that clears the various textbox
        private void clearTextBox()
        {
            txtAreaCalculate.Clear();
            txtLengthInput.Clear();
            txtPerimeterCalculate.Clear();
            txtWidthInput.Clear();
        }
    }
}
