using System.Collections.Generic;

namespace Core.Common
{
    public class OperationResult
    {
        public bool Success { get; set; }
        public List<string> MessageList { get; set; }

        public OperationResult()
        {
            MessageList = new List<string>();
            Success = true;
        }

        public void AddMessage(string message)
        {
            MessageList.Add(message);
        }
    }
}
