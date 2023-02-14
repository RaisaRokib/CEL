using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReferProject;

namespace MainProj 
{
    internal class Program
    {
        static void Main(string[] args)
        {  //1-class banano and object create
            MobilePhone mp = new MobilePhone();
            mp.brandName = "Redmi";
            Console.WriteLine(mp.brandName);

            //2-interface implementation,int and string return
            Nokia n = new Redmi();
            Console.WriteLine(n.makeCall());
            Console.WriteLine(n.ring());
             

           //3-abstract class and its implementation
            Motorola mot = new Mi();
            mot.sendMessage();
            
          //5-Overloading
            Overloading ov=new Overloading();
            ov.sound();
          //Overriding
            Samsung s = new Samsung();
            s.Price();

            prcheck pr = new prcheck();
            pr.acc();//protected members can be accessed via child class does not matter same or other project
            //object create kore protected member der access pawa jayna
            telephone t = new telephone();
            t.checks();//public can also access from other project
            Console.ReadLine();

        }

    }

    public class MobilePhone
    {
        public string brandName;
        public void Price()
        {
            Console.WriteLine("155000taka");
        }     

    }
    class Samsung : MobilePhone
    {

        public void Price()
        {
            Console.WriteLine("dam barlo");
        }
    }

    abstract class Motorola
    {
        public abstract void sendMessage();
    }
    class Mi : Motorola
    {
        public override void sendMessage()
        {
            Console.WriteLine("sending a message using Mi");
        }
    }
    interface  Nokia
    {
        int makeCall();
        string ring();

    }
    class Redmi:Nokia
    {
        public int makeCall()
        {
            return 12345;
        }
        public string ring() 
        {
            return "ring";
         }
    }
    public class Overloading
    {
        public void sound(string x,string y)
        {
            Console.WriteLine(x,y);
        }
        public void sound(int y)
        {
            Console.WriteLine(y);
        }
        public void sound()
        {
            Console.WriteLine("parameter nai");
        }
    }

    class prcheck : telephone
    {
        telephone tele = new telephone();
        public void acc()
        {
            amiInternalProtected();//object er through te kora jayna

            amiProtected();//object er through te access kora jayna
        }
    }
}