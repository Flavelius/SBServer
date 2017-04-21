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


namespace SBBase
{
    
    
    public class Base_GameInfo : GameInfo
    {
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        private int d_relevance_object_vtbl;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        private int d_relevance_object_mRelevanceObjectID;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        private int d_relevance_object_mpRelevance;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        private int d_relevance_object_mpMatineeObject;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        private int d_relevance_object_mBlockIndexX;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        private int d_relevance_object_mBlockIndexY;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        private int d_relevance_object_mVisibilityLevel;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        private int d_relevance_object_mbVisible;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        private int d_relevance_object_mbGM;
        
        public int HackFlags;
        
        public float mFixedRelativeTimeOfDay;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Base_GameInfo")]
        [TCosReborn.Framework.Attributes.TypeProxyDefinition(TypeName="Base_Controller")]
        public SerializableTypeProxy mPlayerControllerClass;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Base_GameInfo")]
        [TCosReborn.Framework.Attributes.TypeProxyDefinition(TypeName="Base_Controller")]
        public SerializableTypeProxy mTestBotControllerClass;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Base_GameInfo")]
        [TCosReborn.Framework.Attributes.TypeProxyDefinition(TypeName="Base_Controller")]
        public SerializableTypeProxy mGameMasterControllerClass;
        
        public Base_GameInfo()
        {
        }
    }
}
/*
event cl_OnUpdate();
event cl_OnFrame(float delta);
event cl_OnLogout(Actor controllerActor) {
local Base_Controller Controller;
local Base_Pawn Pawn;
if (controllerActor != None) {                                              
Controller = Base_Controller(controllerActor);                            
if (Controller.Pawn != None) {                                            
Pawn = Base_Pawn(Controller.Pawn);                                      
Pawn.cl_OnShutdown();                                                   
Controller.cl_OnShutdown();                                             
Pawn.Destroy();                                                         
Controller.Destroy();                                                   
} else {                                                                  
Controller.cl_OnShutdown();                                             
Controller.Destroy();                                                   
}
}
}
event cl_OnBaseline();
event sv_OnLogout(int aAccountID,Base_Pawn aPawn) {
local Base_Controller Controller;
if (aPawn != None) {                                                        
Controller = Base_Controller(aPawn.Controller);                           
aPawn.sv_OnShutdown();                                                    
Controller.sv_OnShutdown();                                               
aPawn.Destroy();                                                          
Controller.Destroy();                                                     
}
}
*/