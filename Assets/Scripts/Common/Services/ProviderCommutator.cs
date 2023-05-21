using Battlefield.Services;
using MainMenu.Services;

namespace Common.Services
{
    public class ProviderCommutator
    {
        public BattlefieldSceneProviderService BattlefieldScene { get; } = new ();
        public MainMenuSceneProviderService MainMenuScene { get; } = new ();
    }
}
