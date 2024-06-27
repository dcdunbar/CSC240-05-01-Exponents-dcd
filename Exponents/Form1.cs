using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name: David Dunbar
 * Date: 06/27/2024
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xGoButton_Click(object sender, EventArgs e)
        {
            // STORAGE
            int number;

            // INPUT
            // Try to parse the input as an integer; handle potential format issues
            bool isValidInput = int.TryParse(xInputTextBox.Text, out number);
            if (!isValidInput)
            {
                MessageBox.Show("Please enter a valid integer.");
                return;
            }

            // PROCESS
            // Calculate the square and cube of the number
            int squareResult = Square(number);
            int cubeResult = Cube(number);

            // OUTPUT
            // Display the results in the single output label
            xOutputLabel.Text = $"Square: {squareResult}, Cube: {cubeResult}";

            // Optionally turn the output to visible if it's managed via visibility
            xOutputLabel.Visible = true;

            // Turn the Go button off to prevent further inputs until reset
            xGoButton.Enabled = false;
        }

        // Method to calculate square of a number
        private int Square(int num)
        {
            return num * num;
        }

        // Method to calculate cube of a number
        private int Cube(int num)
        {
            return num * num * num;
        }

        private void xResetButton_Click(object sender, EventArgs e)
        {
            // Clear the input and output text
            xInputTextBox.Text = string.Empty;
            xOutputLabel.Text = "";

            // Optionally turn the output to invisible
            xOutputLabel.Visible = false;

            // Turn the Go button back on
            xGoButton.Enabled = true;
        }
    }
}
