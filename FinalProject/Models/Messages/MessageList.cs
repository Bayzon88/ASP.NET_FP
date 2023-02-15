namespace FinalProject.Models.Messages
{
    public class MessageList
    {
        public List<Message> Messages = new List<Message>();
        private MessageList() { }

        private static MessageList _instance; 

        public static MessageList GetInstance()
        {
            if(_instance == null)
            {
                _instance = new MessageList();
            }
            return _instance;
        }
        public void AddMessageToList(Message message)
        {
            //Add a message to the message List
            Messages.Add(message);
        }
        public void RemoveMessageFromList(int noteID)
        {
            //Find Message in List, assign to temporary object and remove from List
            Message tempMessage = new Message();
            Messages.ForEach(message =>
            {
                if (message.NoteID == noteID)
                {
                    tempMessage = message;
                }
            });

            Messages.Remove(tempMessage);
        }
        public List<Message> GetMessageList()
        {
            return Messages;
        }

    }
}
