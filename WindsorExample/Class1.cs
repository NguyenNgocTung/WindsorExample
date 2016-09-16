using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindsorExample
{
    public class Class1
    {
    }

    public interface IPrint
    {
        void Print(string val);
    }
    public interface IRead
    {
        string Read();
    }


    public class Scanner : IRead
    {
        public string Read()
        {
            Console.Write("Canning paper.....");
            return "Orient Software DEV";
        }
    }

    public class Printer : IPrint
    {
        public void Print(string text)
        {
            Console.WriteLine(string.Format("Printing: {0}", text));
        }
    }


    public class Copy
    {
        private IRead _reader;
        private IPrint _printer;
        public Copy(IPrint printer, IRead reader)
        {
            this._reader = reader;
            this._printer = printer;
        }

        public void DoCopy()
        {
            var content = _reader.Read();
            _printer.Print(content);
        }
    }

}
