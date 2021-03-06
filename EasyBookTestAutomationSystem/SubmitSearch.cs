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
using System.IO;

namespace EasyBookTestAutomationSystem
{
    class SubmitSearch
    {
       
        string LinkTextSearch, XPSearch, ClNameSearch, CssSearch;
       
        public IWebDriver driver;
        public XmlDocument xml;

        public SubmitSearch(XmlDocument mainxml, IWebDriver maindriver)
        {
            this.xml = mainxml;
            this.driver = maindriver;

        }
        public void ReadElement(string XMLpath, string prodName)
        {
            string productType = char.ToUpper(prodName[0]) + prodName.Substring(1);
            xml.Load(XMLpath);
            XmlNodeList xnMenu = xml.SelectNodes("/ETAS/SubmitSearch");
            foreach (XmlNode xnode in xnMenu)
            {
                XPSearch = xnode["SearchButton"]["XPath"][productType].InnerText.Trim();
                LinkTextSearch = xnode["SearchButton"]["LinkText"].InnerText.Trim();
                ClNameSearch = xnode["SearchButton"]["ClassName"].InnerText.Trim();
                CssSearch = xnode["SearchButton"]["CssSelector"].InnerText.Trim();
            }

        }
        public void confirmSearch()
        {
            try
            {
                driver.FindElement(By.XPath(XPSearch)).Click();
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Submit button not found");
            }

        }
    }
}
