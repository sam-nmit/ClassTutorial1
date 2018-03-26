using System;
using System.Collections;

namespace Version_1_C
{
    class clsNameComparer : IComparer
    {
        private static readonly clsNameComparer _instance = new clsNameComparer();
        public static clsNameComparer Instance => _instance;

        private clsNameComparer() {
        }

        public int Compare(Object x, Object y)
        {
            clsWork workClassX = (clsWork)x;
            clsWork workClassY = (clsWork)y;
            string lcNameX = workClassX.GetName();
            string lcNameY = workClassY.GetName();

            return lcNameX.CompareTo(lcNameY);
        }
    }
}
