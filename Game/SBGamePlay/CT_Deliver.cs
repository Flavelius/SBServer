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
    
    
    public class CT_Deliver : CT_Target
    {
        
        public CT_Deliver()
        {
        }
    }
}
/*
event bool sv_OnFinish(Game_Pawn aSpeaker,Game_Pawn aPartner) {
local export editinline Quest_Type quest;
local export editinline QT_Deliver Target;
Target = QT_Deliver(Outer);                                                 
quest = Quest_Type(Target.Outer);                                           
if (Game_PlayerPawn(aPartner).questLog.sv_SetTargetAsCompleted(Target,aSpeaker)) {
return Super.sv_OnFinish(aSpeaker,aPartner);                              
} else {                                                                    
return False;                                                             
}
}
*/