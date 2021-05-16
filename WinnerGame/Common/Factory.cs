using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinnerGame.Common
{
    public class Factory
    {
        public static Punter GetPunter(int number)
        {
            if (number == 1)
            {
                return new Joe();
            }
            else if (number == 2)
            {
                return new AI();
            }
            else if (number == 3)
            {
                return new Bob();
            }
            return null;
        }
    }
}
