NewsAgency newsAgency = new NewsAgency();

Article article1 = new Article
{
    Title = "Sports News",
    Content = "Some sports news content",
    Date = DateTime.Now,
    Category = "Sports",
    Reporter = "John"
};

Article article2 = new Article
{
    Title = "Politics News",
    Content = "Some politics news content",
    Date = DateTime.Now.AddDays(-1),
    Category = "Politics",
    Reporter = "Jane"
};

// Post articles
PostArticleCommand postArticle1Command = new PostArticleCommand(newsAgency, article1);
postArticle1Command.Execute();

PostArticleCommand postArticle2Command = new PostArticleCommand(newsAgency, article2);
postArticle2Command.Execute();

// Filter articles
var filteredArticles = newsAgency.FilterArticles(DateTime.Now.AddDays(-7), DateTime.Now, "Sports", new List<string> { "John", "Jane" });
Console.WriteLine($"Filtered articles: {filteredArticles.Count}");

// Purchase article
PurchaseArticleCommand purchaseArticle1Command = new PurchaseArticleCommand(newsAgency, article1);
purchaseArticle1Command.Execute();