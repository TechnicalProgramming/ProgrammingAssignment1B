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

        }
    }
}
