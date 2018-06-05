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

namespace Engine
{
    
    
    [System.Serializable] public class TimedEnvironmentEffect : EnvironmentEffect
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("Preview")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public float PreviewSpeed;
        
        [Sirenix.OdinInspector.FoldoutGroup("Preview")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public byte PreviewProgress;
        
        public float PreviewRelative;
        
        [Sirenix.OdinInspector.FoldoutGroup("Preview")]
        public float UpdateSpeed;
        
        public float UpdateTimer;
        
        [Sirenix.OdinInspector.FoldoutGroup("Events")]
        public List<EventRange> Events = new List<EventRange>();
        
        public float mDefaultTime;
        
        public TimedEnvironmentEffect()
        {
        }
        
        [System.Serializable] public struct EventRange
        {
            
            public NameProperty Event;
            
            public NameProperty InRangeEvent;
            
            public NameProperty OutOfRangeEvent;
            
            public float RangeBeginTime;
            
            public float RangeEndTime;
            
            public int WasInRange;
        }
    }
}