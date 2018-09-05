using Blazor.Fluxor;
using System.Collections.Generic;

namespace TestApp.Store.Basic
{
    public class SetBasicAction : IAction
    {
        public Dictionary<string, string> Dict;

        public SetBasicAction(Dictionary<string, string> dict)
        {
            Dict = dict;
        }
    }
}
