using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NodaTime;
using Ninject.Modules;
using NUnit.Framework;

namespace Sandbox
{
   
    class Program
    {
        
        public static void Main()
        {
            Injector injector = new Injector();
            //Bind<IClock>().To<>();
            //var presenter = injector.CreateDiaryPresenter();
            //presenter.Start();
        }

        
    }

   
}
