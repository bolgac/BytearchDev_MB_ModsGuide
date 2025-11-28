using System;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using TaleWorlds.Library;
using TaleWorlds.CampaignSystem;

namespace MyFirstMod
{
    // Main entry point of the mod. Inherits from MBSubModuleBase.
    public class MyFirstModSubModule : MBSubModuleBase
    {
        // The mod runs when installed. It displays the startup message.
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();

            try
            {
                // Shows a green message to the player.
                InformationManager.DisplayMessage(new InformationMessage(
                    "My First Mod successfully installed!",
                    Colors.Green));

            }
            catch (Exception ex)
            {
                // If an exception occurs, it writes an error message to the message console.
                InformationManager.DisplayMessage(new InformationMessage(
                    "MyFirstMod installation error: " + ex.Message,
                    Colors.Green));

            }
        }

        // Runs when the game starts. Adds custom mechanics when campaign is initialized.
        protected override void OnGameStart(Game game, IGameStarter gameStarter)
        {
            base.OnGameStart(game, gameStarter);

            if (gameStarter is CampaignGameStarter campaignStarter)
            {
                // Loads custom mechanics when campaign starts.
                AddCustomGameMechanics(campaignStarter);
            }
        }

        // Method used to add custom game mechanics.
        private void AddCustomGameMechanics(CampaignGameStarter campaignStarter)
        {
            // Models will be added here in the future.
            Debug.Print("MyFirstMod: Custom game mechanics yüklendi");
        }

        // Called when a battle starts. Adds CustomBattleObserver behavior.
        public override void OnMissionBehaviorInitialize(Mission mission)
        {
            base.OnMissionBehaviorInitialize(mission);

            // Adds CustomBattleObserver to listen for battle events.
            mission.AddMissionBehavior(new CustomBattleObserver());
        }
    }
}