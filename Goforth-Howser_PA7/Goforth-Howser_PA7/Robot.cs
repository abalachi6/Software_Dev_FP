using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goforth_Howser_PA7
{
    class Robot
    {
        string idnumber;
        int batteries;
        int components;
        double ttbuild;

        public string IDnumber
        {
            get
            {
                return idnumber;
            }
            set
            {
                idnumber = value;
            }
        }

        public int Batteries
        {
            get
            {
                return batteries;
            }
            set
            {
                if (value >= 0)
                {
                    batteries = value;
                }
                else
                {
                    batteries = value*-1;
                }
            }
        }

        public int Components
        {
            get
            {
                return components;
            }
            set
            {
                if (value > 0)
                {
                    components = value;
                }
                else if(value < 0)
                {
                    components = value * -1;
                }
                else 
                {
                    components = 1;
                }
            }
        }

        public double TTBuild
        {
            get
            {
                return ttbuild;
            }
            set
            {
                if (value >= 0)
                {
                    ttbuild = value;
                }
                else
                {
                    ttbuild = value*-1;
                }
            }
        }

        public Robot()
        {
            idnumber= "Stay Puft";
            batteries= 1;
            components=1;
            ttbuild= 0.0;

        }

        public Robot(string idNumber, int nBatteries, int nComponents, double buildT)
        {
            IDnumber = idNumber;
            Batteries = nBatteries;
            Components = nComponents;
            TTBuild = buildT;
        }

        public double GetPower()
        {
            double power = (144.0*(batteries*batteries))/components;
            return power;
        }

        public bool IsHighPower()
        {
            if(GetPower()>= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetCost()
        {
            double cost = 1.21 * ((10 * components) + (75 * ttbuild));
            return cost;
        }

        public void PrintDetails()
        {
            Console.WriteLine("# ID#:{0}  ({1:F}W)  {2:C}\n  >Batteries:  {3}\tComponents:  {4}", idnumber, GetPower(), GetCost(), batteries, components);
            
        }
    }
}
