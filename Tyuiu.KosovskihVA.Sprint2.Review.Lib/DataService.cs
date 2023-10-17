using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KosovskihVA.Sprint2.Review.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (x>0 && y>0)
            {
                if (x <= 2)
                {
                    if (y < x * x)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (x >= 2)
                {
                    if (y < 4)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
