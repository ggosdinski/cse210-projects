public class Video {
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int length) {
        _title = title;
        _author = author;
        _length = length;
    }
    public void Comment(string username, string comment) {
        Comment newComment = new Comment(username, comment);
        _comments.Add(newComment);
    }
    public void Print() {
        string fmt = "00";
        string seconds;
        int remainingSeconds = _length % 60;
        seconds = remainingSeconds.ToString(fmt);
        Console.WriteLine($"{_title} | {_author} -- {_length / 60}:{seconds}"); 
        foreach(Comment comment in _comments) {
            comment.Print();
        }
    }
}