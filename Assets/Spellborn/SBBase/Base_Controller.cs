﻿using System;
using Engine;

namespace SBBase
{
    [Serializable] public class Base_Controller : PlayerController
    {
        public int AccountID;

        public int CharacterID;

        [FieldConst()]
        public bool ControllerInitialized;

        [TypeProxyDefinition(TypeName = "Base_Pawn")]
        public Type mPawnClass;

        public Base_Controller()
        {
        }

        public enum EGroupIDs
        {
            EGroupIDs_RESERVED_0,

            GID_CLIENT,

            GID_RELEVANT,

            EGroupIDs_RESERVED_3,

            GID_SCENERY,

            EGroupIDs_RESERVED_5,

            EGroupIDs_RESERVED_6,

            EGroupIDs_RESERVED_7,

            GID_TEAM,

            EGroupIDs_RESERVED_9,

            EGroupIDs_RESERVED_10,

            EGroupIDs_RESERVED_11,

            EGroupIDs_RESERVED_12,

            EGroupIDs_RESERVED_13,

            EGroupIDs_RESERVED_14,

            EGroupIDs_RESERVED_15,

            GID_FRIENDS,

            EGroupIDs_RESERVED_17,

            EGroupIDs_RESERVED_18,

            EGroupIDs_RESERVED_19,

            EGroupIDs_RESERVED_20,

            EGroupIDs_RESERVED_21,

            EGroupIDs_RESERVED_22,

            EGroupIDs_RESERVED_23,

            EGroupIDs_RESERVED_24,

            EGroupIDs_RESERVED_25,

            EGroupIDs_RESERVED_26,

            EGroupIDs_RESERVED_27,

            EGroupIDs_RESERVED_28,

            EGroupIDs_RESERVED_29,

            EGroupIDs_RESERVED_30,

            EGroupIDs_RESERVED_31,

            GID_GUILD,

            EGroupIDs_RESERVED_33,

            EGroupIDs_RESERVED_34,

            EGroupIDs_RESERVED_35,

            EGroupIDs_RESERVED_36,

            EGroupIDs_RESERVED_37,

            EGroupIDs_RESERVED_38,

            EGroupIDs_RESERVED_39,

            EGroupIDs_RESERVED_40,

            EGroupIDs_RESERVED_41,

            EGroupIDs_RESERVED_42,

            EGroupIDs_RESERVED_43,

            EGroupIDs_RESERVED_44,

            EGroupIDs_RESERVED_45,

            EGroupIDs_RESERVED_46,

            EGroupIDs_RESERVED_47,

            EGroupIDs_RESERVED_48,

            EGroupIDs_RESERVED_49,

            EGroupIDs_RESERVED_50,

            EGroupIDs_RESERVED_51,

            EGroupIDs_RESERVED_52,

            EGroupIDs_RESERVED_53,

            EGroupIDs_RESERVED_54,

            EGroupIDs_RESERVED_55,

            EGroupIDs_RESERVED_56,

            EGroupIDs_RESERVED_57,

            EGroupIDs_RESERVED_58,

            EGroupIDs_RESERVED_59,

            EGroupIDs_RESERVED_60,

            EGroupIDs_RESERVED_61,

            EGroupIDs_RESERVED_62,

            EGroupIDs_RESERVED_63,

            GID_QUERY,

            EGroupIDs_RESERVED_65,

            EGroupIDs_RESERVED_66,

            EGroupIDs_RESERVED_67,

            EGroupIDs_RESERVED_68,

            EGroupIDs_RESERVED_69,

            EGroupIDs_RESERVED_70,

            EGroupIDs_RESERVED_71,

            EGroupIDs_RESERVED_72,

            EGroupIDs_RESERVED_73,

            EGroupIDs_RESERVED_74,

            EGroupIDs_RESERVED_75,

            EGroupIDs_RESERVED_76,

            EGroupIDs_RESERVED_77,

            EGroupIDs_RESERVED_78,

            EGroupIDs_RESERVED_79,

            EGroupIDs_RESERVED_80,

            EGroupIDs_RESERVED_81,

            EGroupIDs_RESERVED_82,

            EGroupIDs_RESERVED_83,

            EGroupIDs_RESERVED_84,

            EGroupIDs_RESERVED_85,

            EGroupIDs_RESERVED_86,

            EGroupIDs_RESERVED_87,

            EGroupIDs_RESERVED_88,

            EGroupIDs_RESERVED_89,

            EGroupIDs_RESERVED_90,

            EGroupIDs_RESERVED_91,

            EGroupIDs_RESERVED_92,

            EGroupIDs_RESERVED_93,

            EGroupIDs_RESERVED_94,

            EGroupIDs_RESERVED_95,

            EGroupIDs_RESERVED_96,

            EGroupIDs_RESERVED_97,

            EGroupIDs_RESERVED_98,

            EGroupIDs_RESERVED_99,

            EGroupIDs_RESERVED_100,

            EGroupIDs_RESERVED_101,

            EGroupIDs_RESERVED_102,

            EGroupIDs_RESERVED_103,

            EGroupIDs_RESERVED_104,

            EGroupIDs_RESERVED_105,

            EGroupIDs_RESERVED_106,

            EGroupIDs_RESERVED_107,

            EGroupIDs_RESERVED_108,

            EGroupIDs_RESERVED_109,

            EGroupIDs_RESERVED_110,

            EGroupIDs_RESERVED_111,

            EGroupIDs_RESERVED_112,

            EGroupIDs_RESERVED_113,

            EGroupIDs_RESERVED_114,

            EGroupIDs_RESERVED_115,

            EGroupIDs_RESERVED_116,

            EGroupIDs_RESERVED_117,

            EGroupIDs_RESERVED_118,

            EGroupIDs_RESERVED_119,

            EGroupIDs_RESERVED_120,

            EGroupIDs_RESERVED_121,

            EGroupIDs_RESERVED_122,

            EGroupIDs_RESERVED_123,

            EGroupIDs_RESERVED_124,

            EGroupIDs_RESERVED_125,

            EGroupIDs_RESERVED_126,

            EGroupIDs_RESERVED_127,

            GID_SERVER,
        }
    }
}
/*
native function sv_ClientMessage(string Message);
native function sv_PrivateMessage(Pawn aPawn,string Message);
native function sv_ZoneMessage(string Message);
native function sv_UniverseMessage(string Message);
native function sv_GlobalMessage(string Message);
native function sv_SupportMessage(string Message);
native function sv_SystemMessage(string Message);
native function bool sv_CanReplicate();
event cl_OnShutdown();
event cl_OnTick(float DeltaTime) {
}
event cl_OnBaseline();
event cl_OnInit() {
if (Pawn != None) {                                                         
Base_Pawn(Pawn).cl_OnInit();                                              
}
if (Player != None) {                                                       
Player.GUIDesktop.OnLogin();                                              
}
ControllerInitialized = True;                                               
}
event sv_OnShutdown();
native function sv_OnInit();
event SetAuthorityLevel(int aLevel);
*/