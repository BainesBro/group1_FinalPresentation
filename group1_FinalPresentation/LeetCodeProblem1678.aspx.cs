///# Name: Alexis Tipkemper-Sparks
///# email: Tipkemam@mail.uc.edu
///# Assignment Title: Final Presentation
///# Due Date: 04/22/2024
///# Course: IS 3050
///# Semester/Year: Spring 24' 
///# Brief Description: This project is our final presentation
///# Citations: LeetCode / StackOverflow / ChatGPT
///# Anything else that's relevant: Nothing

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace group1_FinalPresentation
{
    public partial class LeetCodeProblem1678 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Any logic that needs to run when the page loads
        }


        protected void btnInterpret_Click(object sender, EventArgs e)
        {
            // Event handler for button click
            string command = txtCommand.Text;
            string interpretation = InterpretCommand(command);
            lblOutput.Text = "Interpreted command: " + interpretation;
        }

        // Method to interpret the command
        private string InterpretCommand(string command)
        {
            // Logic to interpret the command according to the rules
            string interpretedCommand = command.Replace("()", "o").Replace("(al)", "al");
            return interpretedCommand;

        }
    }
}