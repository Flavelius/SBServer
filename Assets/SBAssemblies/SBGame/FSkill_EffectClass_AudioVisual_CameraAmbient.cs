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
using Framework.Attributes;

namespace SBGame
{
    
    
    [System.Serializable] public class FSkill_EffectClass_AudioVisual_CameraAmbient : FSkill_EffectClass_AudioVisual_Camera
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("CameraAmbient")]
        [FieldConst()]
        public float AmbientAmount;
        
        [Sirenix.OdinInspector.FoldoutGroup("CameraAmbient")]
        [FieldConst()]
        public byte AmbientBrightness;
        
        [Sirenix.OdinInspector.FoldoutGroup("CameraAmbient")]
        [FieldConst()]
        public byte AmbientHue;
        
        [Sirenix.OdinInspector.FoldoutGroup("CameraAmbient")]
        [FieldConst()]
        public byte AmbientSaturation;
        
        public FSkill_EffectClass_AudioVisual_CameraAmbient()
        {
        }
    }
}