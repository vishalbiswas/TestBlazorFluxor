using System.Collections.Generic;

namespace TestApp.Store.Basic
{
    public class BasicState
    {
        public BasicState(Dictionary<string, string> dict)
        {
            Dict = dict;
        }

        public Dictionary<string, string> Dict { get; set; }
    }
}
