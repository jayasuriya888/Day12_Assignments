using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public class Card : ICard
    {
        AssignmentDBEntities1 db = new AssignmentDBEntities1();
        public bool Authenticate(int CardNo, int cvv)
        {
            var data = db.CardInfoes.Where(x => x.Card_no == CardNo && x.ccvno == cvv).SingleOrDefault();
            if (data == null)
                throw new ArgumentException("Invalid Card Details");
            else
                return true;
        }

        public bool DateCheck(int CardNo, DateTime dt)
        {

            var data1 = db.CardInfoes.Where(x => x.Card_no == CardNo && x.expDate > DateTime.Now).SingleOrDefault();
            if (data1 == null)
                throw new ArgumentException("Card Expired :( ");
            else
                return true;

        }

        public double Trans(int CardNo, double amount)
        {
            var data = db.CardInfoes.Where(x => x.Card_no == CardNo && x.balance > amount).SingleOrDefault();
            if (data == null)
                throw new ArgumentException("Balance is low");
            else
            {

                data.balance = data.balance - amount;

                var olddata = db.CardInfoes.Where(x => x.Card_no == CardNo && x.balance > amount).SingleOrDefault();
                olddata.balance = data.balance;
                var res = db.SaveChanges();
                // Console.WriteLine("Balance sufficient for the transanction .Balance now is: " + data.balance);
                return data.balance;
            }

        }
    }
}
