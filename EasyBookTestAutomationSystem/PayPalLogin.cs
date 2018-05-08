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
    class PayPalLogin
    {
        private IWebDriver driver;
        private XmlDocument xml;

        public PayPalLogin(XmlDocument mainxml, IWebDriver maindriver)
        {
            this.xml = mainxml;
            this.driver = maindriver;

        }

        string LoginButtonFirst, emailElementID, emailVal, emailProceedElementId, emailProceedElementXp, passwordElemId, pwVal, LoginButtonCss, LoginButtonXP;
        public void ReadElement(string XMLpath)
        {
            xml.Load(XMLpath);
            XmlNodeList xnMenu = xml.SelectNodes("/ETAS/PayPalLogin");
            foreach (XmlNode xnode in xnMenu)
            {
                LoginButtonFirst = xnode["LoginButton"]["Id"].InnerText.Trim();
                Console.WriteLine("LoginButtonFirst : " + LoginButtonFirst);

                emailElementID = xnode["Email"]["Id"].InnerText.Trim();
                Console.WriteLine("emailElementID : " + emailElementID);

                emailVal = xnode["Email"]["Value"].InnerText.Trim();
                Console.WriteLine("emailVal : " + emailVal);

                emailProceedElementXp = xnode["Email"]["ContinueButton"]["XPath"].InnerText.Trim();
                Console.WriteLine("emailProceedElementXp : " + emailProceedElementXp.Trim());

                emailProceedElementId = xnode["Email"]["ContinueButton"]["Id"].InnerText.Trim();
                Console.WriteLine("emailProceedElementId : " + emailProceedElementId.Trim());

                passwordElemId = xnode["Password"]["Id"].InnerText.Trim();
                Console.WriteLine("paymentGateID : " + passwordElemId);

                pwVal = xnode["Password"]["Value"].InnerText.Trim();
                Console.WriteLine("payNowElement : " + pwVal);

                LoginButtonCss = xnode["Password"]["ContinueButton"]["CssSelector"].InnerText.Trim();
                Console.WriteLine("LoginButton : " + LoginButtonCss);

                LoginButtonXP = xnode["Password"]["ContinueButton"]["XPath"].InnerText.Trim();
                Console.WriteLine("LoginButton : " + LoginButtonXP);


            }
        }

        public void ClickLogin()
        {
            try
            {
                new WebDriverWait(driver,
                    TimeSpan.FromSeconds(60)).Until(ExpectedConditions.ElementExists(By.LinkText(LoginButtonFirst))).Click();
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Cannot click login");
            }
        }

        public void enterEmPP()
        {
            try
            {
                Thread.Sleep(5000);
                driver.FindElement(By.Id(emailElementID)).SendKeys(emailVal);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Cannot find email element");
            }

            try
            {
                driver.FindElement(By.XPath(emailProceedElementXp)).Click();

                Thread.Sleep(3000);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Cannot proceed to pw");
            }
        }

        public void enterPwPP()
        {
            try
            {
                var password = driver.FindElement(By.Id(passwordElemId));
                password.SendKeys(pwVal);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Cannot find pw");
            }
            try
            {
                driver.FindElement(By.CssSelector(LoginButtonCss)).Click();
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Cannot login");
            }

        }
    }
}
