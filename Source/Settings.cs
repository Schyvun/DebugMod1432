using System.Collections.Generic;
using Modding;

namespace DebugMod
{
    
    //Empty class required for DebugMod class definition
    public class SaveSettings : IModSettings { }
    public class GlobalSettings: IModSettings
    {
        //Save members
        public Dictionary<string, int> binds = new Dictionary<string, int>();

        public bool ConsoleVisible = true;

        public bool EnemiesPanelVisible = true;

        public bool HelpPanelVisible = true;

        public bool InfoPanelVisible = true;

        public bool MinInfoPanelVisible = true;

        public bool SaveStatePanelVisible = true;
        
        public bool TopMenuVisible = true;

        public bool FirstRun = true;

        public bool NumPadForSaveStates = false;
        
        public int ShowHitBoxes;

        public int MaxSaveStates = 6;

        public float AmountToMove = 0.1f;
    }
}
