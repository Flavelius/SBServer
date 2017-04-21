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
    
    
    public class Projector : Actor
    {
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public byte MaterialBlendingOp;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public byte FrameBufferBlendingOp;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        public Material ProjTexture;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public int FOV;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public int MaxTraceDistance;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public bool bProjectBSP;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public bool bProjectTerrain;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public bool bProjectStaticMesh;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public bool bProjectParticles;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public bool bProjectActor;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public bool bLevelStatic;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public bool bClipBSP;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public bool bClipStaticMesh;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public bool bProjectOnUnlit;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public bool bGradient;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public bool bProjectOnBackfaces;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public bool bProjectOnAlpha;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public bool bProjectOnParallelBSP;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public NameProperty ProjectTag;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public bool bDynamicAttach;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public bool bNoProjectOnOwner;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public bool bProjectOnHidden;
        
        public float FadeInTime;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public bool bScaleWithTexture;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Projector")]
        public bool bIsEnabled;
        
        public float ExpireTime;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        public Texture GradientTexture;
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        [TCosReborn.Framework.Attributes.ArraySizeForExtractionAttribute(Size=6)]
        public Plane[] FrustumPlanes = new Plane[0];
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        [TCosReborn.Framework.Attributes.ArraySizeForExtractionAttribute(Size=8)]
        public Vector[] FrustumVertices = new Vector[0];
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public Box Box;
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public ProjectorRenderInfoPtr RenderInfo;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public Matrix GradientMatrix;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public Matrix Matrix;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public Vector OldLocation;
        
        public Projector()
        {
        }
        
        public enum EProjectorBlending
        {
            
            PB_None ,
            
            PB_Modulate ,
            
            PB_AlphaBlend ,
            
            PB_Add,
        }
    }
}
/*
simulated event UnTouch(Actor Other) {
DetachActor(Other);                                                         
}
simulated event Touch(Actor Other) {
if (Other == None) {                                                        
return;                                                                   
}
if (Other.bAcceptsProjectors
&& (ProjectTag == 'None' || Other.Tag == ProjectTag)
&& (bProjectStaticMesh || Other.StaticMesh == None)
&& (bProjectOnHidden || !Other.bHidden)
&& !Other.bStatic && bStatic && Other.StaticMesh != None) {
AttachActor(Other);                                                       
}
}
simulated event PostBeginPlay() {
if (Level.NetMode == 1) {                                                   
GotoState('NoProjection');                                                
return;                                                                   
}
AttachProjector(FadeInTime);                                                
if (bLevelStatic) {                                                         
AbandonProjector();                                                       
Destroy();                                                                
}
if (bProjectActor) {                                                        
SetCollision(True,False);                                                 
}
}
function SetEnabled(bool IsEnabled) {
bIsEnabled = IsEnabled;                                                     
}
native function DetachActor(Actor A);
native function AttachActor(Actor A);
native function AbandonProjector(optional float Lifetime);
native function DetachProjector(optional bool Force);
native function AttachProjector(optional float FadeInTime);
state NoProjection {
function BeginState() {
Disable('Tick');                                                        
}
}
*/