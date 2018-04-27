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
    class LoginEBSite
    {
        private IWebDriver driver;
        string username;
        string password;
        public LoginEBSite(IWebDriver maindriver)
        {
            this.driver = maindriver;
        }

       
        public void loginEB(string EBUrl)
        {
            
            try
            {  
                using (StreamReader sr = new StreamReader("user.txt"))
                {
                    username = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            try
            { 
                using (StreamReader sr = new StreamReader("pass.txt"))
                {
                    password = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }


            try
            {
                //((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0)");
                //driver.Navigate().Refresh();
                driver.Navigate().GoToUrl(EBUrl);
                Thread.Sleep(4000);
                //*[@id="bs-example-navbar-collapse-1"]/ul/li[1]/a
                driver.FindElement(By.XPath("//*[@id=\"bs-example-navbar-collapse-1\"]/ul/li[1]/a")).Click();
                //driver.FindElement(By.LinkText("Sign in")).Click();
                //new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.LinkText("Sign in")))).Click();

                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.Id("loginLink")))).Click();

                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.Id("Email")))).Clear();
                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.Id("Email")))).SendKeys(username);


                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.Id("Password")))).Clear();
                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.Id("Password")))).SendKeys(password);

                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.Id("CaptchaCode")))).Click();

                Thread.Sleep(6000);

                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.Id("btnLogin")))).Click();
                
            }

            catch (NoSuchElementException)
            {
                Console.WriteLine("Login not found");
            }
        }
    }
}