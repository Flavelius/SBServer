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
    
    
    public class NPC_Habitat : Actor
    {
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="aI")]
        public float HabitatRange;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Hormones")]
        public float DesolationRate;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Habitat")]
        public List<NPC_Spawner> Prey = new List<NPC_Spawner>();
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Habitat")]
        public List<WanderSmell> Smells = new List<WanderSmell>();
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Habitat")]
        public int SmellSpawns;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Habitat")]
        public List<WanderObstacle> Obstacles = new List<WanderObstacle>();
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Habitat")]
        public float IntruderAttraction;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Habitat")]
        public float SocialAttraction;
        
        public NPC_Habitat()
        {
        }
        
        public struct WanderObstacle
        {
            
            public Actor Obstacle;
            
            public Vector Offset;
            
            public float Size;
            
            public float Range;
        }
        
        public struct WanderSmell
        {
            
            public Vector Location;
            
            public float Size;
        }
    }
}
/*
final native function bool CheckHabitat(Vector aLocation);
*/