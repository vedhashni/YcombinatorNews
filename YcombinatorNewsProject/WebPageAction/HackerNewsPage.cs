using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace YcombinatorNewsProject.WebPageAction
{
    public class HackerNewsPage : Base.BaseClass
    {
        List<int> sorting = new List<int>();
        List<string> listofwords = new List<string>();

        //Used to Display the newsheadings
        public void DisplayNewsHeadings()
        {
            //Here we get headings from the page
            foreach (var headings in driver.FindElements(By.XPath("//*[@class='storylink']")))
            {
                string newsheadings = headings.Text;
                Console.WriteLine("NewsHeadings are {0}", newsheadings);
            }
        }

        //Used to get the points
        public void DisplayPointsOfNewsHeading()
        {
            foreach (var points in driver.FindElements(By.XPath("//*[@class='score']")))
            {
                string newsheadingpoints = points.Text;
                Console.WriteLine("Points are {0}", newsheadingpoints);
            }
        }

        //Used to display the headings with points
        public void DisplayTheHeadingsWithPoints()
        {

            IList<IWebElement> records = driver.FindElements(By.XPath("//span[@class='score']|//td[@class='title']"));
            foreach (var newspoints in records)
            {
                string headnewspoints = newspoints.Text;
                Console.WriteLine(headnewspoints);
            }
        }

        public void DisplayHighestPoints()
        {
            int i;
            foreach (var p in driver.FindElements(By.XPath("//*[@class='score']")))
            {
                string records = p.Text;
                //Here we split the integer and string values
                string[] numbers = Regex.Split(records, @"\D+");
                foreach (String value in numbers)
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        //Here we converting the string value into integer
                        i = int.Parse(value);
                        sorting.Add(i);
                        Console.WriteLine(i);
                    }
                }
            }
            HighestData();
        }

        public void HighestData()
        {
            //By using the orderbydescending method we sort the list in descending order
            //and take the firt value/highest value in the list
            var res = sorting.OrderByDescending(g => g).Take(1);
            foreach (var g in res)
            {
                Console.WriteLine("Highest value:{0}", g);
            }
        }

        public void MostOccuredWordInNewsHeading()
        {
            foreach (var news in driver.FindElements(By.XPath("//*[@class='storylink']")))
            {
                string newsheadingofpage = news.Text;
                //split the string of words according to the space
                listofwords = newsheadingofpage.Split(' ').ToList();
                foreach (var wordsofheadings in listofwords)
                {
                    Console.WriteLine(wordsofheadings);
                }
            }
            FrequentOccuredWord();
        }

        public void FrequentOccuredWord()
        {
            var mostoccuredword = listofwords.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).Where(x => x != null).First();
            int count = listofwords.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).Where(x => x != null).Count();
            Console.WriteLine("Highest value:{0} {1}", mostoccuredword, count);

        }
    }
}

