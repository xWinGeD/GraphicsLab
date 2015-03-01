using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.ZondMethod.Data;

namespace Lab.ZondMethod
{
    public class ListComparer : IEqualityComparer<Points>
    {
        public bool Equals(Points x, Points y)
        {
            if (x.X == y.X && x.Y == y.Y)
                return true;
            return false;
        }

        public int GetHashCode(Points obj)
        {
            int hCode = obj.X ^ obj.Y;
            return hCode.GetHashCode();
        }
    }
}
