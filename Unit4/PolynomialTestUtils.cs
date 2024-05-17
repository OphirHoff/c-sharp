using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class PolynomialTestUtils
    {
        public static void Test_SortPolynomial()
        {
            Node<CoefficientPower> lst = new Node<CoefficientPower>(new CoefficientPower(1, 3));
            lst.SetNext(new Node<CoefficientPower>(new CoefficientPower(2, 4)));
            lst.GetNext().SetNext(new Node<CoefficientPower>(new CoefficientPower(6, 1)));

            Polynomial.Print_Polynomial(lst);

            Console.WriteLine();

            lst = Polynomial.SortPolynomial(lst);

            Polynomial.Print_Polynomial(lst);
        }
    }
}
