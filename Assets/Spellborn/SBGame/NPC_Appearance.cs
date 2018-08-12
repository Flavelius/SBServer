﻿using System;
using Sirenix.OdinInspector;

namespace SBGame
{
    [Serializable] public class NPC_Appearance : Content_API
    {
        public const int SMALL_RADIUS = 21;

        public const int LARGE_RADIUS = 150;

        public const int MAX_NPC_VOICE = 14;

        public const int MAX_KID_MALE_VOICE = 1;

        public const int MAX_KID_FEMALE_VOICE = 2;

        [FoldoutGroup("Voice")]
        public byte Voice;

        public NPC_Appearance()
        {
        }

        public enum EVoiceType
        {
            VT_NONE,

            VT_Raw,

            VT_Military,

            VT_Egocentric,

            VT_Neurotic,

            VT_Seductive,

            VT_Wise,

            VT_Sneering,

            VT_Shy,

            VT_RANDOM,

            VT_1,

            VT_2,

            VT_3,

            VT_4,

            VT_5,

            VT_6,

            VT_7,

            VT_8,

            VT_9,

            VT_10,

            VT_11,

            VT_12,

            VT_13,

            VT_14,
        }
    }
}
/*
event byte GetGender() {
return 2;                                                                   
}
protected function Game_Appearance ForceAppearanceClass(Game_Pawn aPawn,export editinline Game_Appearance aAppearance,class<Game_Appearance> AppearanceClass) {
if (None == aAppearance
|| False == aPawn.ClassIsChildOf(aAppearance.Class,AppearanceClass)) {
aAppearance = new (aPawn) AppearanceClass;                                
aAppearance.OnConstruct();                                                
aAppearance.cl_OnInit();                                                  
}
return aAppearance;                                                         
}
event int GetHead() {
return 0;                                                                   
}
event SetHead(int NewHead) {
}
event EditorVerify();
native function float GetSkillRadius();
native function float GetCollisionRadius();
native function float GetCollisionHeight();
function Game_Appearance CreateAppearance(Game_Pawn aPawn,export editinline Game_Appearance aAppearance,bool aShifting) {
local float R;
local float H;
aPawn.SkillRadius = GetSkillRadius();                                       
if (!aShifting) {                                                           
R = GetCollisionRadius();                                                 
H = GetCollisionHeight();                                                 
if (R >= 0.00000000 && H >= 0.00000000) {                                 
aPawn.SetCollisionSize(R,H);                                            
}
}
if (aAppearance != None) {                                                  
switch (Voice) {                                                          
case 0 :                                                                
aAppearance.SetVoice(255);                                            
break;                                                                
case 9 :                                                                
if (aAppearance.IsKid()) {                                            
if (aAppearance.GetGender() == Class'Content_API'.0) {              
aAppearance.SetVoice(Rand(1));                                    
} else {                                                            
aAppearance.SetVoice(Rand(2));                                    
}
} else {                                                              
aAppearance.SetVoice(10 + Rand(14));                                
}
break;                                                                
default:                                                                
aAppearance.SetVoice(Voice - 1);                                      
break;                                                                
}
aAppearance.SetAvatarTexture(AvatarTexture);                              
}
return aAppearance;                                                         
}
*/