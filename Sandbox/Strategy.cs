using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Collections;
using System.Collections.ObjectModel;

namespace Sandbox
{
    [TestFixture]
    public class Strategy
    {

        public static readonly ReadOnlyCollection<Person> People = new List<Person>
        {
            new Person { Name="Juan", Age=11},
            new Person { Name="Mark", Age=45},
            new Person { Name="Luke", Age=32},
            new Person { Name="Mateo", Age=13},
            new Person { Name="Mary", Age=13},
            new Person { Name="John", Age=13}

        }.AsReadOnly();


        public static readonly ReadOnlyCollection<Product> Products = new List<Product>
            {
                new Product { ID=1, Name="Kindle", Price=69},
                new Product { ID=2, Name="Kindle Paperwhite", Price=119},
                new Product { ID=3, Name="Kindle Fire HD", Price=199},
                new Product { ID=4, Name="Kindle Fire", Price=149}


            }.AsReadOnly();

        [Test]
        public void SortingByAge()
        {
            var list = People.ToList();

            list.Sort(LoggingComparer.For(new AgeComparer()));

            //list.Sort(CompareByAge);
            //list.Sort((x, y) => x.Age.CompareTo(y.Age));
            //list.Sort(new AgeComparer().Compare);

            foreach (var person in list)
            {
                Console.WriteLine(person);
            }
        }
                
        [Test]
        public void SortingByPrice()
        {
            var list = Products.ToList();

            list.Sort(new LoggingComparer<Product>(new PriceComparer()));

            foreach (var product in Products)
            {
                Console.WriteLine(product);
            }
        }


        [Test]
        public void SortingReverseByAge()
        {
            var list = People.ToList();

            list.Sort(ReverseLoggingComparer.For(new AgeComparer()));

            //list.Sort(CompareByAge);
            //list.Sort((x, y) => x.Age.CompareTo(y.Age));
            //list.Sort(new AgeComparer().Compare);

            foreach (var person in list)
            {
                Console.WriteLine(person);
            }
        }

        static int CompareByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }

        public class PriceComparer : IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
                return x.Price.CompareTo(y.Price);
            }
        }

        public class AgeComparer : IComparer<Person>
        {

            public int Compare(Person x, Person y)
            {
                return x.Age.CompareTo(y.Age);
            }
        }


        

    }

    public static class ReverseLoggingComparer
    {
        public static IComparer<T> For<T>(IComparer<T> comparer)
        {
            return new ReverseLoggingComparer<T>(comparer);

        }
    }

    public static class LoggingComparer
    {
        public static IComparer<T> For<T>(IComparer<T> comparer)
        {
            return new LoggingComparer<T>(comparer);
        
        }
    }


    public sealed class ReverseLoggingComparer<T> : IComparer<T>
    {
        private readonly IComparer<T> comparer;

        public ReverseLoggingComparer(IComparer<T> comparer)
        {
            this.comparer = comparer;
        }



        public int Compare(T x, T y)
        {
            int result = comparer.Compare(y, x);
            Console.WriteLine("Compare {0}, {1} == {2}", y, x, result);
            return result;
        }

    }

    public sealed class LoggingComparer<T> : IComparer<T>
    {
        private readonly IComparer<T> comparer;

        public LoggingComparer(IComparer<T> comparer)
        {
            this.comparer = comparer;
        }



        public int Compare(T x, T y)
        {
            int result = comparer.Compare(x, y);
            Console.WriteLine("Compare {0}, {1} == {2}", x,y, result);
            return result;
        }

    }
}
