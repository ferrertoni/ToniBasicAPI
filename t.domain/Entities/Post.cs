namespace t.domain.Entities
{
    public class Post
    {
        public int PostID { get; private set; }
        public string Text { get; private set; }
        public int UserID { get; private set; }
        public int TopicID { get; private set; }


        private Post(int postID, string text, int userID, int topicID)
        {
            PostID = postID;
            Text = text;
            UserID = userID;
            TopicID = topicID;
        }

        public static Post Create(int postID, string text, int userID, int topicID)
        {
            Post post = new Post(postID, text, userID, topicID);
            return post;
        }
    }
}
