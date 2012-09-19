using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Sandbox
{
    [TestFixture]
    class Scratch
    {

        enum Days { Mon, Tue, Wed };

        [Test]
        public void TestEnum()
        {

            Assert.AreEqual((int)Days.Mon, 0);
            


        }

        [Test]
        public void TestArray()
        {
            int[] age = { 1, 2, 3 };
            
            Console.WriteLine(age.GetType());

        }

        [Test]
        public void TestStringSort()
        {
            int[] age = { 3, 2, 1 };

            foreach (var item in age)
            {
                Console.WriteLine(item.ToString());
            }

            Array.Sort(age);

            foreach (var item in age)
            {
                Console.WriteLine(item.ToString());
            }

            Array.Reverse(age);

            foreach (var item in age)
            {
                Console.WriteLine(item.ToString());
            }
            
        }

        public void TestDateTimeNull()
        {
            DateTime? datetime = new DateTime?();

            datetime = null;

        
        }

        
        

    }
}
