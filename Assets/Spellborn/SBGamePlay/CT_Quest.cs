﻿using System;
using SBGame;

namespace SBGamePlay
{
    [Serializable] public class CT_Quest : Conversation_Topic
    {
        public CT_Quest()
        {
        }
    }
}
/*
function Content_Type GetContext() {
return Quest_Type(Outer);                                                   
}
function string GetText() {
local export editinline Quest_Type quest;
quest = Quest_Type(GetContext());                                           
if (Len(TopicText.Text) != 0) {                                             
return Super.GetText();                                                   
} else {                                                                    
return quest.GetName();                                                   
}
}
*/