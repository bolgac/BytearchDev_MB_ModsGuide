using System;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;

namespace MyFirstMod
{
    // Inherits from MissionLogic. Listens to battle events.
    public class CustomBattleObserver : MissionLogic
    {
        // Automatically called when an agent takes damage.
        public override void OnAgentHit(
            Agent affectedAgent,                 // Agent receiving damage (player/NPC)
            Agent affectorAgent,                 // Agent dealing damage
            in MissionWeapon affectorWeapon,     // Weapon used
            in Blow blow,                        // Damage info
            in AttackCollisionData attackCollisionData) // Collision data
        {
            try
            {
                // Only shows damage between human agents.
                if (affectedAgent?.IsHuman == true && affectorAgent?.IsHuman == true)
                {
                    // Gets damage amount from Blow.
                    int damage = blow.InflictedDamage;

                    // Creates damage message.
                    string message = $"{affectorAgent.Name} → {affectedAgent.Name}: {damage} damage";

                    // Displays message in yellow color on screen.
                    InformationManager.DisplayMessage(new InformationMessage(
                        message,
                        Colors.Yellow));
                }
            }
            catch (Exception ex)
            {
                // Writes error message to debug console if an exception occurs.
                Debug.Print("CustomBattleObserver error: " + ex.Message);
            }

            // Must call base class method.
            base.OnAgentHit(affectedAgent, affectorAgent, affectorWeapon, blow, attackCollisionData);
        }
    }
}
