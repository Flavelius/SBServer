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
    
    
    public class FSkill_Event_Duff_CondEv : UObject
    {
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="CondEv")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public FSkill_Event Event;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="CondEv")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public int Uses;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="CondEv")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public int MaximumTriggersPerUse;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="CondEv")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public float Interval;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="CondEv")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public float Delay;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="CondEv")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public float IncreasePerUse;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="CondEv")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public byte Condition;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="CondEv")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public byte AttackType;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="CondEv")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public byte MagicType;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="CondEv")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public byte EffectType;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="CondEv")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public byte Target;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public bool Running;
        
        public FSkill_Event_Duff_CondEv()
        {
        }
    }
}