using System;
using System.Collections.Generic;

using System.Linq;

using System.Xml.Linq;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "lokesh", "vinay", "vijay", "rakesh", "santosh","anil" };
            //UsingLinq(names);           
            //UsingLinqExetension(names);
            //usingLinqFunctions(names);
            //UsingAnonymous(names);
            //UsingLinqReadXml(names);
            //UsingLinqToXmlNode(names);
            UsingLinqToXmlDeleteNode(names);

        }

        private static void UsingLinqToXmlDeleteNode(string[] names)
        {
            string myXML = @"<Departments>
                       <Department>Account</Department>
                       <Department>Sales</Department>
                       <Department>Pre-Sales</Department>
                       <Department>Marketing</Department>
                       </Departments>";
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);
            xdoc.Descendants().Where(s => s.Value == "Sales").Remove();
            var result = xdoc.Element("Departments").Descendants();
            foreach (XElement item in result)
            {
                Console.WriteLine("Departmant Name--" + item.Value);
            }
            Console.WriteLine("press any key to continue========");
            Console.ReadLine();
        }

        //private static void UsingLinqToXmlNode(string[] names)
        //{
        //    string myXML = @"<Departments>
        //               <Department>Account</Department>
        //               <Department>Sales</Department>
        //               <Department>Pre-Sales</Department>
        //               <Department>Marketing</Department>
        //               </Departments>";
        //    XDocument xdoc = new XDocument();
        //    xdoc = XDocument.Parse(myXML);
        //    xdoc.Element("Departments").Add(new XElement("Department","Finanance"));
        //    xdoc.Element("Departments").AddFirst(new XElement("Department","Support"));
        //    var result = xdoc.Element("Departments").Descendants();
        //    foreach (XElement item in result)
        //    {
        //        Console.WriteLine("Departmant Name--" + item.Value);
        //    }
        //    Console.WriteLine("press any key to continue========");
        //    Console.ReadLine();
        //}

        //private static void UsingLinqReadXml(string[] names)
        //{
        //    string myXML = @"<Departments>
        //               <Department>Account</Department>
        //               <Department>Sales</Department>
        //               <Department>Pre-Sales</Department>
        //               <Department>Marketing</Department>
        //               </Departments>";
        //    XDocument xdoc = new XDocument();
        //    xdoc = XDocument.Parse(myXML);
        //    var result = xdoc.Element("Departments").Descendants();

        //    foreach(XElement item in  result)
        //    {
        //        Console.WriteLine("Departmant Name--" +item.Value);
        //    }
        //    Console.WriteLine("press any key to continue========");
        //    Console.ReadLine();
        //}

        //private static void UsingAnonymous(string[] names)
        //{
        //    Func<string, string> extract = delegate (string s)
        //    {
        //           return s;
        //    };
        //    Func<string,bool> filter = delegate (string s)
        //    {
        //           return s.Length == 5;
        //    };
        //    Func<string, string> program = delegate (string s)
        //    {
        //           return s.ToUpper();
        //    };
        //    IEnumerable<string> query = names.Where(filter)
        //        .OrderBy(extract)
        //        .Select(program);
        //    foreach(string item in query)
        //    {
        //        Console.WriteLine(item);
        //        Console.ReadLine();
        //    }
        //}

        //private static void usingLinqFunctions(string[] names)
        //{
        //    Func<string, bool> filter = s => s.Length == 5;
        //    Func<string, string> extract = s => s;
        //    Func<string, string> project = s => s.ToUpper();
        //    IEnumerable<string> query = names.Where(filter)
        //        .OrderBy(extract)
        //        .Select(project);
        //    foreach(string item in query)
        //    {
        //        Console.WriteLine(item);
        //        Console.ReadLine();
        //    }
        //}

        //private static void UsingLinqExetension(string[] names)
        //{
        //    IEnumerable<string> query = names
        //                                .Where (s => s.Length == 5)
        //                                .OrderBy(s => s)
        //                                .Select(s => s.ToUpper());
        //    foreach(string item in query)
        //    {
        //        Console.WriteLine(item);
        //        Console.ReadLine();
        //    }

        //}

        //private static void UsingLinq(string[] names)
        //{
        //    IEnumerable<string> query = from s in names
        //                                where s.Length == 4
        //                                orderby s
        //                                select s.ToUpper();
        //    foreach(string item in query)
        //    {
        //        Console.WriteLine(item);
        //        Console.ReadLine();
        //    }
        //}
    }
}
