﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Engine;
using SBAI;
using SBAIScripts;
using SBBase;
using SBGame;
using SBGamePlay;
using SBMiniGames;
using System;
using System.Collections;
using System.Collections.Generic;
using TCosReborn.Framework.Common;


namespace SBGame
{
    
    
    public class FSkill_EffectClass_AudioVisual_CameraShake : FSkill_EffectClass_AudioVisual_LocalView
    {
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="CameraShake")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public Vector MinVect;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="CameraShake")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public Vector MaxVect;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="CameraShake")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public float Duration;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="CameraShake")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public float TransitionTime;
        
        public FSkill_EffectClass_AudioVisual_CameraShake()
        {
        }
    }
}
/*
event DoShake(Game_Pawn Pawn) {
local Game_PlayerController PC;
if (IsClient() && Pawn != None && Pawn.Controller != None) {                
PC = Game_PlayerController(Pawn.Controller);                              
if (PC != None) {                                                         
PC.Camera.SetCameraShake(MinVect,MaxVect,Duration,TransitionTime);      
}
}
}
*/