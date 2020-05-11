using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace insta
{
    class Program
    {
        static void Main(string[] args)
        {

            ChromeOptions options = new ChromeOptions();

            // gizli sekmede açıyorum.
            options.AddArgument("--incognito");

            // buraya indireceğiniz chrome driver'ın path'ini tanımlayabilirsiniz.
            IWebDriver driver = new ChromeDriver(@"/users/deremakif/Downloads/", options);


            Console.WriteLine("Login, ve hedef takipçilerin olduğu pencereyi açmak için gereken süre: 100 sn");
            driver.Navigate().GoToUrl("https://www.instagram.com");

            // Login, ve hedef takipçilerin olduğu pencereyi açmak için gereken süre.
            System.Threading.Thread.Sleep(100000);

            for (int i = 1; i < 500; i++)
            {

                for (int j = 1; j < 101; j++)
                {

                    try
                    {
                        // takip et butonu - class sürekli değişebilir. sizde görüneni yazarsınız. 
                        driver.FindElement(By.XPath("//*[@class='sqdOP  L3NKy   y3zKF     ']")).Click();

                        // bunun süresini arttırırsınız. saatlik sınırı falan var çünkü.
                        //onları unuttum ama günde 7000 kişiye falan izin veriyordu.
                        // 1000 = 1 saniye
                        System.Threading.Thread.Sleep(1000);
                                               
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("bir hata var: " + j);
                    }

                    System.Threading.Thread.Sleep(1000);

                }

            }
        
    }
    }
}
