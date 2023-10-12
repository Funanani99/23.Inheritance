using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // have a class be able inherit characteristics of another
            //can have a superclass and other subclasses

            Chef chef = new Chef(); //the chef object
            chef.MackeChicken();

            ItalianChef chef1 = new ItalianChef();
            chef1.MackeChicken(); //italian chef using his inheritence! chef is superclass, italian chef is subclas
            chef1.MakesPasta(); //calling his own method, chef cant call on make Paste
            chef1.MakeSpecialDish();

            //freeze
            Console.ReadLine();
        }
    }
    internal class ItalianChef: Chef    //tthis makes italian chef inharit all there is in chef, can now call methpds in chef!
    {
        public void MakesPasta()
        {
            Console.WriteLine("Makes Pasta");
        }
        public override void MakeSpecialDish()    // use keyword override
        { 
        Console.WriteLine("The chef makes Italianspecials ");
        }

        //this class inherits from superclass,extend superclass by making new functions and also override some superclass functions
    }

    internal class Chef
    { 
    public void MackeChicken()
        {
            Console.WriteLine("The chef makes chicken");
         }
        public void MakeSalad() 
        {
        Console.WriteLine("The chef makes salad");
        }
        public virtual void MakeSpecialDish() // virtual allows subcalsses to overrride
        {
            Console.WriteLine("The chef makes special dish");
        }
    }
}
