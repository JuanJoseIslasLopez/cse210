public class Video {
    public string Title;
    public string Author; 
    public int Length; 
    public List<Comment> Comments; 

    public Video(string title, string author, int length) {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(string commenter, string text) {
        Comments.Add(new Comment(commenter, text));
    }

    public string GetInfo()
    {
        string commentsStr = "";
        foreach (Comment comment in Comments)
        {
            commentsStr += $"{comment.Commenter}: {comment.Text}\n";
        }
        return $"Title: {Title}\nAuthor: {Author}\nLength: {Length} seconds\nComments:\n{commentsStr}";
    }
}
