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


namespace Engine
{
    
    
    public class SBLightmapGenerationMaterial : SBMaterial
    {
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="SBLightmapGenerationMaterial")]
        public float ZBias;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="SBLightmapGenerationMaterial")]
        public float PCFRadius;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="SBLightmapGenerationMaterial")]
        public float ProjectorBrightness;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="SBLightmapGenerationMaterial")]
        public Plane LightColor;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="SBLightmapGenerationMaterial")]
        public Vector LightPosition;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="SBLightmapGenerationMaterial")]
        public Vector LightDirection;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="SBLightmapGenerationMaterial")]
        public float LightRadius;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="SBLightmapGenerationMaterial")]
        public byte LightEffect;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="SBLightmapGenerationMaterial")]
        public byte LightShadingEffect;
        
        public SBLightmapGenerationMaterial()
        {
        }
    }
}