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

namespace SBGamePlay
{
    
    
    [System.Serializable] public class SBAudioDamper : SBAudio_Base
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("Damping")]
        public float DampFactor;
        
        [Sirenix.OdinInspector.FoldoutGroup("Damping")]
        public float TimeToDamp;
        
        [Sirenix.OdinInspector.FoldoutGroup("Damping")]
        public List<AudioTypeDamper> AudioTypes = new List<AudioTypeDamper>();
        
        [Sirenix.OdinInspector.FoldoutGroup("Damping")]
        public List<AudioNameDamper> ActorName = new List<AudioNameDamper>();
        
        [Sirenix.OdinInspector.FoldoutGroup("Damping")]
        public List<ExemptActors> Exemptions = new List<ExemptActors>();
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public bool bIsDamping;
        
        public SBAudioDamper()
        {
        }
        
        [System.Serializable] public struct ExemptActors
        {
            
            public NameProperty ActorTagName;
        }
        
        [System.Serializable] public struct DamperInfo
        {
            
            public bool Initialized;
            
            public int FaderID;
        }
        
        [System.Serializable] public struct AudioTypeDamper
        {
            
            public byte AudioType;
            
            public DamperInfo Info;
        }
        
        [System.Serializable] public struct AudioNameDamper
        {
            
            public NameProperty ActorTagName;
            
            public DamperInfo Info;
        }
    }
}