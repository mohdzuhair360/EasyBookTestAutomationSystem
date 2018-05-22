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
using System.Reflection;

namespace SingleTestProject
{
    class CarOrderSummary
    {
        IWebDriver driver = new ChromeDriver();
        public void LaunchBrowser(string url)
        {
            try
            {
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                //Console.WriteLine("Chrome open");
                //Thread.Sleep(2000);

            }
            catch (Exception e)
            {
                Console.WriteLine("Homepage not found", e);

            }

        }
        public void ProductName()
        {
            try
            {
                var Div1 = driver.FindElement(By.XPath("//div[@id='print-content']/table/tbody/tr/td/table/tbody/tr[2]/td"));
                string Cluster1 = Div1.Text.ToString();
                //Console.WriteLine(Cluster1);
                //Console.WriteLine();
                //Console.WriteLine();
                string FrontTrim = Cluster1.Remove(0, 73);
                //Console.WriteLine(FrontTrim);
                //Console.WriteLine();
                //Console.WriteLine();
                string BackTrim = FrontTrim.Remove(23, 36);
                //Console.WriteLine(BackTrim);
                //Console.WriteLine();
                //Console.WriteLine();
                string CartID = BackTrim.Trim();
                //Console.WriteLine(PurchaseDate);
                //Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine("Cart ID : " + CartID);
                string product = CartID;
                // Console.WriteLine(product);

                if (product.Contains("FR"))
                {
                    string productName = "Ferry";
                    Console.WriteLine("Product : " + productName);

                }
                else if (product.Contains("TR"))
                {
                    string productName = "Train";
                    Console.WriteLine("Product : " + productName);

                }
                else if (product.Contains("BUS"))
                {
                    string productName = "Bus";
                    Console.WriteLine("Product : " + productName);

                }
                else if (product.Contains("CR"))
                {
                    string productName = "Car";
                    Console.WriteLine("Product : " + productName);

                }
                else
                {
                    Console.WriteLine("Cannot identify product name");

                }



                //Console.WriteLine("Cart ID : " + CartID2);
                //Console.WriteLine("Product : " + product);

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Product Name not found");

            }

        }
        public void OrderNo()
        {
            try
            {
                var OrderNo = driver.FindElement(By.XPath("//div[@id='print-content']/table/tbody/tr/td/table/tbody/tr[2]/td/strong/span"));
                Console.WriteLine("Order no : " + OrderNo.Text.ToString().Trim());
                //Console.WriteLine("Order no : "+ OrderNo.Text);

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Order No not found");

            }

        }

        public void PurchaseDate()
        {
            try
            {
                var Div1 = driver.FindElement(By.XPath("//div[@id='print-content']/table/tbody/tr/td/table/tbody/tr[2]/td"));
                string Cluster1 = Div1.Text.ToString();
                //Console.WriteLine(Cluster1);
                //Console.WriteLine();
                //Console.WriteLine();
                string FrontTrim = Cluster1.Remove(0, 42);
                //Console.WriteLine(FrontTrim);
                //Console.WriteLine();
                //Console.WriteLine();
                string BackTrim = FrontTrim.Remove(21, 69);
                //Console.WriteLine(BackTrim);
                //Console.WriteLine();
                //Console.WriteLine();
                string PurchaseDate = BackTrim.Trim();
                //Console.WriteLine(PurchaseDate);
                //Console.WriteLine();
                //Console.WriteLine();
                Console.WriteLine("Purchase date : " + PurchaseDate);

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Purchase date not found");

            }

        }

        public void CartID()
        {
            try
            {
                var Div1 = driver.FindElement(By.XPath("//div[@id='print-content']/table/tbody/tr/td/table/tbody/tr[2]/td"));
                string Cluster1 = Div1.Text.ToString();
                //Console.WriteLine(Cluster1);
                //Console.WriteLine();
                //Console.WriteLine();
                string FrontTrim = Cluster1.Remove(0, 73);
                //Console.WriteLine(FrontTrim);
                //Console.WriteLine();
                //Console.WriteLine();
                string BackTrim = FrontTrim.Remove(23, 36);
                //Console.WriteLine(BackTrim);
                //Console.WriteLine();
                //Console.WriteLine();
                string CartID = BackTrim.Trim();
                //Console.WriteLine(PurchaseDate);
                //Console.WriteLine();
                //Console.WriteLine();
                Console.WriteLine("Cart ID : " + CartID);

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("CartID not found");

            }

        }

        public void PickupLocation()
        {
            try
            {
                //*[@id="print-content"]/table[1]/tbody/tr/td/table[2]/tbody/tr[2]/td/table[2]/tbody/tr[5]/td[2]
                var PickupLocation = driver.FindElement(By.XPath("//*[@id=\"print-content\"]/table[1]/tbody/tr/td/table[2]/tbody/tr[2]/td/table[2]/tbody/tr[5]/td[2]"));
                Console.WriteLine("Pickup location : " + PickupLocation.Text.ToString().Trim());


            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Pickup cocation not found");

            }

        }

        public void ReturnLocation()
        {
            try
            {
                //*[@id="print-content"]/table[1]/tbody/tr/td/table[2]/tbody/tr[2]/td/table[2]/tbody/tr[6]/td[2]
                var ReturnLocation = driver.FindElement(By.XPath("//*[@id=\"print-content\"]/table[1]/tbody/tr/td/table[2]/tbody/tr[2]/td/table[2]/tbody/tr[6]/td[2]"));
                Console.WriteLine("Return location : " + ReturnLocation.Text.ToString().Trim());


            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Return location not found");

            }

        }

