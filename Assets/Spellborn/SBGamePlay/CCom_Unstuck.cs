﻿using System;
using SBGame;

namespace SBGamePlay
{
    [Serializable] public class CCom_Unstuck : Game_ConsoleCommand
    {
        public CCom_Unstuck()
        {
        }
    }
}
/*
native function bool Execute(Game_Pawn aPawn,array<string> Params,Game_Pawn aTarget);
*/