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
    
    
    [System.Serializable] public class MaterialTrigger : Triggers
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("MaterialTrigger")]
        public List<Material> MaterialsToTrigger = new List<Material>();
        
        public MaterialTrigger()
        {
        }
    }
}
/*
function Trigger(Actor Other,Pawn EventInstigator) {
local int i;
if (Other == None) {                                                        
Other = self;                                                             
}
i = 0;                                                                      
while (i < MaterialsToTrigger.Length) {                                     
if (MaterialsToTrigger[i] != None) {                                      
MaterialsToTrigger[i].Trigger(Other,EventInstigator);                   
}
i++;                                                                      
}
}
function PostBeginPlay() {
local int i;
i = 0;                                                                      
while (i < MaterialsToTrigger.Length) {                                     
if (MaterialsToTrigger[i] != None) {                                      
MaterialsToTrigger[i].Reset();                                          
}
i++;                                                                      
}
}
*/