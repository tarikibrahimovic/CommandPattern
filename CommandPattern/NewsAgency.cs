public class NewsAgency
{
    private List<Article> _articles;

    public NewsAgency()
    {
        _articles = new List<Article>();
    }

    public void PostArticle(Article article)
    {
        _articles.Add(article);
        Console.WriteLine($"Reporter {article.Reporter} has posted an article: {article.Title}");
    }

    public void PurchaseArticle(Article article)
    {
        if (_articles.Contains(article))
        {
            _articles.Remove(article);
            Console.WriteLine($"News agency has purchased an article: {article.Title} from reporter {article.Reporter}");
            // Notify reporter that the article has been purchased
            // Remove article from the list
        }
        else
        {
            Console.WriteLine($"Article: {article.Title} not found");
        }
    }

    public List<Article> FilterArticles(DateTime fromDate, DateTime toDate, string category, List<string> reporters)
    {
        return _articles.Where(a => a.Date >= fromDate && a.Date <= toDate && a.Category == category && reporters.Contains(a.Reporter)).ToList();
    }
}
