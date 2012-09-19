using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NodaTime;

namespace Sandbox
{

    public class BadDuration
    {
        private readonly long ticks;

        public long Ticks { get { return ticks; } }

        private BadDuration (long ticks)
	    {
            this.ticks = ticks;
	    }

        public static BadDuration FromTicks(long ticks)
        {
            return new BadDuration(ticks);
        }

        public static BadDuration FromMilliSeconds(long milliseconds)
	    {
            return new BadDuration(milliseconds * 10000);
	    }

        public static BadDuration FromSeconds(long seconds)
	    {
            return new BadDuration(seconds * 10000 * 1000);
	    }


    }

    [TestFixture]
    class SimpleImmutability
    {
        [Test]
        public void FromSeconds()
        {
            BadDuration bd = BadDuration.FromSeconds(5);
            Assert.AreEqual(50000000, bd.Ticks);
        }

        [Test]
        public void FromTicks()
        {
            BadDuration bd = BadDuration.FromTicks(10);
            Assert.AreEqual(10, bd.Ticks);
        }

        [Test]
        public void BuildPattern()
        {
            Period period = Period.FromHours(5);

            period = Period.FromHours(5) + Period.FromMinutes(3);

            
            
        }

        [Test]
        public void TestShy()
        {
            ShyPeriod sp = new ShyPeriod.Builder() { Name = "ShyPeriod" }.Build();

            //Assert.AreEqual(

            

        }

    }


    // option for builder
    public sealed class EfficientFoo
    {
        private string name;
        
        private EfficientFoo()
        {
    
        }

        public sealed class Builder
        {

            private EfficientFoo foo;

            public string Name
            {
                get { return foo.name; }
                set { foo.name = value; }
            }


            public EfficientFoo Build()
            {
                EfficientFoo copy = foo;
                foo = null;
                return copy;

            }
        
        }



    
    }


    //option for creating a builder
    public sealed class ShyPeriod
    {
        private readonly string name;

        //public string Name { get { return name; } }

        private ShyPeriod(Builder build)
        {
            this.name = build.Name;
        }

        public sealed class Builder
        {
            public string Name { get; set; } 

            public ShyPeriod Build()
            {
                return new ShyPeriod(this);
            }
        
        }

    
    }



    public sealed class Point
    {
        private readonly int x;
        private readonly int y;


        public int X { get { return x; } }
        public int Y { get { return y; } }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    
    }


    
}
