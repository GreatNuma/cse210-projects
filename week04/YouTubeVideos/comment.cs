namespace YouTubeVideos
{
    // The Comment class tracks the name of the person and their comment text
    public class Comment
    {
        private string _commenterName;
        private string _text;

        public Comment(string commenterName, string text)
        {
            _commenterName = commenterName;
            _text = text;
        }

        public string GetCommenterName()
        {
            return _commenterName;
        }

        public string GetText()
        {
            return _text;
        }
    }
}