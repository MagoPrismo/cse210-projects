public class Video
{
    private string _author;
    private string _title;
    private float _length;
    private List<Comment> _comments = new List<Comment>();
    private int _numbComment = 0;

    public Video(string author, string title, float length)
    {
        _author = author;
        _title = title;
        _length = length;
    }

    public void SetComment(List<Comment> comments)
    {
        _comments = comments;
        _numbComment = _comments.Count;
    }

    public int CountComments()
    {
        return _numbComment;
    }

    public void DisplayAll()
    {
        Console.WriteLine($"\nVideo: {_title}, Author: {_author}, Length: {_length}s, and number of comments: {_numbComment}\n");
        foreach (var item in _comments) {
            Console.WriteLine(item.GetNameText());
        }

    }

}