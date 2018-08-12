﻿using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Engine
{
    [Serializable] public class Actor : UObject
    {
        public const float MINFLOORZ = 0.7F;

        public const float MAXSTEPHEIGHT = 25F;

        public eSBNetworkRoles SBRole;

        [FoldoutGroup("Advanced")]
        [HideInInspector]
        public bool bHidden;

        [FoldoutGroup("Movement")]
        [FieldConst()]
        public EPhysics Physics;

        public ENetRole Role;

        [FieldConst()]
        public LevelInfo Level;

        [FoldoutGroup("Events")]
        public NameProperty Tag;

        [FoldoutGroup("Events")]
        public NameProperty Event;

        [FoldoutGroup("Object")]
        public NameProperty InitialState;

        [FoldoutGroup("Object")]
        public NameProperty Group;

        [FoldoutGroup("Object")]
        public List<ActorGroup> ActorGroups = new List<ActorGroup>();

        [FieldConst()]
        [NonSerialized, HideInInspector]
        public List<Actor> Touching = new List<Actor>();

        [FieldConst()]
        //[TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        public PhysicsVolume PhysicsVolume;

        [FoldoutGroup("Movement")]
        [NonSerialized, HideInInspector]
        public Vector Velocity;

        [FoldoutGroup("Movement")]
        [FieldConst()]
        public Rotator Rotation;

        [FoldoutGroup("Movement")]
        public Rotator RotationRate = new Rotator(4096, 50000, 3072);

        [FoldoutGroup("Events")]
        [ArraySizeForExtraction(Size = 8)]
        public NameProperty[] ExcludeTag = new NameProperty[0];

        [ArraySizeForExtraction(Size = 10)]
        public string[] StatsGroups = new string[0];

        public Actor()
        {
        }

        public enum EOwningDepartmentType
        {
            ODT_None,

            ODT_Level,

            ODT_Sound,

            EOwningDepartmentType_RESERVED_3,

            ODT_Gameplay,
        }

        public enum eKillZType
        {
            KILLZ_None,

            KILLZ_Lava,

            KILLZ_Suicide,
        }

        public enum ETravelType
        {
            TRAVEL_Absolute,

            TRAVEL_Partial,

            TRAVEL_Relative,
        }

        public enum ENetRole
        {
            ROLE_None,

            ROLE_DumbProxy,

            ROLE_SimulatedProxy,

            ROLE_AutonomousProxy,

            ROLE_Authority,
        }

        public enum EPhysics
        {
            PHYS_None,

            PHYS_Walking,

            PHYS_Falling,

            PHYS_Swimming,

            PHYS_Flying,

            PHYS_Rotating,

            PHYS_Projectile,

            PHYS_Interpolating,

            PHYS_MovingBrush,

            PHYS_Spider,

            PHYS_Trailer,

            PHYS_Ladder,

            PHYS_RootMotion,

            PHYS_Karma,

            PHYS_KarmaRagDoll,

            PHYS_Hovering,

            PHYS_CinMotion,

            PHYS_DragonFlying,

            PHYS_Jumping,

            PHYS_SitGround,

            PHYS_SitChair,

            PHYS_Submerged,

            PHYS_Turret,
        }

        public enum EResidence
        {
            RES_ServerClient,

            RES_ClientOnly,

            RES_ServerOnly,
        }

        public enum EFilterState
        {
            FS_Maybe,

            FS_Yes,

            FS_No,
        }

        public enum ERelevancyRange
        {
            RelevancyNear,

            RelevancyNormal,

            RelevancyFar,

            RelevancyVeryFar,

            RelevancyWorld,
        }

        public enum eSBNetworkRoles
        {
            sbROLE_None,

            sbROLE_Server,

            sbROLE_Proxy,

            sbROLE_DBProxy,

            sbROLE_Client,

            sbROLE_RelevantLod0,

            sbROLE_RelevantLod1,

            sbROLE_RelevantLod2,

            sbROLE_RelevantLod3,

            sbROLE_ServerLocal,

            sbROLE_ClientLocal,
        }
    }
}
/*
final native function GetTaggedRelations(string aTag,Color aColour,string aDescription,out array<ActorRelation> oRelations);
event cl_NotifyUnderCursor(bool aSetting);
event RadialMenuSelect(Pawn aPlayerPawn,byte aMainOption,byte aSubOption) {
}
function Material RadialMenuImage(Pawn aPlayerPawn,byte aMainOption,byte aSubOption) {
return None;                                                                
}
event RadialMenuCollect(Pawn aPlayerPawn,byte aMainOption,out array<byte> aMainOptions) {
}
event OnSettingsChanged();
function bool BlocksShotAt(Actor Other) {
return False;                                                               
}
function PawnBaseDied();
function bool IsStationary() {
return True;                                                                
}
function NotifyLocalPlayerTeamReceived();
function NotifyLocalPlayerDead(PlayerController PC);
function SetDelayedDamageInstigatorController(Controller C);
function bool TeamLink(int TeamNum) {
return False;                                                               
}
function bool SelfTriggered() {
return False;                                                               
}
simulated function bool EffectIsRelevant(Vector SpawnLocation,bool bForceDedicated) {
local PlayerController P;
local bool bResult;
if (Level.NetMode == 1) {                                                   
return bForceDedicated;                                                   
}
if (Level.NetMode != 3) {                                                   
bResult = True;                                                           
} else {                                                                    
if (Instigator != None && Instigator.IsHumanControlled()) {               
return True;                                                            
} else {                                                                  
if (SpawnLocation == Location) {                                        
bResult = Level.TimeSeconds - LastRenderTime < 3;                     
} else {                                                                
if (Instigator != None
&& Level.TimeSeconds - Instigator.LastRenderTime < 3) {
bResult = True;                                                     
}
}
}
}
if (bResult) {                                                              
P = Level.GetLocalPlayerController();                                     
if (P == None || P.ViewTarget == None) {                                  
bResult = False;                                                        
} else {                                                                  
if (P.Pawn == Instigator) {                                             
bResult = CheckMaxEffectDistance(P,SpawnLocation);                    
} else {                                                                
if (vector(P.Rotation) Dot (SpawnLocation - P.ViewTarget.Location) < 0.00000000) {
bResult = VSize(P.ViewTarget.Location - SpawnLocation) < 1600;      
} else {                                                              
bResult = CheckMaxEffectDistance(P,SpawnLocation);                  
}
}
}
}
return bResult;                                                             
}
simulated function bool CheckMaxEffectDistance(PlayerController P,Vector SpawnLocation) {
return !P.BeyondViewDistance(SpawnLocation,0.00000000);                     
}
static function Crash() {
assert(False);                                                              
}
function Vector GetCollisionExtent() {
local Vector Extent;
Extent = CollisionRadius * vect(1.000000, 1.000000, 0.000000);              
Extent.Z = CollisionHeight;                                                 
return Extent;                                                              
}
simulated function bool CanSplash() {
return False;                                                               
}
function PlayTeleportEffect(bool bOut,bool bSound);
function bool IsInPain() {
local PhysicsVolume V;
foreach TouchingActors(Class'PhysicsVolume',V) {                            
if (V.bPainCausing && V.DamagePerSec > 0) {                               
return True;                                                            
}
}
return False;                                                               
}
function bool IsInVolume(Volume aVolume) {
local Volume V;
foreach TouchingActors(Class'Volume',V) {                                   
if (V == aVolume) {                                                       
return True;                                                            
}
}
return False;                                                               
}
final native function UntriggerEvent(name EventName,Actor Other,Pawn EventInstigator);
final native function TriggerEvent(name EventName,Actor Other,Pawn EventInstigator);
function Reset();
simulated function StartInterpolation() {
GotoState('None');                                                          
SetCollision(True,False);                                                   
bCollideWorld = False;                                                      
bInterpolating = True;                                                      
SetPhysics(0);                                                              
}
final simulated function bool TouchingActor(Actor A) {
local Vector dir;
dir = Location - A.Location;                                                
if (Abs(dir.Z) > CollisionHeight + A.CollisionHeight) {                     
return False;                                                             
}
dir.Z = 0.00000000;                                                         
return VSize(dir) <= CollisionRadius + A.CollisionRadius;                   
}
final simulated function bool NearSpot(Vector Spot) {
local Vector dir;
dir = Location - Spot;                                                      
if (Abs(dir.Z) > CollisionHeight) {                                         
return False;                                                             
}
dir.Z = 0.00000000;                                                         
return VSize(dir) <= CollisionRadius;                                       
}
simulated function DisplayDebug(Canvas Canvas,out float YL,out float YPos) {
local string t;
local float XL;
local int i;
local Actor A;
local name Anim;
local float frame;
local float Rate;
Canvas.Style = 1;                                                           
Canvas.StrLen("TEST",XL,YL);                                                
YPos = YPos + YL;                                                           
Canvas.SetPos(4.00000000,YPos);                                             
Canvas.SetDrawColor(255,0,0);                                               
t = "";                                                                     
if (bDeleteMe) {                                                            
t = t $ " DELETED (bDeleteMe == true)";                                   
}
Canvas.DrawText(t,False);                                                   
YPos += YL;                                                                 
Canvas.SetPos(4.00000000,YPos);                                             
Canvas.SetDrawColor(255,255,255);                                           
if (Level.NetMode != 0) {                                                   
t = "ROLE ";                                                              
switch (Role) {                                                           
case 0 :                                                                
t = t $ "None";                                                       
break;                                                                
case 1 :                                                                
t = t $ "DumbProxy";                                                  
break;                                                                
case 2 :                                                                
t = t $ "SimulatedProxy";                                             
break;                                                                
case 3 :                                                                
t = t $ "AutonomousProxy";                                            
break;                                                                
case 4 :                                                                
t = t $ "Authority";                                                  
break;                                                                
default:                                                                
}
t = t $ " REMOTE ROLE ";                                                  
if (bTearOff) {                                                           
t = t $ " Tear Off";                                                    
}
Canvas.DrawText(t,False);                                                 
YPos += YL;                                                               
Canvas.SetPos(4.00000000,YPos);                                           
}
t = "Physics ";                                                             
switch (Physics) {                                                          
case 0 :                                                                  
t = t $ "None";                                                         
break;                                                                  
case 1 :                                                                  
t = t $ "Walking";                                                      
break;                                                                  
case 2 :                                                                  
t = t $ "Falling";                                                      
break;                                                                  
case 3 :                                                                  
t = t $ "Swimming";                                                     
break;                                                                  
case 4 :                                                                  
t = t $ "Flying";                                                       
break;                                                                  
case 5 :                                                                  
t = t $ "Rotating";                                                     
break;                                                                  
case 6 :                                                                  
t = t $ "Projectile";                                                   
break;                                                                  
case 7 :                                                                  
t = t $ "Interpolating";                                                
break;                                                                  
case 8 :                                                                  
t = t $ "MovingBrush";                                                  
break;                                                                  
case 9 :                                                                  
t = t $ "Spider";                                                       
break;                                                                  
case 10 :                                                                 
t = t $ "Trailer";                                                      
break;                                                                  
case 11 :                                                                 
t = t $ "Ladder";                                                       
break;                                                                  
case 13 :                                                                 
t = t $ "Karma";                                                        
break;                                                                  
case 18 :                                                                 
t = t $ "Jumping";                                                      
break;                                                                  
case 19 :                                                                 
t = t $ "SittingOnGround";                                              
break;                                                                  
case 20 :                                                                 
t = t $ "SittingOnChair";                                               
break;                                                                  
default:                                                                  
}
t = t $ " in physicsvolume "
$ GetItemName(string(PhysicsVolume))
$ " on base "
$ GetItemName(string(Base));
if (bBounce) {                                                              
t = t $ " - will bounce";                                                 
}
Canvas.DrawText(t,False);                                                   
YPos += YL;                                                                 
Canvas.SetPos(4.00000000,YPos);                                             
Canvas.DrawText("Location: " $ string(Location)
$ " Rotation "
$ string(Rotation),False);
YPos += YL;                                                                 
Canvas.SetPos(4.00000000,YPos);                                             
Canvas.DrawText("Velocity: " $ string(Velocity)
$ " Speed "
$ string(VSize(Velocity))
$ " Speed2D "
$ string(VSize(Velocity - Velocity.Z * vect(0.000000, 0.000000, 1.000000))),False);
YPos += YL;                                                                 
Canvas.SetPos(4.00000000,YPos);                                             
Canvas.DrawText("Acceleration: " $ string(Acceleration),False);             
YPos += YL;                                                                 
Canvas.SetPos(4.00000000,YPos);                                             
Canvas.DrawColor.B = 0;                                                     
Canvas.DrawText("Collision Radius " $ string(CollisionRadius)
$ " Height "
$ string(CollisionHeight));
YPos += YL;                                                                 
Canvas.SetPos(4.00000000,YPos);                                             
Canvas.DrawText("Collides with Actors " $ string(bCollideActors)
$ ", world "
$ string(bCollideWorld)
$ ", proj. target "
$ string(bProjTarget));
YPos += YL;                                                                 
Canvas.SetPos(4.00000000,YPos);                                             
Canvas.DrawText("Blocks Actors " $ string(bBlockActors));                   
YPos += YL;                                                                 
Canvas.SetPos(4.00000000,YPos);                                             
t = "Touching ";                                                            
foreach TouchingActors(Class'Actor',A) {                                    
t = t $ GetItemName(string(A)) $ " ";                                     
}
if (t == "Touching ") {                                                     
t = "Touching nothing";                                                   
}
Canvas.DrawText(t,False);                                                   
YPos += YL;                                                                 
Canvas.SetPos(4.00000000,YPos);                                             
Canvas.DrawColor.R = 0;                                                     
t = "Rendered: ";                                                           
switch (Style) {                                                            
case 0 :                                                                  
t = t;                                                                  
break;                                                                  
case 1 :                                                                  
t = t $ "Normal";                                                       
break;                                                                  
case 2 :                                                                  
t = t $ "Masked";                                                       
break;                                                                  
case 3 :                                                                  
t = t $ "Translucent";                                                  
break;                                                                  
case 4 :                                                                  
t = t $ "Modulated";                                                    
break;                                                                  
case 5 :                                                                  
t = t $ "Alpha";                                                        
break;                                                                  
default:                                                                  
}
switch (DrawType) {                                                         
case 0 :                                                                  
t = t $ " None";                                                        
break;                                                                  
case 1 :                                                                  
t = t $ " Sprite ";                                                     
break;                                                                  
case 2 :                                                                  
t = t $ " Mesh ";                                                       
break;                                                                  
case 3 :                                                                  
t = t $ " Brush ";                                                      
break;                                                                  
case 4 :                                                                  
t = t $ " RopeSprite ";                                                 
break;                                                                  
case 5 :                                                                  
t = t $ " VerticalSprite ";                                             
break;                                                                  
case 6 :                                                                  
t = t $ " Terraform ";                                                  
break;                                                                  
case 7 :                                                                  
t = t $ " SpriteAnimOnce ";                                             
break;                                                                  
case 8 :                                                                  
t = t $ " StaticMesh ";                                                 
break;                                                                  
default:                                                                  
}
if (DrawType == 2) {                                                        
t = t $ GetItemName(string(Mesh));                                        
if (Skins.Length > 0) {                                                   
t = t $ " skins: ";                                                     
i = 0;                                                                  
while (i < Skins.Length) {                                              
if (Skins[i] == None) {                                               
break;                                                              
} else {                                                              
t = t $ GetItemName(string(Skins[i]))
$ ", ";         
}
i++;                                                                  
}
}
Canvas.DrawText(t,False);                                                 
YPos += YL;                                                               
Canvas.SetPos(4.00000000,YPos);                                           
GetAnimParams(0,Anim,frame,Rate);                                         
t = "AnimSequence " $ string(Anim) $ " Frame "
$ string(frame)
$ " Rate "
$ string(Rate);
if (bAnimByOwner) {                                                       
t = t $ " Anim by Owner";                                               
}
} else {                                                                    
if (DrawType == 1 || DrawType == 7) {                                     
t = t $ string(Texture);                                                
} else {                                                                  
if (DrawType == 3) {                                                    
t = t $ string(Brush);                                                
}
}
}
Canvas.DrawText(t,False);                                                   
YPos += YL;                                                                 
Canvas.SetPos(4.00000000,YPos);                                             
Canvas.DrawColor.B = 255;                                                   
Canvas.DrawText("Tag: " $ string(Tag) $ " Event: "
$ string(Event)
$ " STATE: "
$ string(GetStateName()),False);
YPos += YL;                                                                 
Canvas.SetPos(4.00000000,YPos);                                             
Canvas.DrawText("Instigator "
$ GetItemName(string(Instigator))
$ " Owner "
$ GetItemName(string(Owner)));
YPos += YL;                                                                 
Canvas.SetPos(4.00000000,YPos);                                             
Canvas.DrawText("Timer: " $ string(TimerCounter)
$ " LifeSpan "
$ string(LifeSpan)
$ " AmbientSound "
$ string(AmbientSound)
$ " volume "
$ string(SoundVolume));
YPos += YL;                                                                 
Canvas.SetPos(4.00000000,YPos);                                             
}
function SetDefaultDisplayProperties() {
Style = default.Style;                                                      
Texture = default.Texture;                                                  
bUnlit = default.bUnlit;                                                    
}
function SetDisplayProperties(byte NewStyle,Material NewTexture,bool bLighting) {
Style = NewStyle;                                                           
Texture = NewTexture;                                                       
bUnlit = bLighting;                                                         
}
simulated function string GetHumanReadableName() {
return GetItemName(string(Class));                                          
}
function POVChanged(PlayerController PC,bool bBehindViewChanged);
function BecomeViewTarget();
event TravelPostAccept();
event TravelPreAccept();
function bool CheckForErrors() {
return False;                                                               
}
simulated function HurtRadius(float DamageAmount,float DamageRadius,class<DamageType> DamageType,float Momentum,Vector HitLocation) {
local Actor Victims;
local float damageScale;
local float dist;
local Vector dir;
if (bHurtEntry) {                                                           
return;                                                                   
}
bHurtEntry = True;                                                          
foreach VisibleCollidingActors(Class'Actor',Victims,DamageRadius,HitLocation) {
if (Victims != self && Victims.SBRole == 1
&& !Victims.IsA('FluidSurfaceInfo')) {
dir = Victims.Location - HitLocation;                                   
dist = FMax(1.00000000,VSize(dir));                                     
dir = dir / dist;                                                       
damageScale = 1.00000000 - FMax(0.00000000,(dist - Victims.CollisionRadius) / DamageRadius);
Victims.TakeDamage(damageScale * DamageAmount,Instigator,Victims.Location - 0.50000000 * (Victims.CollisionHeight + Victims.CollisionRadius) * dir,damageScale * Momentum * dir,DamageType);
}
}
bHurtEntry = False;                                                         
}
simulated function UpdatePrecacheStaticMeshes() {
if (DrawType == 8 && !bStatic && !bNoDelete) {                              
Log("Calling AddPrecacheStaticMesh for "
$ string(StaticMesh));   
Level.AddPrecacheStaticMesh(StaticMesh);                                  
}
}
simulated function UpdatePrecacheMaterials() {
local int i;
if (Skins.Length > 0) {                                                     
i = 0;                                                                    
while (i < Skins.Length) {                                                
if (Skins[i] != None) {                                                 
Level.AddPrecacheMaterial(Skins[i]);                                  
}
i++;                                                                    
}
}
}
simulated event SetInitialState() {
bScriptInitialized = True;                                                  
if (InitialState != 'None') {                                               
GotoState(InitialState);                                                  
} else {                                                                    
GotoState('Auto');                                                        
}
}
event PostBeginPlay();
event PreBeginPlay() {
if (Level.DetailMode == 0
&& CullDistance == default.CullDistance) {  
CullDistance *= 0.80000001;                                               
}
}
event RenderTexture(ScriptedTexture Tex);
function RenderOverlays(Canvas Canvas);
event RecoverFromBadStateCode();
final static native(552) operator(16) Color *(Color A,float B);
final static native(551) operator(20) Color +(Color A,Color B);
final static native(550) operator(16) Color *(float A,Color B);
final static native(549) operator(20) Color -(Color A,Color B);
final native(321) iterator function CollidingActors(class<Actor> BaseClass,out Actor Actor,float Radius,optional Vector loc);
final native(312) iterator function VisibleCollidingActors(class<Actor> BaseClass,out Actor Actor,float Radius,optional Vector loc,optional bool bIgnoreHidden);
final native(311) iterator function VisibleActors(class<Actor> BaseClass,out Actor Actor,optional float Radius,optional Vector loc);
final native(310) iterator function RadiusActors(class<Actor> BaseClass,out Actor Actor,float Radius,optional Vector loc);
final native(309) iterator function TraceActors(class<Actor> BaseClass,out Actor Actor,out Vector HitLoc,out Vector HitNorm,Vector End,optional Vector Start,optional Vector Extent);
final native(307) iterator function TouchingActors(class<Actor> BaseClass,out Actor Actor);
final native(306) iterator function BasedActors(class<Actor> BaseClass,out Actor Actor);
final native(305) iterator function ChildActors(class<Actor> BaseClass,out Actor Actor);
final native(313) iterator function DynamicActors(class<Actor> BaseClass,out Actor Actor,optional name MatchTag);
final native(304) iterator function AllActors(class<Actor> BaseClass,out Actor Actor,optional name MatchTag);
final native function GameInfo GetGameInfo();
final native function ResetStaticFilterState();
event BeginPlay();
event PostTeleport(Teleporter OutTeleporter);
event bool PreTeleport(Teleporter InTeleporter);
final native function Vector SuggestFallVelocity(Vector Destination,Vector Start,float MaxZ,float MaxXYSpeed);
final native(532) function bool PlayerCanSeeMe();
final native(512) function MakeNoise(float Loudness);
final native function bool ForceFeedbackSupported(optional bool Enable);
final native(569) function ChangeBaseParamsFeedbackEffect(string EffectName,optional float DirectionX,optional float DirectionY,optional float Gain);
final native(568) function ChangeSpringFeedbackEffect(string EffectName,float CenterX,float CenterY);
final native(567) function StopFeedbackEffect(optional string EffectName);
final native(566) function PlayFeedbackEffect(string EffectName);
final native function float GetSoundDuration(Sound Sound);
native simulated event DemoPlaySound(Sound Sound,optional byte Slot,optional float Volume,optional bool bNoOverride,optional float Radius,optional float Pitch,optional bool Attenuate);
final native function PlayOwnedSound(Sound Sound,optional byte Slot,optional float Volume,optional bool bNoOverride,optional float Radius,optional float Pitch,optional bool Attenuate);
final native(264) function PlaySound(Sound Sound,optional byte Slot,optional float Volume,optional bool bNoOverride,optional float Radius,optional float Pitch,optional bool Attenuate);
native function StopSBSoundTypes(byte aSoundType);
native function StopAudio(int aTrackHandle,optional Actor aOwner,optional float aFadeOutTime);
native function int PlaySBSound(Sound Sound,float Volume,float Pitch,float Radius,optional Vector SoundSourceOffset,optional byte AudioType);
event PostLoadSavedGame();
event PreSaveGame();
final native(280) function SetTimer(float NewTimerRate,bool bLoop);
event TornOff();
final native(279) function bool Destroy();
final native(278) function Actor Spawn(class<Actor> SpawnClass,optional Actor SpawnOwner,optional name SpawnTag,optional Vector SpawnLocation,optional Rotator SpawnRotation,optional int InstanceID);
final native function bool TraceThisActor(out Vector HitLocation,out Vector HitNormal,Vector TraceEnd,Vector TraceStart,optional Vector Extent);
final native(548) function bool FastTrace(Vector TraceEnd,optional Vector TraceStart);
final native(277) function Actor Trace(out Vector HitLocation,out Vector HitNormal,Vector TraceEnd,optional Vector TraceStart,optional bool bTraceActors,optional Vector Extent,optional out Material Material);
function bool HealDamage(int Amount,Controller Healer,class<DamageType> DamageType);
event TakeDamage(int Damage,Pawn EventInstigator,Vector HitLocation,Vector Momentum,class<DamageType> DamageType);
event KilledBy(Pawn EventInstigator);
simulated event FellOutOfWorld(byte KillType) {
SetPhysics(0);                                                              
Destroy();                                                                  
}
event UsedBy(Pawn User);
event EndedRotation();
event FinishedInterpolation() {
bInterpolating = False;                                                     
}
event RanInto(Actor Other);
event EncroachedBy(Actor Other);
event bool EncroachingOn(Actor Other);
event Actor SpecialHandling(Pawn Other);
event Detach(Actor Other);
event Attach(Actor Other);
event BaseChange();
event Bump(Actor Other);
event UnTouch(Actor Other);
event PostTouch(Actor Other);
event Touch(Actor Other);
event PhysicsVolumeChange(PhysicsVolume NewVolume);
event ZoneChange(ZoneInfo NewZone);
event Landed(Vector HitNormal);
event Falling();
event HitWall(Vector HitNormal,Actor HitWall);
event Timer();
simulated function TimerPop(VolumeTimer t);
event EndEvent();
event BeginEvent();
event UnTrigger(Actor Other,Pawn EventInstigator);
event Trigger(Actor Other,Pawn EventInstigator);
event PostNetReceive();
event Tick(float DeltaTime);
event LostChild(Actor Other);
event GainedChild(Actor Other);
event Destroyed();
final native event float GetAllowedAudioRepeatTime(int aSoundType);
final native event NotifySoundStopped(Sound aSoundStopped);
final native function StopAllMusic(optional float FadeOutTime);
final native function StopMusic(int SongHandle,optional float FadeOutTime);
final native function int PlayMusic(string Song,optional float FadeInTime);
final native function bool PauseStream(int Handle);
final native function bool AdjustVolume(int Handle,float NewVolume);
final native function int SeekStream(int Handle,float Seconds);
final native function StopStream(int Handle,optional float FadeOutTime);
final native function int PlayStream(string Song,optional bool UseMusicVolume,optional float Volume,optional float FadeInTime,optional float SeekTime);
final native function AllowMusicPlayback(bool Allow);
final native function UnClock(out float Time);
final native function Clock(out float Time);
final native function OnlyAffectPawns(bool B);
final native(3970) function SetPhysics(byte newPhysics);
final native(301) latent function FinishInterpolation();
final native function DebugUnclock();
final native function DebugClock();
final native function ClearStayingDebugLines();
final native function DrawDebugCapsule(Vector Base,float AxisLength,float Radius,byte R,byte G,byte B);
final native function DrawDebugSphere(Vector Base,float Radius,int NumDivisions,byte R,byte G,byte B);
final native function DrawDebugCircle(Vector Base,Vector X,Vector Y,float Radius,int NumSides,byte R,byte G,byte B);
final native function DrawStayingDebugLine(Vector LineStart,Vector LineEnd,byte R,byte G,byte B);
final native function DrawDebugLine(Vector LineStart,Vector LineEnd,byte R,byte G,byte B);
final native function Plane GetRenderBoundingSphere();
final native function string GetUrlOption(string Option);
final native function UpdateURL(string NewOption,string NewValue,bool bSaveDefault);
final native function name GetClosestBone(Vector loc,Vector ray,out float boneDist,optional name BiasBone,optional float BiasDistance);
final native function bool AnimIsInGroup(int Channel,name GroupName);
final native function GetAnimParams(int Channel,out name OutSeqName,out float OutAnimFrame,out float OutAnimRate);
final native function SetBoneRotation(name BoneName,optional Rotator BoneTurn,optional int Space,optional float Alpha);
final native function SetBoneLocation(name BoneName,optional Vector BoneTrans,optional float Alpha);
final native function SetBoneDirection(name BoneName,Rotator BoneTurn,optional Vector BoneTrans,optional float Alpha,optional int Space);
final native function SetBoneScale(int Slot,optional float BoneScale,optional name BoneName);
final native function LockRootMotion(int Lock);
final native function Actor FindAttachment(name ActorName,name BoneName);
final native function bool DetachFromBone(Actor Attachment);
final native function bool AttachToBone(Actor Attachment,name BoneName);
final native function Rotator GetRootRotationDelta();
final native function Vector GetRootLocationDelta();
final native function Rotator GetRootRotation();
final native function Vector GetRootLocation();
final native function Rotator GetBoneRotation(name BoneName,optional int Space);
final native function Coords GetBoneCoords(name BoneName);
final native function AnimBlendToAlpha(int Stage,float TargetAlpha,float TimeInterval);
final native function AnimBlendParams(int Stage,optional float BlendAlpha,optional float InTime,optional float OutTime,optional name BoneName,optional bool bGlobalPose);
final native function BoneRefresh();
final native function LinkMesh(Mesh NewMesh,optional bool bKeepAnim);
final native function LinkSkelAnim(MeshAnimation Anim,optional Mesh NewMesh);
final native function int GetNotifyChannel();
final native function EnableChannelNotify(int Channel,int Switch);
event AnimEnd(int Channel);
event LIPSincAnimEnd();
final native function string CurrentLIPSincAnim();
final native function bool IsPlayingLIPSincAnim();
final native function bool HasLIPSincAnim(name LIPSincAnimName);
final native function StopLIPSincAnim();
final native function PlayLIPSincAnim(name LIPSincAnimName,optional float Volume,optional float Radius,optional float Pitch);
final native function AnimStopLooping(optional int Channel);
final native function bool IsTweening(int Channel);
final native function SetAnimFrame(float Time,optional int Channel,optional int UnitFlag);
final native function FreezeAnimAt(float Time,optional int Channel);
final native function StopAnimating(optional bool ClearAllButBase);
final native(263) function bool HasAnim(name Sequence);
final native(261) latent function FinishAnim(optional int Channel);
final native(282) function bool IsAnimating(optional int Channel);
final native(294) function bool TweenAnim(name Sequence,float Time,optional int Channel);
final native(260) function bool LoopAnim(name Sequence,optional float Rate,optional float TweenTime,optional int Channel);
final native(259) function bool PlayAnim(name Sequence,optional float Rate,optional float TweenTime,optional int Channel);
final native function string GetMeshName();
native function bool IsBehind(Actor Other,optional int MinYaw,optional int MaxYaw);
final native function bool IsJoinedTo(Actor Other);
final native(272) function SetOwner(Actor NewOwner);
final native(298) function SetBase(Actor NewBase,optional Vector NewFloor);
native function bool IsGrounded();
native function MoveNoChecks(Vector DeltaLocation);
final native(3971) function AutonomousPhysics(float DeltaSeconds);
final native(3969) function bool MoveSmooth(Vector delta);
final native function bool SetRelativeLocation(Vector NewLocation);
final native function bool SetRelativeRotation(Rotator NewRotation);
final native event bool SetRotation(Rotator NewRotation);
final native(267) function bool SetLocation(Vector NewLocation);
final native(266) function bool Move(Vector delta);
final native function SetSkeletalMesh(Mesh NewSkeletalMesh);
final native function SetDrawType(byte NewDrawType);
final native function SetStaticMesh(StaticMesh NewStaticMesh);
final native function SetDrawScale3D(Vector NewScale3D);
final native function SetDrawScale(float NewScale);
final native(283) function bool SetCollisionSize(float NewRadius,float NewHeight);
final native(262) function SetCollision(optional bool NewColActors,optional bool NewBlockActors);
final native function EndLatentFunction();
final native(256) latent function Sleep(float Seconds);
final static native function bool ShouldBeHidden();
final native(233) function Error(coerce string s);
native function SetAmbientGlow(int aNewGlow);
native function TextToSpeech(string Text,float Volume);
native function CopyObjectToClipboard(Object Obj);
native function string ConsoleCommand(string Command,optional bool bWriteToLog);
function bool IsValidActor() {
return True;                                                                
}
event bool ShouldTickPhysics() {
return True;                                                                
}
event OnCreateComponents();
event cl_OnGroupChange(int newGroupFlags);
event cl_OnUpdate();
event cl_OnBaseline();
event cl_OnTick(float delta);
final static native function GameEngine GetGameEngine();
final native(265) function TickStatsGroup();
final native(268) function InitStatsGroup();
*/