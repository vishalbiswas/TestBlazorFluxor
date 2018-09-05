using Blazor.Fluxor;
using System;

namespace TestApp.Store.Basic
{
    public class SetBasicReducer : Reducer<BasicState, SetBasicAction>
    {
        public override BasicState Reduce(BasicState state, SetBasicAction action)
        {
            Console.WriteLine("in reducer");
            return new BasicState(action.Dict);
        }
    }
}
