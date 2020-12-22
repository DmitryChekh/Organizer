using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Organizer
{
    class Calculate
    {
        private readonly ICalculator _calculator;
        
        public Calculate(ICalulator calculator) {
            _calculator = calculator;   
        } // И дальше используй этот сервис

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    a = b;
                    break;

                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    a = b;
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    a = b;
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    a = b;
                    break;
                default:
                    break;
            }
        }
    }
}
