﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.Globalization;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using System.Xml;

namespace EasyBookTestAutomationSystem
{
    class OpenIntendedServer
    {

        //---------------------VARIABLES, XPATH, ID-------------------------------------------//
        //-------------------------------------------------------------------------------------//
        //-------------------------------------------------------------------------------------//
        private IWebDriver driver;
        private XmlDocument xml;

        public OpenIntendedServer(XmlDocument mainxml, IWebDriver maindriver)
        {
            this.xml = mainxml;
            this.driver = maindriver;

        }



        //---Server Variables--//
        string serverType;
        string FooterXP;
        //private string EBUrl;
        string server_1 = "G3ASPRO01";
        string server_2 = "G3ASPRO02";



        //-------------------------------------------------------------------------------------//
        //-------------------------------------------------------------------------------------//


        //---------------------METHODS-------------------------------------------//

        public void ReadElement(string XMLpath)
        {

            xml.Load(XMLpath);
            XmlNodeList xnMenu = xml.SelectNodes("/ETAS/Site");
            foreach (XmlNode xnode in xnMenu)
            {
                FooterXP = xnode["footerElement"]["XPath"].InnerText.Trim();
                Console.WriteLine("FooterXP : " + FooterXP);

            }

        }






        public void LaunchBrowser(string EBurl)
        {
            try
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(EBurl);
                driver.Manage().Window.Maximize();


            }
            catch (Exception e)
            {
                Console.WriteLine("Homepage not found", e);

            }

        }

        public void ConnectServer2(string EBurl)
        {
            try
            {
                string EBUrl = EBurl;
                ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                Thread.Sleep(2000);
                var footer = driver.FindElement(By.XPath(FooterXP));
                string footerStr = footer.Text.ToString();
                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine();

                if (footerStr.Contains(server_2) && !footerStr.Contains(server_1))
                {
                    Console.WriteLine("Current server is : G3ASPRO02");
                    Console.WriteLine("Server S2 found 1 attempt");
                    Thread.Sleep(2000);
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0)");
                    Console.WriteLine();
                    Console.WriteLine();
             


                }
                else if (footerStr.Contains(server_1) && !footerStr.Contains(server_2))
                {
                    Console.WriteLine("Current server is : G3ASPRO01");
                    Console.WriteLine("Server S1 found at 1 attempt");
                    Console.WriteLine();
                    Console.WriteLine();
                    driver.Close();


                    OpenIntendedServer server2 = new OpenIntendedServer(xml, driver);
                    server2.Server2Test(EBUrl);
                    Thread.Sleep(2000);

                }
                else
                {
                    Console.WriteLine("Wrong server name");
                }

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Server not found");

            }

        }

        public void ConnectServer1(string EBurl)
        {
            try
            {
                               string EBUrl = EBurl;
                ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                Thread.Sleep(2000);
                var footer = driver.FindElement(By.XPath(FooterXP));
                string footerStr = footer.Text.ToString();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();


                if (footerStr.Contains(server_1) && !footerStr.Contains(server_2))
                {
                    Console.WriteLine("Current server is : G3ASPRO01");
                    Console.WriteLine("Server S1 found");
                    Thread.Sleep(2000);
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0)");
                    Console.WriteLine();
                    Console.WriteLine();
                 
                }
                else if (footerStr.Contains(server_2) && !footerStr.Contains(server_1))
                {
                    Console.WriteLine("Current server is : G3ASPRO02");
                    Console.WriteLine("Server S2 found");
                    Console.WriteLine();
                    Console.WriteLine();
                    driver.Close();


                    OpenIntendedServer server1 = new OpenIntendedServer(xml, driver);
                    server1.Server1Test(EBUrl);
                    Thread.Sleep(2000);

                }
                else
                {
                    Console.WriteLine("Wrong server name");
                }


            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Server not found");

            }

        }


        public void Server1Test(string EBUrl)
        {
           
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(EBUrl);
            driver.Manage().Window.Maximize();
            
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
            Thread.Sleep(2000);

            var footer = driver.FindElement(By.XPath(FooterXP));
            string footerStr = footer.Text.ToString();

            int i = 1;

            while (!footerStr.Contains(server_1))
            {
                driver.Close();
               
                i++;

                Thread.Sleep(2000);
       
                if (footerStr.Contains(server_1))
                {
                    break;
                }

                OpenIntendedServer server1 = new OpenIntendedServer(xml, driver);
                server1.Server1Test(EBUrl);

                if (footerStr.Contains(server_1))
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Current server is : G3ASPRO01");
            Console.WriteLine("Server S1 found " + i + " attempt");
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0)");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine();
            return;
        }


        public void Server2Test(string EBUrl)
        {
            
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(EBUrl);
            driver.Manage().Window.Maximize();
            
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
            Thread.Sleep(2000);

            var footer = driver.FindElement(By.XPath(FooterXP));
            string footerStr = footer.Text.ToString();

            int i = 1;

            while (!footerStr.Contains(server_2))
            {
                driver.Close();

                i++;
                Thread.Sleep(2000);

                if (footerStr.Contains(server_2))
                {
                    break;
                }

                OpenIntendedServer server2 = new OpenIntendedServer(xml, driver);
                server2.Server1Test(EBUrl);

                if (footerStr.Contains("G3ASPRO02"))
                {
                    break;
                }

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Current server is : G3ASPRO02");
            Console.WriteLine("Server S2 found at " + i + " attempt");
            Console.WriteLine();
            Console.WriteLine();
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0)");
            Thread.Sleep(2000);
            
            return;

        }
    }
}