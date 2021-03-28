using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;
namespace LobbyOptionsAPI
{
    [BepInPlugin(Id,"","")]
    public class LobbyOptionsAPI : BasePlugin
    {
        public const string Id = "com.herysia.LobbyOptionsAPI";
        public Harmony Harmony { get; } = new Harmony(Id);

        public override void Load()
        {
            Harmony.PatchAll();
        }
    }
}