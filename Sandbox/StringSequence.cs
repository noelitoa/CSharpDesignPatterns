using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Sandbox
{
    public sealed class StringSequence
    {
        public static string Sequence(string input)
        {
            StringBuilder result = new StringBuilder();
            string[] str = input.Split(' ');

            foreach (var item in str)
            {
                if (item == "aaa")
                    result.Append("0");
                if (item == "aba")
                    result.Append("1");
            }

            return result.ToString();
        }

    }

    [TestFixture]
    public class StringProgram
    {
        [Test]
        public void TestSequence()
        {
            Assert.AreEqual(StringSequence.Sequence("aaa aba aab aaa"), "010");
        }
    }

}
