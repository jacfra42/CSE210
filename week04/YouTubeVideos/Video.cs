public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public int NumofComms()
    {
        return _comments.Count();
    }
    private string ShowComments()
    {
        string allComments = "";
        foreach (Comment comment in _comments)
        {
            allComments += comment.GetDisplayText() + "\n";
        }
        return allComments;
    }
    public string GetDisplayText()
    {
        return $"{_title} | {_author} | {_length}s | {NumofComms()} comments\n\n{ShowComments()}";
    }
}