using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T,P>
    {
        T[] seriNo;
        P[] urunAdi;
        public MyDictionary()
        {
            seriNo = new T[0];
            urunAdi = new P[0];
        }
        public void Add(T sno, P uad )
        {
            T[] tempArray1 = seriNo;
            
            seriNo = new T[seriNo.Length + 1];
            for (int i = 0; i < tempArray1.Length; i++)
            {
                seriNo[i] = tempArray1[i];
            }
            seriNo[seriNo.Length - 1] = sno;

            P[] tempArray2 = urunAdi;

            urunAdi = new P[urunAdi.Length + 1];
            for (int i = 0; i < tempArray2.Length; i++)
            {
                urunAdi[i] = tempArray2[i];
            }
            urunAdi[urunAdi.Length - 1] = uad;
        }
    }
}
