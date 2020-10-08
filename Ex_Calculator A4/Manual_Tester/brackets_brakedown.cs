//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace WorkingOutArea
//{
//    class brackets_brakedown
//    {        
//        static void Main(string[] args)
//        {
//            List<string> _equationList = new List<string>() { "(", "(", "5", "+", "5", ")", "+", "(", "5", "+", "5", ")", ")" };
//            string current = "";
//            foreach (string item in _equationList)
//            {
//                current += item;
//            }
//            Console.WriteLine(current);

//            for (int posI = 0; posI < _equationList.Count; posI++)
//            {
//                if (_equationList[posI] == ")")
//                {
//                    for (int Ipos = posI-1; Ipos >= 0; Ipos--)
//                    {
//                        if (_equationList[Ipos] == ")")
//                        {
//                            break;
//                        }

//                        else if (_equationList[Ipos] == "(")
//                        {
//                            //making subEq for ()
//                            List<string> _subEquationList = new List<string>();
//                            for (int start = Ipos + 1; start <= posI - 1; start++)
//                            {
//                                _subEquationList.Add(_equationList[start]);
//                            }

//                            //running calc on subEq
//                            int countBefore = _subEquationList.Count;
//                            (_subEquationList) = ALLCalculations(_subEquationList);
//                            int countAfter = _subEquationList.Count;
//                            int diff = countBefore - countAfter + 2;

//                            //replaing in main list
//                            for (int i = 0; i < _subEquationList.Count; i++)
//                            {
//                                _equationList[Ipos + i] = _subEquationList[i];
//                            }
//                            //correcting main list
//                            for (int i = 0; i < diff; i++)
//                            {
//                                _equationList.RemoveAt(posI - i);
//                            }

//                            posI = 0; // break here although it also makes it good, probs needs and if function, can probs make a rule about it 
//                            break;
//                        }
//                    }
//                }
//            }


//            // for output
//            string result = "";
//            foreach (string item in _equationList)
//            {
//                result += item;
//            }
//            Console.WriteLine(result);
//        }


//        static List<string> ALLCalculations(List<string> _subEquationLists)
//        {
//            (_subEquationLists) = Calculation("^", _subEquationLists);
//            (_subEquationLists) = Calculation("*", _subEquationLists);
//            (_subEquationLists) = Calculation("/", _subEquationLists);
//            (_subEquationLists) = Calculation("-", _subEquationLists);
//            (_subEquationLists) = Calculation("+", _subEquationLists);
//            return (_subEquationLists);
//        }

//        static List<string> Calculation(string opp, List<string> _subEquationList)
//        {
//            for (int i = 1; i < _subEquationList.Count - 1; i++)
//            {
                
//                if (_subEquationList[i] == opp & _subEquationList[i - 1].All(char.IsDigit) & _subEquationList[i + 1].All(char.IsDigit))
//                {
//                    double x = double.Parse(_subEquationList[i - 1]);
//                    double y = double.Parse(_subEquationList[i + 1]);
//                    double z = 0;
//                    if (opp == "*")
//                    {
//                        z = x * y;
//                    }
//                    else if (opp == "+")
//                    {
//                        z = x + y;
//                    }                    
                    
//                    _subEquationList[i - 1] = z.ToString();
//                    _subEquationList.RemoveAt(i + 1); //always remove in reverse order
//                    _subEquationList.RemoveAt(i);
//                    i = 0;
//                }
//            }
//            return (_subEquationList);
//        }
//    }    
//}
