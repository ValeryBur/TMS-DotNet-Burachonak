using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    public class Atm
    {
        public event Action<decimal, string> BalanceHandler;
        private decimal _balance = 0M;
        public void GetMoney(decimal money)
        {
            _balance -= money;
            BalanceHandler?.Invoke(_balance, "get");
        }
        public void PutMoney(decimal money)
        {
            _balance += money;
            BalanceHandler?.Invoke(_balance, "put");
        }
        public void ShowInfo()
        {
            //var eventName = "show";
            BalanceHandler?.Invoke(_balance, "show");
        }

    }
}
