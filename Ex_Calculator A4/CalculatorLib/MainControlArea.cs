using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Xml.Linq;
using System.Linq;

//so how do i want to do this, using this list of operators i can go through it and apply
// bidmos. brackets will be the challenge. 
// also editing may be an issue so it might be better to rebuild the 
// arrays every time a change is made.


namespace CalculatorLib
{
    public class MainControlClass        
    {
        public string[] Store(string equation) 
        {
            string InputEquation = "(" + equation + ")";
            string result = "";
            


            // ^
            int InputEquationLength = InputEquation.Length;
            for (int i = 0; i < InputEquationLength; i++)
            {
                if (InputEquation[i] == '^' && InputEquation[i + 1] != '(') ;
                InputEquation.Insert((i + 1), "(");
            }
            

            // clean up List/equation (-- = +)
            int x = -2;
            for (int i = 0; i < _equationList.Count; i++)
            {
                if (_equationList[i] == "-")
                {
                    if (x + 1 == i)
                    {
                        _equationList[x] = "+";
                        _equationList.RemoveAt(i);
                    }
                    x = i;
                }
            }

            // now the real maths find the first ")"
            for (int posI = 0; posI < _equationList.Count; posI++)
            {
                if (_equationList[posI] == ")")
                {
                    for (int Ipos = posI-1; Ipos >= 0 ; Ipos--)
                    {
                        if (_equationList[Ipos] == ")")
                        {
                            break;
                        }
                        
                        else if (_equationList[Ipos] == "(")
                        {
                            //making subEq for ()
                            List<string> _subEquationList = new List<string>();
                            for (int start = Ipos+1; start <= posI-1; start++)
                            {
                                _subEquationList.Add(_equationList[start]);
                            }

                            //running calc on subEq
                            int countBefore = _subEquationList.Count;
                            (_subEquationList) = ALLCalculations(_subEquationList);
                            int countAfter = _subEquationList.Count;
                            int diff = countBefore - countAfter + 2;

                            //replaing in main list
                            for (int i = 0; i < _subEquationList.Count; i++)
                            {
                                _equationList[Ipos+i] = _subEquationList[i];
                            }
                            //correcting main list
                            for (int i = 0; i < diff; i++)
                            {
                                _equationList.RemoveAt(posI - i);
                            }

                            posI = 0; // break here although it also makes it good, probs needs and if function, can probs make a rule about it 
                            break;
                        }
                    }
                }                       
            }

            // for output
            foreach (string item in _equationList)
            {
                result += item;
            }
            string[] output = new string[2] { current, result };
            return output;
        }


        public List<string> ALLCalculations(List<string> _subEquationLists)
        {
            (_subEquationLists) = Calculation("^", _subEquationLists);
            (_subEquationLists) = Calculation("*", _subEquationLists);
            (_subEquationLists) = Calculation("/", _subEquationLists);
            (_subEquationLists) = Calculation("-", _subEquationLists);
            (_subEquationLists) = Calculation("+", _subEquationLists);            
            return (_subEquationLists);
        }

        public List<string> Calculation(string opp, List<string> _subEquationList)
        {
            for (int i = 1; i < _subEquationList.Count-1; i++)
            {
                Dictionary<string, Func<double, double, double>> oppLib = new Dictionary<string, Func<double, double, double>>();
                oppLib.Add("^", Operations.Indices);
                oppLib.Add("*", Operations.Multiplication);
                oppLib.Add("/", Operations.Division);
                oppLib.Add("+", Operations.Addition);
                oppLib.Add("-", Operations.Subtraction);

                if (_subEquationList[i] == opp & _subEquationList[i - 1].All(char.IsDigit) & _subEquationList[i + 1].All(char.IsDigit))
                {
                    double x = double.Parse(_subEquationList[i - 1]);
                    double y = double.Parse(_subEquationList[i + 1]);
                    double z = oppLib[opp](x, y);
                    _subEquationList[i - 1] = z.ToString();
                    _subEquationList.RemoveAt(i + 1); //always remove in reverse order
                    _subEquationList.RemoveAt(i);
                    i = 0;
                }
            }
            return (_subEquationList);
        }

        //Constructor
        public MainControlClass()
        {
        }
    }
}