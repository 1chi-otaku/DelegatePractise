using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractise
{
    class Program
    {
        static public void Main(string[] args)
        {
            #region #1
            //GetMessage messages = new GetMessage(TextMessage.PrintMessage);
            //messages += TextMessage.PrintMessageBackwards;
            //messages += TextMessage.PrintMessageLine;
            //messages("Message!");
            #endregion
            #region #2
            //MathDel mathfunctions = new MathDel(MyMath.Add);
            //mathfunctions += MyMath.Sub;
            //mathfunctions += MyMath.Mult;
            //mathfunctions(6,2);
            #endregion
            #region #3
            ArtihDel arithfunctions = new ArtihDel(Arithmetic.IsEven);
            arithfunctions += Arithmetic.IsOdd;
            arithfunctions += Arithmetic.IsFibonacci;
            arithfunctions += Arithmetic.IsSimple;

            arithfunctions(2);

            Arithmetic.Func(16, Arithmetic.IsFibonacci);

            
          

            #endregion
        }
    }
}
