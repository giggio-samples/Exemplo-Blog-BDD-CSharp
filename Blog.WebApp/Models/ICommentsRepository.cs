namespace Blog.WebApp.Models
{
    public interface ICommentsRepository
    {
        void Save(Comment comment);
    }
}