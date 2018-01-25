using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Assignment2StudentPredicate
{
    public partial class Form1 : Form
    {
        // Class variables 
        ResetFormComponents resetFormComponents = ResetFormComponents.Instance;
        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Call a function to reset the components
            resetFormComponents.ClearComponents(practicalsTextBox, term1TextBox, term2TextBox, additionalTextBox, projectTextBox, calculateButton, clearButton, predicateResultsLabel, predicateNeededLabel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Call a function to reset the components
            resetFormComponents.ClearComponents(practicalsTextBox, term1TextBox, term2TextBox, additionalTextBox, projectTextBox, calculateButton, clearButton, predicateResultsLabel, predicateNeededLabel);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the class calculate predicate
            PredicateCalculator predicateCalculator = new PredicateCalculator();
            // Send the user input as parameters
            // Returns the predicate results
            predicateCalculator.PredicateResults = predicateCalculator.CalculatePredicate(int.Parse(practicalsTextBox.Text), int.Parse(term1TextBox.Text), int.Parse(term2TextBox.Text), int.Parse(additionalTextBox.Text), int.Parse(projectTextBox.Text));
            // Get the predicate needed
            predicateCalculator.PredicateNeeded = predicateCalculator.CalculatePredicateNeeded(predicateCalculator.PredicateResults);

            if (predicateCalculator.PredicateResults > 50)
            {
                // Change the font colour of the label
                predicateResultsLabel.ForeColor = Color.Green;
            }
            if (predicateCalculator.PredicateResults < 50)
            {
                // Change the colour of the label
                predicateResultsLabel.ForeColor = Color.Red;
            }
            predicateResultsLabel.Text = "Your predicate is: " + predicateCalculator.PredicateResults.ToString();
            predicateNeededLabel.Text = "You need " + predicateCalculator.PredicateNeeded.ToString() + " in the exam to pass";
        }
        private void goodMarksButton_Click(object sender, EventArgs e)
        {
            calculateButton.Enabled = true;
        }
    }
}
