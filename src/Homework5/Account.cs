using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class Account
    {
        public delegate void AccountStateHandler(string message);//обработчик учетной записи
        AccountStateHandler _del;
        int _sum;
        public Account(int sum)
        {
            _sum = sum;
        }
        public int CurrentSum => _sum;
        public void Put(int sum)
        {
            _sum += sum;
        }
        public void WithDraw(int sum)
        {
            if (sum <= _sum)
            {
                _sum -= sum;
                if (_del != null)
                    _del($"Сумма {sum} снята со счета");
            }
            else
            {
                if (_del != null)
                    _del("Недостаточно денег на счете");
            }
        }
        public void RegisterHandler(AccountStateHandler del)// регистрируем делегат. ЧТО ЭТО ЗНАЧИТ???
        {
            _del += del;// добавляем делегат
        }
        public void UnRegisterHandler(AccountStateHandler del)// отмена регистрации делегата???
        {
            _del -= del; // удаляем делегат
        }


    }
}
