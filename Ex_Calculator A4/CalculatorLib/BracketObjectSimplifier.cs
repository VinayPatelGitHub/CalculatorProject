using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib
{
    
    public class BracketObjectSimplifier
    {
        public List<String> ListofBracketParts { get; set; } //To contain numbers and opperators

        public BracketObjectSimplifier(string equation)
        {
            string numBuilder = "";
            foreach (char i in equation)
                if (Char.IsDigit(i) == true || i == '.')
                {
                    numBuilder += i;
                }
                else if (i == '-' || i == '+' || i == '/' || i == '*')
                {
                    if (numBuilder != "")
                    {
                        ListofBracketParts.Add(numBuilder);                        
                    }
                    else if (i == '-') 
                    {
                        numBuilder += i;
                    }
                    else
                    {
                        numBuilder = "";
                        ListofBracketParts.Add(i.ToString());
                    }                   
                    
                }
        }
    }
}
