using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3
{
    class Money
    {
        private int _par;
        private int _count;

        public int GetPar()
        {
            return _par;
        }
        public void SetPar(int par)
        {
            _par= par;
        }


        public int GetCount()
        {
            return _count;
        }
        public void SetCount(int count)
        {
            _count = count;
        }



        public Money(int par, int count)
        {
            _par = par;
            _count = count;
        }

        public int GetSumm()
        {
            int summ = _par * _count;
            return summ;
        }

        public string GetMoney()
        {
            string result = _par.ToString() + " " + _count.ToString(); 
            return result;
        }

        public bool CanYouBuy(int N)
        {
            
            if(_par*_count>N)
            {
                return true;
            }
            return false;
        }

        public int HowMuchCanYouBuy(int n)
        {
            int countOfProuduct = (_par * _count) / n;
            return countOfProuduct;
        }
    }
}
