using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTech1.Data
{
    /*
     * класс для работы с таблицей линкс
     */
    class Link
    {
        Int64 izdelup;
        public Int64 Izdelup
        {
            get { return izdelup; }
            set { izdelup = value; }
        }

        Int64 izdel;
        public Int64 Izdel
        {
            get { return izdel; }
            set { izdel = value; }
        }

        int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public Link(Int64 Izdelup, Int64 Izdel, int Count)
        {
            izdelup = Izdelup;
            izdel = Izdel;
            count = Count;


        }

    }
}
