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


namespace Engine
{
    
    
    public class DecorationList : Keypoint
    {
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="List")]
        public List<DecorationType> Decorations = new List<DecorationType>();
        
        public DecorationList()
        {
        }
        
        public struct DecorationType
        {
            
            public StaticMesh StaticMesh;
            
            public Range Count;
            
            public Range DrawScale;
            
            public int bAlign;
            
            public int bRandomPitch;
            
            public int bRandomYaw;
            
            public int bRandomRoll;
        }
    }
}