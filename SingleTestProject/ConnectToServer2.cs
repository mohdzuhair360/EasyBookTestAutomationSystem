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
using System.Xml;
using NUnit.Framework;

namespace SingleTestProject
{
    class ConnectToServer2
    {
        public IWebDriver driver;
        public XmlDocument xml;
        string serverXPath, server1Name, server2Name, ScrollBottom, footerStr, serverNeeded;
        //string siteType = "test";
        //string testURL = "https://test.easybook.com";
        //string serverWanted = "G3ASPRO01";

        public ConnectToServer2(XmlDocument mainxml, IWebDriver maindriver)
        {
            this.xml = mainxml;
            this.driver = maindriver;

        }

        public void ReadElement(string XMLpath, string serverInput, string siteType)
        {
            xml.Load(XMLpath);
            XmlNodeList xnMenu = xml.SelectNodes("/ETAS/Server");
            foreach (XmlNode xnode in xnMenu)
            {
                string site = char.ToUpper(siteType[0]) + siteType.Substring(1);
                string serverName = char.ToUpper(serverInput[0]) + serverInput.Substring(1);

                serverXPath = xnode["footerElement"][site]["XPath"].InnerText.Trim();
                Console.WriteLine("serverXPath : " + serverXPath);

                serverNeeded = xnode["ServerName"][site][serverName].InnerText.Trim();
                Console.WriteLine("serverXPath : " + serverXPath);

                server1Name = xnode["ServerName"][site]["S1"].InnerText.Trim();
                Console.WriteLine("server1Name : " + server1Name);

                server2Name = xnode["ServerName"][site]["S2"].InnerText.Trim();
                Console.WriteLine("server2Name : " + server2Name);

                ScrollBottom = xnode["JSactions"]["ScrolltoBottom"]["Action"].InnerText.Trim();
                Console.WriteLine("ScrollBottom : " + ScrollBottom);


            }
            Console.WriteLine("Server wanted : " + serverNeeded);

        }

        public void LaunchBrowser(string EBUrl)
        {
            try
            {
                //driver.Navigate().GoToUrl(EBUrl);
                //driver.Manage().Window.Maximize();
                ((IJavaScriptExecutor)driver).ExecuteScript(ScrollBottom);
                Thread.Sleep(2000);

                var footer = driver.FindElement(By.XPath(serverXPath));
                footerStr = footer.Text.ToString();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(footerStr);
                // string server = footerStr.Substring(142, 10);
                //string serverName = server.Trim();
                Console.WriteLine();
                Console.WriteLine();

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Server element not found");
            }
        }

        public IWebDriver ConnectToServerWanted(string EBUrl)
        {
            ConnectToServer2 newServer = new ConnectToServer2(xml, driver);
            try
            {
                //Console.WriteLine("Connect server : "+footerStr);
                while (!footerStr.Contains(serverNeeded))
                {
                    // this.Close();
                    driver.Close();
                    driver = new ChromeDriver();
                    driver.Navigate().GoToUrl(EBUrl);
                    driver.Manage().Window.Maximize();
                    ((IJavaScriptExecutor)driver).ExecuteScript(ScrollBottom);
                    Thread.Sleep(2000);
                    var footer = driver.FindElement(By.XPath(serverXPath));
                    footerStr = footer.Text.ToString();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(footerStr);
                    // string server = footerStr.Substring(142, 10);
                    //string serverName = server.Trim();
                    Console.WriteLine();
                    Console.WriteLine();
                }

                if (footerStr.Contains(serverNeeded))
                {
                    Console.WriteLine("Server " + serverNeeded + " found");
                    return driver;
                }
                return null;
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Server element not found");
                return null;
            }
        }

        private void Close()
        {
            this.Close();
        }
    }
}
