﻿using System;
using System.Collections.Generic;
using Engine;
using UnityEngine;

namespace SBGame
{
    [Serializable] public class Appearance_Set : UObject
    {
        public List<string> HeadSet = new List<string>();

        [NonSerialized, HideInInspector]
        [ArraySizeForExtraction(Size = 5)]
        public string[] BodyPalette = new string[0];

        public List<Appearance_Base> ChestClothesSet = new List<Appearance_Base>();

        public List<Appearance_Base> LeftGloveSet = new List<Appearance_Base>();

        public List<Appearance_Base> RightGloveSet = new List<Appearance_Base>();

        public List<Appearance_Base> PantsSet = new List<Appearance_Base>();

        public List<Appearance_Base> ShoesSet = new List<Appearance_Base>();

        public List<Appearance_Base> HeadGearSet = new List<Appearance_Base>();

        public List<Appearance_Base> LeftShoulderSet = new List<Appearance_Base>();

        public List<Appearance_Base> RightShoulderSet = new List<Appearance_Base>();

        public List<Appearance_Base> LeftGauntletSet = new List<Appearance_Base>();

        public List<Appearance_Base> RightGauntletSet = new List<Appearance_Base>();

        public List<Appearance_Base> ChestSet = new List<Appearance_Base>();

        public List<Appearance_Base> BeltSet = new List<Appearance_Base>();

        public List<Appearance_Base> LeftThighSet = new List<Appearance_Base>();

        public List<Appearance_Base> RightThighSet = new List<Appearance_Base>();

        public List<Appearance_Base> LeftShinSet = new List<Appearance_Base>();

        public List<Appearance_Base> RightShinSet = new List<Appearance_Base>();

        public List<Appearance_Base> MainWeaponSet = new List<Appearance_Base>();

        public List<Appearance_Base> OffhandWeaponSet = new List<Appearance_Base>();

        public List<Appearance_Base> MainSheathSet = new List<Appearance_Base>();

        public List<Appearance_Base> OffhandSheathSet = new List<Appearance_Base>();

        public List<Appearance_Base> HairSet = new List<Appearance_Base>();

        public List<Appearance_Tattoo> PCTattooSet = new List<Appearance_Tattoo>();

        public List<Appearance_Tattoo> ClassTattooSet = new List<Appearance_Tattoo>();

        private bool mInitialized;

        public Appearance_Set()
        {
        }
    }
}
/*
native function UnloadResources();
private function SheathArray(array<Appearance_Base> orgArray,out array<Appearance_Base> OutArray) {
local int i;
local int aI;
i = 0;                                                                      
while (i < orgArray.Length) {                                               
if (orgArray[i] != None) {                                                
OutArray[i] = Appearance_Base(orgArray[i].Clone(True));                 
if (orgArray[i].Part == 16) {                                           
OutArray[i].Part = 19;                                                
} else {                                                                
if (orgArray[i].Part == 17) {                                         
OutArray[i].Part = 20;                                              
goto jl00C1;                                                        
}
}
aI = 0;                                                                 
while (aI < orgArray[i].Attachments.Length) {                           
if (orgArray[i].Attachments[aI].SocketId == Class'Appearance_Base'.6) {
OutArray[i].Attachments[aI].SocketId = Class'Appearance_Base'.15;   
OutArray[i].Attachments[aI].Covers = 16;                            
} else {                                                              
if (orgArray[i].Attachments[aI].SocketId == Class'Appearance_Base'.5) {
OutArray[i].Attachments[aI].SocketId = Class'Appearance_Base'.16; 
OutArray[i].Attachments[aI].Covers = 16;                          
goto jl026D;                                                      
}
if (orgArray[i].Attachments[aI].SocketId == Class'Appearance_Base'.17) {
OutArray[i].Attachments[aI].SocketId = Class'Appearance_Base'.18; 
OutArray[i].Attachments[aI].Covers = 16;                          
}
}
aI++;                                                                 
}
break;                                                                  
}
OutArray[i] = None;                                                       
++i;                                                                      
}
}
private function InitArray(out array<Appearance_Base> OutArray) {
local int i;
i = 0;                                                                      
while (i < OutArray.Length) {                                               
if (OutArray[i] != None) {                                                
OutArray[i]._AS_Index = i;                                              
OutArray[i]._AS_Set = True;                                             
}
++i;                                                                      
}
}
event OnInit() {
if (mInitialized) {                                                         
return;                                                                   
}
mInitialized = True;                                                        
InitArray(ChestClothesSet);                                                 
InitArray(LeftGloveSet);                                                    
InitArray(RightGloveSet);                                                   
InitArray(PantsSet);                                                        
InitArray(ShoesSet);                                                        
InitArray(HeadGearSet);                                                     
InitArray(LeftShoulderSet);                                                 
InitArray(RightShoulderSet);                                                
InitArray(LeftGauntletSet);                                                 
InitArray(RightGauntletSet);                                                
InitArray(ChestSet);                                                        
InitArray(BeltSet);                                                         
InitArray(LeftThighSet);                                                    
InitArray(RightThighSet);                                                   
InitArray(LeftShinSet);                                                     
InitArray(RightShinSet);                                                    
InitArray(MainWeaponSet);                                                   
InitArray(OffhandWeaponSet);                                                
if (!IsEditor()) {                                                          
SheathArray(MainWeaponSet,MainSheathSet);                                 
SheathArray(OffhandWeaponSet,OffhandSheathSet);                           
}
InitArray(HairSet);                                                         
}
*/