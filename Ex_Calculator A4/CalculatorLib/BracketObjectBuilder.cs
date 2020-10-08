using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib
{

    public class BracketObjectBuilder
    {
        public List<string> ListofBracketObjects { get; set; } //To contain numbers and opperators

        public BracketObjectBuilder(string inputEquation)
        {
            int inputEquationLength = inputEquation.Length;
            for (int item1 = 0; item1 < inputEquationLength; item1++)
            {
                if (inputEquation[item1] == '(' || inputEquation[item1] == ')')
                {
                    int BracketPartOpen = item1;
                    for (int item2 = BracketPartOpen + 1; item2 < inputEquationLength; item2++)
                    {
                        if (inputEquation[item2] == '(')
                        {
                            string Part = inputEquation.Substring(item1, item2 - item1);
                            ListofBracketObjects.Add(Part);
                            item1 = item2;
                        }
                        if (inputEquation[item2] == ')')
                        {
                            string Part = inputEquation.Substring(item1, item2 - item1 + 1);
                            ListofBracketObjects.Add(Part);
                            item1 = item2 + 1;
                        }
                    }
                }
            }



        }

        public List<string> ReturnListofBracketObjects()
        {
            return ListofBracketObjects;
        }



    }
}
