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
        RandomMarks randomMarks = RandomMarks.Instance;
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
            // Activate the clear button
            clearButton.Enabled = true;
        }
        private void goodMarksButton_Click(object sender, EventArgs e)
        {
            // Call a method to enable the calculate button
            EnableCalculateButton();
            // Call a method to generate good marks
            randomMarks.GenerateGoodMarks();
            // Call a method to populate the GUI
            PopulateGUI();
        }

        private void badMarksButton_Click(object sender, EventArgs e)
        {
            EnableCalculateButton();
            // Call a method to generate bad marks
            randomMarks.GenerateBadMarks();
            // Populate the GUI
            PopulateGUI();
        }
        // Enable the calculate button
        public bool EnableCalculateButton()
        {
            try
            {
                // Enable the good marks button
                calculateButton.Enabled = true;
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public bool PopulateGUI()
        {
            try
            {
                practicalsTextBox.Text = randomMarks.PracticalTest.ToString();
                term1TextBox.Text = randomMarks.TermTest1.ToString();
                term2TextBox.Text = randomMarks.TermTest2.ToString();
                additionalTextBox.Text = randomMarks.AdditionalTest.ToString();
                projectTextBox.Text = randomMarks.ProjectTest.ToString();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
