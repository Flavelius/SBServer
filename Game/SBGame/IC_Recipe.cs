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
    
    
    public class IC_Recipe : Item_Component
    {
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public List<RecipeComponent> Components = new List<RecipeComponent>();
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public List<RecipeComponent> RecycleComponents = new List<RecipeComponent>();
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public Item_Type ProducedItem;
        
        public IC_Recipe()
        {
        }
        
        public struct RecipeComponent
        {
            
            public Item_Type Item;
            
            public int Quantity;
        }
    }
}
/*
final event int GetCraftPrice() {
return ProducedItem.GetSellValue() * 0.25000000;                            
}
*/