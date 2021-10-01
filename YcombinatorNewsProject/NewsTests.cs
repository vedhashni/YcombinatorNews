/*summary :Automation on YcombinatorNews
  Author: Vedhashni V
  Date  : 23-09-21
*/

using NUnit.Framework;
using YcombinatorNewsProject.WebPageAction;

namespace YcombinatorNewsProject
{
    public class NewsTests:Base.BaseClass
    {
        HackerNewsPage page = new HackerNewsPage();
        [Test, Order(0)]
        public void HeadingWithPointsDisplayed()
        {

            page.DisplayTheHeadingsWithPoints();
        }

        [Test, Order(1)]
        public void DisplayNewsHeadingsOfThePage()
        {
            page.DisplayNewsHeadings();
        }

        [Test, Order(2)]
        public void DisplayPoints()
        {
            page.DisplayPointsOfNewsHeading();
        }

        [Test, Order(3)]
        public void HighestPointOfNews()
        {
            page.DisplayHighestPoints();
        }

        [Test, Order(4)]
        public void MostOccuredWord()
        {
            page.MostOccuredWordInNewsHeading();
        }
    }
}