        public void RentDuration()
        {
            try
            {
                //*[@id="print-content"]/table[1]/tbody/tr/td/table[2]/tbody/tr[2]/td/table[2]/tbody/tr[7]/td[2]
                var RentDuration = driver.FindElement(By.XPath("//*[@id=\"print-content\"]/table[1]/tbody/tr/td/table[2]/tbody/tr[2]/td/table[2]/tbody/tr[7]/td[2]"));
                Console.WriteLine("Rent duration is : " + RentDuration.Text.ToString().Trim());

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Rent duration not found");

            }

        }

        public void DepartTime()
        {
            try
            {
                //*[@id="print-content"]/table/tbody/tr/td/table[3]/tbody/tr[2]/td/table[1]/tbody/tr[5]/td[2]
                var DepartTime = driver.FindElement(By.XPath(" //*[@id=\"print-content\"]/table/tbody/tr/td/table[3]/tbody/tr[2]/td/table[1]/tbody/tr[5]/td[2]"));
                Console.WriteLine("Depart Time : " + DepartTime.Text.ToString().Trim());
                //Console.WriteLine("Depart Time: " + DepartTime.Text);

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Depart Time not found");

            }

        }

        public void CarDetail()
        {
            try
            {

                //*[@id="print-content"]/table[1]/tbody/tr/td/table[2]/tbody/tr[2]/td/table[2]/tbody/tr[1]/td[2]
                var CarDetail = driver.FindElement(By.XPath(" //*[@id=\"print-content\"]/table[1]/tbody/tr/td/table[2]/tbody/tr[2]/td/table[2]/tbody/tr[1]/td[2]"));
                Console.WriteLine("Car Detail : " + CarDetail.Text.ToString().Trim());


            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Car detail not found");

            }

        }
        public void Company()
        {
            try
            {
                //*[@id="print-content"]/table[1]/tbody/tr/td/table[2]/tbody/tr[2]/td/table[2]/tbody/tr[2]/td[2]
                var Company = driver.FindElement(By.XPath("//*[@id=\"print-content\"]/table[1]/tbody/tr/td/table[2]/tbody/tr[2]/td/table[2]/tbody/tr[2]/td[2]"));
                Console.WriteLine("Company : " + Company.Text.ToString().Trim());
                //Console.WriteLine("Company: " + Company.Text);

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Company not found");

            }

        }

        public void PassengerName()
        {
            try
            {
                //*[@id="print-content"]/table[1]/tbody/tr/td/table[2]/tbody/tr[2]/td/table[1]/tbody/tr[1]/td[2]
                var PassengerName = driver.FindElement(By.XPath("//*[@id=\"print-content\"]/table[1]/tbody/tr/td/table[2]/tbody/tr[2]/td/table[1]/tbody/tr[1]/td[2]"));
                Console.WriteLine("Passenger Name : " + PassengerName.Text.ToString().Trim());
                //Console.WriteLine("Passenger Name: " + PassengerName.Text);

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Passenger Name not found");

            }

        }

        public void Server()
        {
            try
            {
                //*[@id="print-content"]/table[1]/tbody/tr/td/table[4]/tbody/tr[8]/td/text()[1]
                //*[@id="print-content"]/table[1]/tbody/tr/td/table[4]/tbody/tr[8]/td
                var ServPlat = driver.FindElement(By.XPath("//*[@id=\"print-content\"]/table[1]/tbody/tr/td/table[4]/tbody/tr[8]/td"));
                string strServPlat = ServPlat.Text.ToString();
                string serverTrim = strServPlat.Trim();

                //string Server = strServPlat.Remove(0, 9);
                //string Server1 = Server.Remove(9, 17);
                //string server2 = Server1.Trim();
                //+strServPlat.Remove(18,);
                //Console.WriteLine("Server name : " + server2);
                //Console.WriteLine(strServPlat);
                if (serverTrim.Contains("G3ASPRO01"))
                {
                    string serverName = "Server 1";
                    string serverName2 = "G3ASPRO01";
                    Console.WriteLine("Server : " + serverName + " - " + serverName2);
                }
                else if (serverTrim.Contains("G3ASPRO02"))
                {
                    string serverName = "Server 2";
                    string serverName2 = "G3ASPRO02";
                    Console.WriteLine("Server : " + serverName + " - " + serverName2);
                }
                else
                {
                    Console.WriteLine("Server name not found");
                }


            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Server Name not found");

            }

        }

        public void Platform()
        {
            try
            {
                var ServPlat = driver.FindElement(By.XPath("//*[@id=\"print-content\"]/table[1]/tbody/tr/td/table[4]/tbody/tr[8]/td"));
                string strServPlat = ServPlat.Text.ToString();
                string platTrim = strServPlat.Trim().ToLower();
                //string plat = strServPlat.Remove(0, 18);
                //string platform = plat.Trim();
                //Console.WriteLine("Platform : " + platform);
                // Console.WriteLine(platTrim);

                if (platTrim.Contains("mobile"))
                {
                    string platName = "Mobile Browser";
                    Console.WriteLine("Platform : " + platName);
                }
                else if (platTrim.Contains("desktop"))
                {
                    string platName = "Desktop Browser";
                    Console.WriteLine("Platform : " + platName);
                }
                else
                {
                    Console.WriteLine("Platform name not found");
                }

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Platform Name not found");

            }

        }

        public void CloseBrowser()
        {
            try
            {
                Thread.Sleep(2000);
                driver.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot close", e);

            }

        }
    }
}