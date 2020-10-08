using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Xml.Linq;

//so how do i want to do this, using this list of operators i can go through it and apply
// bidmos. brackets will be the challenge. 
// also editing may be an issue so it might be better to rebuild the 
// arrays every time a change is made.


namespace CalculatorLib
{
    public class MainControlClass        
    {
        private List<int> _number;
        private List<char> _simOpp;

        public List<int> Number 
        {
            get { return _number; }
            //set { _numbers.Add(value); }
        }

        public List<char> SimOpp 
        {
            get { return _simOpp; }
            //set { _simOpps.Add(value); }
        }

        public string[] Store(string item) 
        {
            List<int> _numbers = new List<int>();
            List<char> _simOpps = new List<char>();

            string current = item;
            string result = "";            
            int lastCharPos = item.Length - 1;
            string numBuilder = "";

            //build arrays
            foreach (char i in item)
                if (Char.IsDigit(i) == true)
                {
                    numBuilder += i;
                }
                else if (i == '-' || i == '+' || i == '/' || i == '*') //add ( and ) and ^
                {
                    string num1 = item.Remove(lastCharPos);
                    if (numBuilder != "") //need to deal with '++'
                    {
                        int num = int.Parse(numBuilder);
                        _numbers.Add(num);
                    }                                       
                    numBuilder = "";
                    _simOpps.Add(i);
                }
                else if (i == '=')
                {
                    break;
                }

            //use arrays to calculate
            //(_numbers, _simOpps) = Calculation('(', _numbers, _simOpps) //needs to do all below for within)
            // to use brackets would be applying this order to inbetween brackets
            //for brakets inside brackets it needs a serach for ) ting, 
            // then can send it throug but need to how to correct 

            for (int pos = 0; pos < _simOpps.Count; pos++)
            {
                if (_simOpps[pos] == ')')
                {
                    for (int pos2 = pos; pos < _simOpps.Count; pos2--)
                    {
                        if (_simOpps[pos] == '(')
                        {
                            List<int> _subNumbers = new List<int>();
                            List<char> _subSimOpps = new List<char>();
                            for (int bpos2 = pos2; bpos2 <= pos; bpos2++)
                            {
                                _subSimOpps.Add(_simOpps[bpos2]);
                                _subNumbers.Add(_numbers[bpos2]);
                            }
                            (_subNumbers, _subSimOpps) = ALLCalculations(_subNumbers, _subSimOpps);
                            //now need to fix orginal list
                            _numbers[pos] = _subNumbers[0];
                            _simOpps[pos] = _subSimOpps[0];
                            for (int bbpos2 = pos2+1; bbpos2 <= pos; bbpos2++)
                            {
                                _numbers.RemoveAt(bbpos2);
                                _simOpps.RemoveAt(bbpos2);
                            }                           

                        }
                    }
                    
                    //find highest level bracket find first and last position
                    // save that as a two list
                }
                       
            }

            //after brackets, everything else, but could just put the whole thing for the last bit
            (_numbers, _simOpps) = ALLCalculations(_numbers, _simOpps);

            // for output
            for (int r = 0; r < _numbers.Count; r++)
            {
                result += _numbers[r];
                if (r < _simOpps.Count)
                {
                    result += _simOpps[r];
                }
            }

            string[] output = new string[2] { current, result };
            return output;
        }

        public void addNumber(int num)
        {
            Number.Add(num);
        }

        public void addSimOpps(char i)
        {
            SimOpp.Add(i);
        }

        public (List<int>, List<char>) ALLCalculations(List<int> _numbers, List<char> _simOpps)
        {
            (_numbers, _simOpps) = Calculation('*', _numbers, _simOpps);
            (_numbers, _simOpps) = Calculation('/', _numbers, _simOpps);
            (_numbers, _simOpps) = Calculation('-', _numbers, _simOpps);
            (_numbers, _simOpps) = Calculation('+', _numbers, _simOpps);
            return (_numbers, _simOpps);
        }



        public (List<int>, List<char>) Calculation(char order, List<int> _numbers, List<char> _simOpps)
        {
            
            if (order == '*')
            {

            }
            
            for (int count = 0; count < _simOpps.Count; count++)
            {
                if (_simOpps[count] == order & (count + 1 < _simOpps.Count) & (count + 2 <= _numbers.Count))
                {
                    double x = _numbers[count];
                    double y = _numbers[count + 1];
                    double z = 0;
                    if (order == '*')
                    {
                         z = Operations.Multiplication(x, y);
                    }
                    else if (order == '/')
                    {
                         z = Operations.Division(x, y);
                    }
                    else if (order == '+')
                    {
                         z = Operations.Addition(x, y);
                    }
                    else if (order == '-')
                    {
                         z = Operations.Subtraction(x, y);
                    }
                    
                    _numbers[count] = (int)z;
                    _numbers.RemoveAt(count + 1);
                    _simOpps.RemoveAt(count);
                    count--;
                }
            }
            return (_numbers, _simOpps);
        }

        //Constructor
        public MainControlClass()
        {
            _number = new List<int> { };
            _simOpp = new List<char> { };
        }
    }
}
