using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //int [] numArray = {0,1,2,3,4,5,6,78,9};
            //Console.WriteLine(numArray[7]);//print 78 because it is value of 7 idx
            //string [] namArray = new string[4] {"Tim", "Martin", "Nikki", "Sara"};
            //Console.WriteLine(namArray[3]);//print "Sara" because it is value of 3 idx
            //string [] boolArray = new string[10] {"True", "False", "True", "False", "True", "False","True", "False", "True", "False"};
            //Console.WriteLine(boolArray[7]);//print False because that is 7th idx
            //List<string> flavor = new List<string>();
            //flavor.Add("Vanilla");
            //flavor.Add("Choclate");
            //flavor.Add("Strawberry");
            //flavor.Add("Cookie Dough");
            //flavor.Add("Bubble Gum");
            //Console.WriteLine(flavor[3]);//print Cookie Dough because the is th e3 idx of the list
            //flavor.RemoveAt(3);//removed the 3rd idx
            //Console.WriteLine(flavor.Count);//Prints 5 as the list "flavor" has a count length of 5, then 4 after removal
            Dictionary<string,string> userFlavor = new Dictionary<string,string>();
            userFlavor.Add("Tim", "Vanilla");
            userFlavor.Add("Martin", "Strawberry");
            userFlavor.Add("Nikki", "Chocolate");
            userFlavor.Add("Sara", "Bubble-gume");
            foreach (KeyValuePair<string,string> entry in userFlavor)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }

        }
    }
}
