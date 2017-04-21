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
    
    
    public class Conversation_Response : Content_Type
    {
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Text")]
        public LocalizedString Text;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Results")]
        public List<Conversation_Node> Conversations = new List<Conversation_Node>();
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Requirements")]
        public List<Content_Requirement> Requirements = new List<Content_Requirement>();
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Events")]
        public List<Content_Event> Events = new List<Content_Event>();
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Text")]
        public int ButtonImage;
        
        public Conversation_Response()
        {
        }
    }
}
/*
function Conversation_Node sv_SelectConversation(export editinline Conversation_Topic aTopic,Game_Pawn aSpeaker,Game_Pawn aPartner) {
local export editinline Conversation_Node Node;
local int convI;
convI = 0;                                                                  
while (convI < Conversations.Length) {                                      
Node = Conversations[convI];                                              
if (Node.CheckNode(aTopic,aSpeaker,aPartner)) {                           
return Node;                                                            
}
convI++;                                                                  
}
return None;                                                                
}
event bool sv_OnResponse(Game_Pawn aSpeaker,Game_Pawn aPartner) {
local int eventI;
eventI = 0;                                                                 
while (eventI < Events.Length) {                                            
if (Events[eventI] != None
&& !Events[eventI].sv_CanExecute(aSpeaker,aPartner)) {
return False;                                                           
}
eventI++;                                                                 
}
eventI = 0;                                                                 
while (eventI < Events.Length) {                                            
Events[eventI].sv_Execute(aSpeaker,aPartner);                             
eventI++;                                                                 
}
return True;                                                                
}
function string GetText() {
if (Len(Text.Text) > 0) {                                                   
return Text.Text;                                                         
} else {                                                                    
return "Empty Response";                                                  
}
}
event bool sv_Check(export editinline Conversation_Topic aTopic,Game_Pawn aSpeaker,Game_Pawn aPartner) {
local int reqI;
reqI = 0;                                                                   
while (reqI < Requirements.Length) {                                        
if (Requirements[reqI] != None
&& !Requirements[reqI].CheckPawn(aSpeaker)) {
return False;                                                           
}
reqI++;                                                                   
}
return True;                                                                
}
*/