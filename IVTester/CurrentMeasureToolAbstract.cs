using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVTester
{
    abstract class CurrentMeasureToolAbstract
    {
        abstract public void InitSession();
        abstract public void EndSession();
        abstract public void InitDevice();
        abstract public void SetRange(int newRange);
        abstract public double GetReading();
        abstract public void ChangeNplc(double newNplcVal);


    }
}
