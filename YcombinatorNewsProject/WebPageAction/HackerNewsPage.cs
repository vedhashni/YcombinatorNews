
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace YcombinatorNewsProject.WebPageAction
{
    public class HackerNewsPage:Base.BaseClass
    {
        public static string pointsofnews;

        public void NewsHavingHighestPoints()
        {
            int[] array;
            //ArrayList authorsArray = new ArrayList();
            //int[] array1;
            foreach (var newspoints in driver.FindElements(By.ClassName("score")))
            {
                array = new int[29];
                array[0] = int.Parse(Regex.Replace(newspoints.Text, "[^0-9]+", string.Empty));
                Console.WriteLine(array[0]);
                   
            }
        }

        public void MostOccuredWordInNews()
        {
            IWebElement element = driver.FindElement(By.Id("28621288"));
                string newsheadings = element.Text;
                string[] a = newsheadings.Split(' ');
                int count = 0;
                for (int i = 0; i < a.Length;)
                {
                    if (a[i].Equals(a[i+1]))
                    {
                        count++;
                    }
                    if (count > 1)
                    {
                        Console.WriteLine(a[i]);
                    }
                }
                Console.WriteLine("News is:" + newsheadings);
            
        }

        public void DisplayTheHeadingsWithPoints()
        {
            IList<IWebElement> records = driver.FindElements(By.XPath("//span[@class='score']|//td[@class='title']"));
            foreach(var newspoints in records)
            {
                string headnewspoints = newspoints.Text;
                Console.WriteLine(headnewspoints);
            }
        }
    }
}
