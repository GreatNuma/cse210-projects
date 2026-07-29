using System.Collections.Generic;

namespace YouTubeVideos
{
    // The Video class manages video metadata and encapsulates a list of Comments
    public class Video
    {
        private string _title;
        private string _author;
        private int _lengthInSeconds;
        private List<Comment> _comments;

        public Video(string title, string author, int lengthInSeconds)
        {
            _title = title;
            _author = author;
            _lengthInSeconds = lengthInSeconds;
            _comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        // Required method: Returns the total count of comments for this video
        public int GetCommentCount()
        {
            return _comments.Count;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public int GetLengthInSeconds()
        {
            return _lengthInSeconds;
        }

        public List<Comment> GetComments()
        {
            return _comments;
        }
    }
}