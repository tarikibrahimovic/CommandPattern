public class PostArticleCommand : ICommand
{
    private NewsAgency _newsAgency;
    private Article _article;

    public PostArticleCommand(NewsAgency newsAgency, Article article)
    {
        _newsAgency = newsAgency;
        _article = article;
    }

    public void Execute()
    {
        _newsAgency.PostArticle(_article);
    }
}
