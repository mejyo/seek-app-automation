using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using Target_Appliaction;

namespace MarsFramework
{
    public class Program
    {


        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {


            [Test, Order(1)]
            public void SearchingJobs()
            {


                SearchingJob searchingJobobj = new SearchingJob();

                searchingJobobj.SearchJob();
            }

        }
    }
}