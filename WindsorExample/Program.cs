using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindsorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var listStrings = new List<string>();
            string str1 = "cat.";
            string str2 = "896.";
            string str3 = "?=+.";
            string str4 = "ngoc tung";
            listStrings.Add(str1);
            listStrings.Add(str2);
            listStrings.Add(str3);
            listStrings.Add(str4);
            Regex regex = new Regex(@"...\.");

            MathRex<string>(regex, listStrings);

            Console.Read();
        }

        public static void MathRex<T>(Regex regex, IEnumerable<T> listObjs)
        {
            foreach(var obj in listObjs)
            {
                Console.WriteLine(regex.Match(obj.ToString()));
            }
        }

        public static void alert(ref Foo fo)
        {
            Console.WriteLine(string.Format("this is {0}", fo.Name));
            fo.Name += "ngoc";
        }
        public static void outAlert(out Foo fo)
        {
            fo = new Foo("Hello");
        }
    }
    
    
    public class Foo
    {
        public Boo myBoo { get; set; }
        public Foo(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }

    public class Boo
    {
        public int Id { get; set; }
    }
    public interface IDo
    {
        void Do();
    }

    public class Work : IDo
    {
        public void Do()
        {
            Console.WriteLine("Doing something...");
        }
    }

    
   public class Machine
    {
        private IDo _power;
        public Machine(IDo power)
        {
            _power = power;
        }

        public void DoWork()
        {
            _power.Do();
        }
    }
}
