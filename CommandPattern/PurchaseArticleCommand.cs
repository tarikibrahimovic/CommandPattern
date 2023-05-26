public class PurchaseArticleCommand : ICommand
{
    private NewsAgency _newsAgency;
    private Article _article;

    public PurchaseArticleCommand(NewsAgency newsAgency, Article article)
    {
        _newsAgency = newsAgency;
        _article = article;
    }

    public void Execute()
    {
        _newsAgency.PurchaseArticle(_article);
    }
}
