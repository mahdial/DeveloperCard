using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.ViewComponents
{
    public class LatestArticleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var article = new List<Article>
            {
                new Article(1, " article 1", "jaskdfjkasdhfjkasdfa asdkjfa sdfkjasd f"),
                new Article(1, " article 2", "jaskdfjkasdhfjkasdfa asdkjfa sdfkjasd f"),
                new Article(1, " article 3", "jaskdfjkasdhfjkasdfa asdkjfa sdfkjasd f"),
                new Article(1, " article 4", "jaskdfjkasdhfjkasdfa asdkjfa sdfkjasd f"),
                new Article(1, " article 5", "jaskdfjkasdhfjkasdfa asdkjfa sdfkjasd f"),
                new Article(1, " article 6", "jaskdfjkasdhfjkasdfa asdkjfa sdfkjasd f"),
            };

            return View("_LArticle", article);
        }
    }
}
