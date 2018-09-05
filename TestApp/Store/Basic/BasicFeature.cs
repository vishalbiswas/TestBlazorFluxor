using Blazor.Fluxor;

namespace TestApp.Store.Basic
{
    public class BasicFeature : Feature<BasicState>
    {
        public override string GetName() => "Basic";

        protected override BasicState GetInitialState() => new BasicState(null);
    }
}
