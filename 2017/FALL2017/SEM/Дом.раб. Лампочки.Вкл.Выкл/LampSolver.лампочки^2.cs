using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solver
{
    public class LampSolver
    {
        public static int ReturnStatus(int n)
        {

            if (Math.Pow((int)Math.Sqrt((double)n), 2) == n)
                return 1;
            else return 0;
        }
    }
}
