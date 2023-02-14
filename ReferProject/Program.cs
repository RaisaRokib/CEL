
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferProject
{
    public class telephone
    {
        protected int x;
        private int balance;
        public void setBalance(int amount)
        {
            this.balance = amount;
        }
        public int getBalance()
        {
            return this.balance;
        }

        protected void amiProtected()
        {
            Console.WriteLine("I am protected and printable");
        }
        internal protected void amiInternalProtected()
        {
            Console.WriteLine("This is Internal Protected");
        }
     
        public void checks()
        {
            Console.WriteLine("this is telephone");
        }
    }
    public class Samsung : telephone
    {

        public void Access()
        {
            telephone tele = new telephone();
            //In same project
            //tele.amiProtected();//not possible to be called with object
            tele.amiInternalProtected();//possible to call even with object when inherited or not
            amiInternalProtected();//can be called without creating object only when inherited
            amiProtected();//can be called without creating object only when inherited
        }
    }




    public class Program
    {

        static void Main(string[] args)
        {
            telephone tele = new telephone();
            tele.checks();//njerproj e public e access pelo

            //tele.balance=10; can not access private
            tele.setBalance(10);//now can access private member using setter
            tele.getBalance();

            //tele.amiInternalProtected();
            Samsung sam = new Samsung();
            sam.Access();

            Console.ReadKey();
        }
    }
}