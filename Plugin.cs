using BepInEx;
using HarmonyLib;

#pragma warning disable 169

namespace FuckTheAct2Intro
{

    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string PluginGuid = "io.github.xhayper.fucktheact2intro";
        private const string PluginName = "FuckTheAct2Intro";
        private const string PluginVersion = "1.0.0.0";

        private void Awake()
        {
            Harmony harmony = new Harmony(PluginGuid);
            harmony.PatchAll();
        }
    }
}