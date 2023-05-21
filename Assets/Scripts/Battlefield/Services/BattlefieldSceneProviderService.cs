using Battlefield.Data;
using Submodules.Common.Gameplays.Services.Providers;

namespace Battlefield.Services
{
    public class BattlefieldSceneProviderService : AbstractSceneProviderService<BattlefieldGameplayStartData>
    {
        protected override string SceneName => "BattlefieldScene";
    }
}
