using System;
using System.Collections;

namespace Version_1_C
{
    sealed class clsDateComparer : IComparer {

        private static object SyncLock = new object();
        private static clsDateComparer _instance;

        public static clsDateComparer Instance {
            get {
                lock (SyncLock) {
                    if(_instance == null) {
                        return (_instance = new clsDateComparer());
                    } else {
                        return _instance;
                    }
                }
            }
        }

        private clsDateComparer() {
        }

        public int Compare(Object x, Object y)
        {
            clsWork lcWorkX = (clsWork)x;
            clsWork lcWorkY = (clsWork)y;
            DateTime lcDateX = lcWorkX.GetDate();
            DateTime lcDateY = lcWorkY.GetDate();

            return lcDateX.CompareTo(lcDateY);
        }
    }
}
