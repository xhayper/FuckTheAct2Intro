using DiskCardGame;
using HarmonyLib;

namespace FuckTheAct2Intro
{
    [HarmonyPatch(typeof(MenuController), "LoadGameFromMenu")]
    public class DiskCardGame_MenuController_LoadGameFromMenu
    {
        [HarmonyPrefix]
        public static bool Prefix(bool newGameGBC)
        {
            if (newGameGBC)
            {
                SaveManager.SaveFile.ResetGBCSaveData();
                StoryEventsData.SetEventCompleted(StoryEvent.StartScreenNewGameUsed);
                SaveManager.SaveToFile();
            }
            else
            {
                SaveManager.LoadFromFile();
            }
            LoadingScreenManager.LoadScene(newGameGBC ? "GBC_Starting_Island" : SaveManager.SaveFile.currentScene);
            SaveManager.savingDisabled = false;
            return false;
        }
    }
}