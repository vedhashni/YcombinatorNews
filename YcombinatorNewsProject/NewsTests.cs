using NUnit.Framework;
using YcombinatorNewsProject.WebPageAction;

namespace YcombinatorNewsProject
{
    public class NewsTests:Base.BaseClass
    {
       [Test,Order(0)]
       public void HeadingWithPointsDisplayed()
        {
            HackerNewsPage page = new HackerNewsPage();
            page.DisplayTheHeadingsWithPoints();
        }

        [Test,Order(1)]
        public void HighestPointsDisplayed()
        {
            HackerNewsPage page1 = new HackerNewsPage();
            page1.NewsHavingHighestPoints();
        }
    }
}