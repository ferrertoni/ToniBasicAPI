namespace t.domain.Entities
{
    public class Topic
    {
        public int TopicID { get; private set; }
        public string Name { get; private set; }

        private Topic(int topicID, string name)
        {
            TopicID = topicID;
            Name = name;
        }


        public static Topic Create(int topicID, string name)
        {
            Topic topic = new Topic(topicID, name);
            return topic;
        }
    }
}
