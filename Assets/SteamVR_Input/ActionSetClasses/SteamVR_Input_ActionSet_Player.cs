//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Valve.VR
{
    using System;
    using UnityEngine;
    
    
    public class SteamVR_Input_ActionSet_Player : Valve.VR.SteamVR_ActionSet
    {
        
        public virtual SteamVR_Action_Vector2 Walk
        {
            get
            {
                return SteamVR_Actions.player_Walk;
            }
        }
        
        public virtual SteamVR_Action_Boolean ShootX
        {
            get
            {
                return SteamVR_Actions.player_ShootX;
            }
        }
        
        public virtual SteamVR_Action_Boolean ShootY
        {
            get
            {
                return SteamVR_Actions.player_ShootY;
            }
        }
        
        public virtual SteamVR_Action_Vibration Haptic
        {
            get
            {
                return SteamVR_Actions.player_Haptic;
            }
        }
    }
}
