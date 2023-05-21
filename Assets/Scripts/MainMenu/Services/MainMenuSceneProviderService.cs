using MainMenu.Data;
using Submodules.Common.Gameplays.Services.Providers;

namespace MainMenu.Services
{
    public class MainMenuSceneProviderService : AbstractSceneProviderService<MainMenuSceneStartData>
    {
        protected override string SceneName => "MainMenu";
    }
}
