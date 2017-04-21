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
    
    
    public class ZoneInfo : Info
    {
        
        public const float CHECK_MUSIC_PLAYING_TIMER = 1F;
        
        public SkyZoneInfo SkyZone;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneInfo")]
        public NameProperty ZoneTag;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneInfo")]
        public string LocationName = string.Empty;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneInfo")]
        public float KillZ;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneInfo")]
        public byte KillZType;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneInfo")]
        public bool bSoftKillZ;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneInfo")]
        public bool bTerrainZone;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneInfo")]
        public bool bDistanceFog;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneInfo")]
        public bool bHeightFog;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneInfo")]
        public bool bClearToFogColor;
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public List<TerrainInfo> Terrains = new List<TerrainInfo>();
        
        public Vector AmbientVector;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneLight")]
        public byte AmbientBrightness;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneLight")]
        public byte AmbientHue;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneLight")]
        public byte AmbientSaturation;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneLight")]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        public Color DistanceFogColor;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneLight")]
        public float DistanceFogStart;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneLight")]
        public float DistanceFogEnd;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public float RealDistanceFogEnd;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneLight")]
        public float DistanceFogEndMin;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneLight")]
        public float DistanceFogBlendTime;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneLight")]
        public float DistanceFogUpperHeight;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneLight")]
        public float DistanceFogLowerHeight;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneLight")]
        public float FogUpperHeightLimit;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneLight")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        public Texture EnvironmentMap;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneLight")]
        public float TexUPanSpeed;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneLight")]
        public float TexVPanSpeed;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneLight")]
        public float DramaticLightingScale;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneSound")]
        public I3DL2Listener ZoneEffect;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneVisibility")]
        public bool bLonelyZone;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneVisibility")]
        public List<ZoneInfo> ManualExcludes = new List<ZoneInfo>();
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneMap")]
        public string MapBlockTextureNamePrefix = string.Empty;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneMap")]
        public int MapBlockSize;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneMap")]
        public int MapUnitsPerPixel;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneMap")]
        public float MapMinX;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneMap")]
        public float MapMinY;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneMap")]
        public float MapMaxX;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneMap")]
        public float MapMaxY;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneMap")]
        public int MapMinZoomStep;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneMap")]
        public int MapMaxZoomStep;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneMap")]
        public int MapDefaultZoomStep;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneBloom")]
        public float BloomContrast;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneBloom")]
        public float OriginalScreenAmount;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneBloom")]
        public float BloomScreenAmount;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneBloom")]
        public float BlurScreenAmount;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneBloom")]
        public int NumBlurPasses;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneBloom")]
        public bool UseWideBlur;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public float BackupBloomContrast;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public float BackupBloomScreenAmount;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public float BackupOriginalScreenAmount;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public float BackupBlurScreenAmount;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public Color BackupDistanceFogColor;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public float BackupDistanceFogEnd;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public float BackupDistanceFogEndMin;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public float BackupDistanceFogStart;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public byte BackupAmbientBrightness;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public byte BackupAmbientHue;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public byte BackupAmbientSaturation;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public float BackupSunlightsBrightness;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public float BackupSunlightsContrastAdjust;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public float BackupLightmapContrastAdjust;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="LevelArea")]
        public LocalizedString LevelAreaName;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="PvP")]
        public PvPSettings PvPSettings;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="LevelArea")]
        public string RespawnPoint = string.Empty;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="DayNightCycle")]
        public bool EnableDayLightCycle;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneMusic")]
        public string TrackName = string.Empty;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneMusic")]
        public float AmbientFadeOutDuration;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneMusic")]
        public float AmbientFadeInDuration;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="ZoneMusic")]
        public float StartAmbientFadeInTime;
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        private float mCheckMusicTimer;
        
        public ZoneInfo()
        {
        }
    }
}
/*
event ActorLeaving(Actor Other);
event ActorEntered(Actor Other);
simulated function PreBeginPlay() {
Super.PreBeginPlay();                                                       
LinkToSkybox();                                                             
}
simulated function LinkToSkybox() {
local SkyZoneInfo TempSkyZone;
foreach AllActors(Class'SkyZoneInfo',TempSkyZone,'None') {                  
SkyZone = TempSkyZone;                                                    
}
if (Level.DetailMode == 0) {                                                
foreach AllActors(Class'SkyZoneInfo',TempSkyZone,'None') {                
if (!TempSkyZone.bHighDetail && !TempSkyZone.bSuperHighDetail) {        
SkyZone = TempSkyZone;                                                
}
}
goto jl0117;                                                              
}
if (Level.DetailMode == 1) {                                                
foreach AllActors(Class'SkyZoneInfo',TempSkyZone,'None') {                
if (!TempSkyZone.bSuperHighDetail) {                                    
SkyZone = TempSkyZone;                                                
}
}
goto jl0117;                                                              
}
if (Level.DetailMode == 2) {                                                
foreach AllActors(Class'SkyZoneInfo',TempSkyZone,'None') {                
SkyZone = TempSkyZone;                                                  
}
}
}
final native(308) iterator function ZoneActors(class<Actor> BaseClass,out Actor Actor);
*/