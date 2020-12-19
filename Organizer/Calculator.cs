using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    class Calculator
    {
        float first;
        float second;
        char operation;

        float result(float x, float y, char o)
        {
            switch (o)
            {
                case '+':
                    return (x + y);
                case '-':
                    return (x - y);
                case '*':
                    return (x * y);
                case '/':
                    return (x / y);
                default: return 0;
            }
        }
    }
}
