using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace MessageK
{
    /// <summary>The mod entry point.</summary>
    public class ModEntry : Mod
    {
        /*********
        ** Public methods
        *********/
        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {
            helper.Events.Input.ButtonPressed += this.OnButtonPressed;
        }


        /*********
        ** Private methods
        *********/
        /// <summary>Raised after the player presses a button on the keyboard, controller, or mouse.</summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event data.</param>
        private void OnButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            //this.Monitor.Log($"testing to see if this works", LogLevel.Debug);

            SButtonState state = this.Helper.Input.GetState(SButton.K);
            bool isDown = (state == SButtonState.Pressed || state == SButtonState.Held);
            //String isDownStr = isDown ? "down" : "not down";

            //this.Monitor.Log($"{isDownStr}", LogLevel.Debug);

            if (isDown == true) {
                this.Monitor.Log($"the {e.Button} key is down.", LogLevel.Debug);
            }
            else {
                return;
            }

            // ignore if player hasn't loaded a save yet
            //if (!Context.IsWorldReady)
            //  return;

            // print button presses to the console window
            //this.Monitor.Log($"{Game1.player.Name} pressed {e.Button}.", LogLevel.Debug);
        }
    }
} 