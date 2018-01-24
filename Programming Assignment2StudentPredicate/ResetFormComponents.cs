using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Assignment2StudentPredicate
{
    /// <summary>
    /// Resets UI components to default
    /// </summary>
    public sealed class ResetFormComponents
    {
        #region Fields
        private static bool isReset = false;
        private static volatile ResetFormComponents instance;
        private static object syncRoot = new object();
        #endregion

        #region Constructor
        /// <summary>
        /// Private constructor
        /// </summary>
        private  ResetFormComponents() { }
        #endregion

        #region Properties
        public static ResetFormComponents Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ResetFormComponents();
                    }
                }
                return instance;
            }
        }

        /// <summary>
        /// Successful reset of components
        /// </summary>
        public bool IsReset { get {return isReset; } set { isReset = value; } }
        #endregion

        #region Methods
        public bool ClearComponents(TextBox praticalTotal, TextBox term1, TextBox term2, TextBox additional, TextBox project,Button calculateButton, Button clearButton, Label predicateResults, Label predicateNeeded)
        {
            try
            {
                // Clear the text properties 
                praticalTotal.Text = "";
                term1.Text = "";
                term2.Text = "";
                additional.Text = "";
                project.Text = "";
                // Default the labels text and colour
                predicateResults.Text = "Your predicate is: 00.0";
                predicateResults.ForeColor = System.Drawing.Color.Black;

                predicateNeeded.Text = "You need 00.0 in the exam to pass";
                predicateNeeded.ForeColor = System.Drawing.Color.Black;
                // Disable the buttons
                calculateButton.Enabled = false;
                clearButton.Enabled = false;
                return true;
            }catch(Exception exception)
            {
                MessageBox.Show("Error",exception.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion
    }
}
