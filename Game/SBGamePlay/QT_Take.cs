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


namespace SBGamePlay
{
    
    
    public class QT_Take : Quest_Target
    {
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Take")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public Content_Inventory Cargo;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Take")]
        public NameProperty SourceTag;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Take")]
        public LocalizedString SourceDescription;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Take")]
        public byte Option;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Take")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public int Amount;
        
        public QT_Take()
        {
        }
    }
}
/*
event string GetActiveText(Game_ActiveTextItem aItem) {
if (aItem.Tag == "T") {                                                     
return SourceDescription.Text;                                            
} else {                                                                    
if (aItem.Tag == "O") {                                                   
return Cargo.GetActiveText(aItem.SubItem);                              
} else {                                                                  
if (aItem.Tag == "Q") {                                                 
return "" @ string(Amount);                                           
} else {                                                                
return Super.GetActiveText(aItem);                                    
}
}
}
}
protected function AppendProgressText(out string aDescription,int aProgress) {
if (Amount > 1) {                                                           
}
}
protected function string GetDefaultDescription() {
return Class'StringReferences'.default.QT_TakeText.Text;                    
}
event RadialMenuCollect(Game_Pawn aPlayerPawn,Object aObject,byte aMainOption,out array<byte> aSubOptions) {
local Actor act;
act = Actor(aObject);                                                       
if (act != None && act.Tag == SourceTag) {                                  
aSubOptions[aSubOptions.Length] = Option;                                 
}
}
*/