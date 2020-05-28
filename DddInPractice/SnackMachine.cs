using System;
using System.Collections.Generic;
using System.Text;

namespace DddInPractice.Logic
{
    public sealed class SnackMachine
    {
        //sealed keyword used to restrict the inheritance feature of object oriented programming
        //inserting separate properties for the different coins and bills, keeps track of the exact amount of each one

        //This replaces using Money's properties twice for syste and transaction 
        public Money MoneyInside { get; set; }
        public Money MoneyInTransaction { get; set; }

        public void InsertMoney(Money money)
        {
            MoneyInTransaction += money;
        }

        public void ReturnMoney()
        {
            //MoneyInTransaction = 0;
        }

        public void BuySnack()
        {
            MoneyInside += MoneyInTransaction;
            //MoneyInTransaction = 0;
        }
    }
}
