﻿using System;
using Engine;
using SBBase;
using UnityEngine;

namespace SBGame
{
    [Serializable] public class Game_PlayerInput : Base_Component
    {
        public const int GPI_MOUSEMODIFIER3 = 2;

        public const int GPI_MOUSEMODIFIER2 = 1;

        public const int GPI_MOUSEMODIFIER1 = 0;

        public const int GPI_RIGHTMOUSEBUTTON = 2;

        public const int GPI_MIDDLEMOUSEBUTTON = 1;

        public const int GPI_LEFTMOUSEBUTTON = 0;

        public bool mViewOverrideReceived;

        private Vector mLastForceLocation;

        private Actor mActorUnderMouse;

        private Game_Pawn mPawnUnderReticule;

        private byte mOutOfRangeState;

        private byte mSkillStartFailure;

        private bool mTargetLocationValid;

        private Vector mTargetLocation;

        private Actor mTargetActor;

        private Game_Pawn mTargetPawn;

        private Game_Pawn mLastReplicatedTargetPawn;

        private string mTargetProjector; //Game_TargetProjector

        private string mSelectionCircle; //Game_SelectionCircle

        private bool mMouseWalking;

        private bool mLeftMouseLooking;

        public Rotator ViewRotation;

        public bool mAutoRun;

        [ArraySizeForExtraction(Size = 16)]
        public int[] mBindings = new int[0];

        [ArraySizeForExtraction(Size = 3)]
        public int[] mMouseModifiers = new int[0];

        [ArraySizeForExtraction(Size = 3)]
        public float[] mLastClickTime = new float[0];

        public float mMaxDoubleClickTime;

        public int SelectedSkillIndex;

        public bool AutoSelectSkill;

        public int PreviousSkillIndex;

        public FSkill_Type mPreparedSkill;

        public bool ShowSelectionCircle;

        private bool mForwardPressed;

        private bool mBackwardPressed;

        private bool mPreviousForwardPressed;

        private bool mPreviousBackwardPressed;

        private bool mLeftPressed;

        private bool mRightPressed;

        private bool mRotateLeftPressed;

        private bool mRotateRightPressed;

        private bool mJumpPressed;

        [NonSerialized, HideInInspector]
        [FieldTransient()]
        private bool mJumpJustPressed;

        private bool mDodging;

        private bool mLeftMouseDown;

        private bool mRightMouseDown;

        private bool mMiddleMouseDown;

        [FieldConfig()]
        public float mKeyboardRotateSpeed;

        private float cCooldown;

        private float mDrawSheatheCooldown;

        public Rotator ClientDirection;

        [NonSerialized, HideInInspector]
        [FieldTransient()]
        private int mForwardCount;

        [NonSerialized, HideInInspector]
        [FieldTransient()]
        private int mSideCount;

        [NonSerialized, HideInInspector]
        [FieldTransient()]
        private bool mJumped;

        [FieldConfig()]
        public float mMouseLookModeMouseSensitivity;

        [FieldConfig()]
        public float mCursorModeMouseSensitivity;

        public bool mIgnoreTrace;

        public bool SkillsEnabled;

        public bool IsDrawingWeapon;

        //public delegate<OnActivateSkillFailed> @__OnActivateSkillFailed__Delegate;

        public Game_PlayerInput()
        {
        }

        public enum EOutOfRangeState
        {
            OORS_InRange,

            OORS_TooFar,

            OORS_TooClose,
        }
    }
}
/*
private final function bool IsScreenshotMode() {
return Outer.Player.InteractionMaster.ScreenshotMode == 2;                  
}
private final function bool IsDoubleClick(int Button) {
if (Button < 3) {                                                           
if (Outer.Level != None) {                                                
if (mLastClickTime[Button] > 0
&& mLastClickTime[Button] + mMaxDoubleClickTime >= Outer.Level.TimeSeconds) {
mLastClickTime[Button] = 0.00000000;                                  
return True;                                                          
}
mLastClickTime[Button] = Outer.Level.TimeSeconds;                       
}
}
return False;                                                               
}
final function bool IsModifierDown(int aModifier) {
return mMouseModifiers[aModifier] == 1;                                     
}
private final function bool IsCombatReady() {
local Game_PlayerPawn Pawn;
Pawn = Game_PlayerPawn(Outer.Pawn);                                         
return Pawn != None && Pawn.combatState != None
&& Pawn.combatState.CombatReady();
}
private final function Game_Camera GetCamera() {
if (Outer != None && Outer.Camera != None) {                                
return Outer.Camera;                                                      
}
return None;                                                                
}
private final function GUI_BaseDesktop GetDesktop() {
local Game_PlayerController GPC;
GPC = Outer;                                                                
if (GPC == None || GPC.Player == None
|| GPC.Player.GUIDesktop == None) {
return None;                                                              
} else {                                                                    
return GPC.Player.GUIDesktop;                                             
}
}
final event CancelAction() {
}
exec function MouseModifier3(bool keyDown) {
mMouseModifiers[2] = keyDown;                                               
}
exec function MouseModifier2(bool keyDown) {
mMouseModifiers[1] = keyDown;                                               
}
exec function MouseModifier1(bool keyDown) {
mMouseModifiers[0] = keyDown;                                               
}
exec function WheelDownBinding() {
if (IsCombatReady()) {                                                      
if (IsModifierDown(0)) {                                                  
GetCamera().ZoomOut();                                                  
} else {                                                                  
SelectPreviousSkill();                                                  
}
} else {                                                                    
GetCamera().ZoomOut();                                                    
}
}
exec function WheelUpBinding() {
if (IsCombatReady()) {                                                      
if (IsModifierDown(0)) {                                                  
GetCamera().ZoomIn();                                                   
} else {                                                                  
SelectNextSkill();                                                      
}
} else {                                                                    
GetCamera().ZoomIn();                                                     
}
}
private function SetMouseLookMode(bool mouseDown) {
local GUI_BaseDesktop desktop;
desktop = GetDesktop();                                                     
if (desktop == None) {                                                      
return;                                                                   
}
if (desktop.IsActive()) {                                                   
if (mouseDown) {                                                          
cl_SetMouseLookMode(True);                                              
} else {                                                                  
if (desktop.IsTempActive()) {                                           
desktop.SetTempInactive(False);                                       
}
}
} else {                                                                    
if (desktop.IsTempInactive()) {                                           
if (!mouseDown) {                                                       
cl_SetMouseLookMode(False);                                           
}
}
}
}
exec function MiddleMouseBinding(bool mouseDown) {
if (!mAutoRun && mouseDown && IsDoubleClick(1)) {                           
cl_SetAutoRun(True);                                                      
mMiddleMouseDown = False;                                                 
} else {                                                                    
mMiddleMouseDown = mouseDown;                                             
}
SetMouseLookMode(mouseDown);                                                
}
exec function RightMouseBinding(bool mouseDown) {
local bool isInteractionPossible;
local GUI_BaseDesktop desktop;
desktop = GetDesktop();                                                     
if (desktop == None) {                                                      
return;                                                                   
}
isInteractionPossible = desktop.IsRadialInteractionPossible();              
if (desktop.IsActive()) {                                                   
if (!desktop.HasHiliteComponent()) {                                      
if (!isInteractionPossible) {                                           
Outer.GUI.CloseRadialMenu();                                          
if (mouseDown && IsDoubleClick(2)) {                                  
ToggleMouseLookMode();                                              
} else {                                                              
SetMouseLookMode(mouseDown);                                        
}
} else {                                                                
if (mouseDown) {                                                      
cl_SelectTargetUnderMouse();                                        
Outer.GUI.OpenRadialMenu();                                         
}
}
}
} else {                                                                    
if (mouseDown && !mRightMouseDown && isInteractionPossible) {             
cl_SelectTargetUnderMouse();                                            
Outer.GUI.OpenRadialMenu();                                             
} else {                                                                  
if (mouseDown && IsDoubleClick(2)) {                                    
ToggleMouseLookMode();                                                
} else {                                                                
SetMouseLookMode(mouseDown);                                          
}
}
}
mRightMouseDown = mouseDown;                                                
}
exec function LeftMouseBinding(bool mouseDown) {
local GUI_BaseDesktop desktop;
desktop = GetDesktop();                                                     
if (desktop == None) {                                                      
return;                                                                   
}
if (mouseDown) {                                                            
if (IsCombatReady()) {                                                    
if (!desktop.IsActive()) {                                              
if (!IsModifierDown(0) || !cl_SelectTargetUnderMouse()) {             
ActivateSelectedSkill();                                            
}
} else {                                                                
if (mTargetPawn != None
&& mTargetPawn == mPawnUnderReticule) {
ActivateSelectedSkill();                                            
} else {                                                              
cl_SelectTargetUnderMouse();                                        
}
}
} else {                                                                  
if (cl_SelectTargetUnderMouse()) {                                      
return;                                                               
}
}
}
if (mouseDown && !mRightMouseDown
&& (!IsCombatReady() || !desktop.IsActive())
&& desktop.IsMouseInsideWindow()) {
SetMouseLookMode(True);                                                   
mLeftMouseLooking = True;                                                 
} else {                                                                    
if (mLeftMouseLooking) {                                                  
mLeftMouseLooking = False;                                              
SetMouseLookMode(False);                                                
}
}
mLeftMouseDown = mouseDown;                                                 
}
exec function cl_NextTab() {
Outer.Player.GUIDesktop.NextTabStop();                                      
}
function cl_SetMouseLookMode(bool aIsPressed) {
local GUI_BaseDesktop desktop;
desktop = GetDesktop();                                                     
if (desktop != None) {                                                      
if (aIsPressed) {                                                         
if (!desktop.IsTempActive() && !desktop.IsTempInactive()) {             
if (desktop.IsActive()) {                                             
desktop.SetTempInactive(True);                                      
} else {                                                              
desktop.SetTempActive(True);                                        
}
}
} else {                                                                  
if (desktop.IsTempActive() || desktop.IsTempInactive()) {               
if (desktop.IsActive()) {                                             
desktop.SetTempActive(False);                                       
} else {                                                              
desktop.SetTempInactive(False);                                     
}
}
}
}
}
exec function ToggleMouseLookMode() {
GetDesktop().ToggleActive();                                                
}
exec function Rest() {
local Game_PlayerController PlayerController;
local Game_Pawn Pawn;
local bool ignoreVelocity;
PlayerController = Outer;                                                   
if (PlayerController != None) {                                             
Pawn = Game_Pawn(PlayerController.Pawn);                                  
if (Pawn != None && !Pawn.IsDead()) {                                     
if (Pawn.bCanRest) {                                                    
switch (Pawn.Physics) {                                               
case 1 :                                                            
case 19 :                                                           
case 20 :                                                           
ignoreVelocity = mAutoRun
&& !(mLeftPressed || mRightPressed);
Pawn.cl2sv_Rest_CallStub(ignoreVelocity);                         
if (ignoreVelocity) {                                             
cl_SetAutoRun(False);                                           
}
break;                                                            
default:                                                            
}
}
}
}
}
function EnableSkills(bool aSetting) {
if (SkillsEnabled != aSetting) {                                            
SkillsEnabled = aSetting;                                                 
if (SkillsEnabled && AutoSelectSkill) {                                   
SelectedSkillIndex = PreviousSkillIndex;                                
if (SelectedSkillIndex == -1) {                                         
SelectedSkillIndex = 0;                                               
}
SelectSkillSlot(SelectedSkillIndex);                                    
} else {                                                                  
PreviousSkillIndex = SelectedSkillIndex;                                
SelectedSkillIndex = -1;                                                
}
}
}
function AutoTarget(Game_Pawn aTargetPawn) {
if (aTargetPawn != None
&& (mTargetPawn == None || mTargetPawn.IsDead())) {
cl_SetTargetActor(aTargetPawn);                                           
}
}
exec function bool ActivateSelectedSkill() {
local Game_Pawn gamePawn;
local export editinline FSkill_Type selectedSkillType;
local AimingInfo AimingInfo;
local Game_PlayerController GPC;
local Vector targetVec;
gamePawn = Game_Pawn(Outer.Pawn);                                           
selectedSkillType = gamePawn.Skills.GetActiveTierSlotSkill(SelectedSkillIndex);
if (selectedSkillType != None) {                                            
Game_Pawn(Outer.Pawn).Skills.CanActivateSpecificSkill(selectedSkillType,True);
}
if (SkillsEnabled && SelectedSkillIndex != -1) {                            
if (selectedSkillType != None) {                                          
GPC = Outer;                                                            
if (GPC != None) {                                                      
AimingInfo.CameraLocation = GPC.CalcViewLocation;                     
AimingInfo.CameraRotation = GPC.CalcViewRotation;                     
AimingInfo.TriggerTime = GPC.ServerTime;                              
} else {                                                                
AimingInfo.CameraLocation = vect(0.000000, 0.000000, 0.000000);       
AimingInfo.CameraRotation = rot(0, 0, 0);                             
AimingInfo.TriggerTime = -1.00000000;                                 
}
AimingInfo.PreferredTarget = mPawnUnderReticule;                        
if (selectedSkillType.PaintLocation) {                                  
if (mOutOfRangeState != 0) {                                          
Game_PlayerSkills(gamePawn.Skills).ReportError(selectedSkillType,10);
} else {                                                              
if (mTargetLocationValid) {                                         
if (mPawnUnderReticule != None) {                                 
targetVec = mPawnUnderReticule.Location;                        
targetVec.Z -= mPawnUnderReticule.CollisionHeight;              
AutoTarget(mPawnUnderReticule);                                 
} else {                                                          
targetVec = mTargetLocation;                                    
}
gamePawn.Skills.ExecuteIndexL(SelectedSkillIndex,targetVec,AimingInfo);
mPreparedSkill = None;                                            
return True;                                                      
}
}
} else {                                                                
gamePawn.Skills.ExecuteIndex(SelectedSkillIndex,AimingInfo);          
mPreparedSkill = None;                                                
AutoTarget(mPawnUnderReticule);                                       
return True;                                                          
}
}
}
OnActivateSkillFailed();                                                    
return False;                                                               
}
exec function ReleaseKeybinding(int Index,string execCommand) {
if (mBindings[Index] == 1) {                                                
mBindings[Index] = 0;                                                     
if (Len(execCommand) > 0) {                                               
Outer.Player.GUIDesktop.ConsoleCommand(execCommand);                    
}
}
}
exec function SetKeybinding(int Index,string execCommand) {
if (mBindings[Index] == 0) {                                                
mBindings[Index] = 1;                                                     
if (Len(execCommand) > 0) {                                               
Outer.Player.GUIDesktop.ConsoleCommand(execCommand);                    
}
}
}
exec function SelectNearestEnemy() {
}
native exec function SelectNextEnemy();
exec function SelectAndExecuteSkill(int aSelectedSkillIndex) {
if (aSelectedSkillIndex < Game_Pawn(Outer.Pawn).Skills.GetSkilldeckColumnCount()) {
mPreparedSkill = SelectSkillSlot(aSelectedSkillIndex);                    
if (mPreparedSkill != None) {                                             
ActivateSelectedSkill();                                                
}
}
}
exec function SelectOrExecuteSkill(int aSelectedSkillIndex) {
if (SkillsEnabled) {                                                        
if (SelectedSkillIndex != aSelectedSkillIndex) {                          
if (aSelectedSkillIndex < Game_Pawn(Outer.Pawn).Skills.GetSkilldeckColumnCount()) {
mPreparedSkill = SelectSkillSlot(aSelectedSkillIndex);                
}
} else {                                                                  
ActivateSelectedSkill();                                                
}
}
}
exec function SelectPreviousSkill() {
if (SelectedSkillIndex < 0) {                                               
SelectSkillSlot(4);                                                       
}
if (SelectedSkillIndex >= 1) {                                              
SelectSkillSlot(SelectedSkillIndex - 1);                                  
}
}
exec function SelectNextSkill() {
local Game_PlayerPawn playerPawn;
playerPawn = Game_PlayerPawn(Outer.Pawn);                                   
if (playerPawn != None && playerPawn.Skills != None) {                      
if (SelectedSkillIndex < 4
&& SelectedSkillIndex < playerPawn.Skills.GetSkilldeckColumnCount() - 1) {
SelectSkillSlot(SelectedSkillIndex + 1);                                
}
}
}
exec function FSkill_Type SelectSkillSlot(int aSelectedSkillIndex) {
local Game_PlayerPawn gamePlayerPawn;
local export editinline FSkill_Type selectedSkillType;
if (SkillsEnabled) {                                                        
gamePlayerPawn = Game_PlayerPawn(Outer.Pawn);                             
if (gamePlayerPawn == None || gamePlayerPawn.Skills == None) {            
return None;                                                            
}
if (aSelectedSkillIndex < 0
|| aSelectedSkillIndex >= gamePlayerPawn.Skills.GetSkilldeckColumnCount()) {
aSelectedSkillIndex = -1;                                               
}
if (aSelectedSkillIndex != SelectedSkillIndex) {                          
SelectedSkillIndex = aSelectedSkillIndex;                               
}
if (SelectedSkillIndex >= 0) {                                            
selectedSkillType = gamePlayerPawn.Skills.GetActiveTierSlotSkill(SelectedSkillIndex);
Game_PlayerCombatState(gamePlayerPawn.combatState).cl2sv_SwitchWeaponType_CallStub(selectedSkillType.RequiredWeapon);
return selectedSkillType;                                               
}
}
return None;                                                                
}
event cl_OnUpdateSelectionCircle(float aDeltaTime) {
if (mSelectionCircle != None) {                                             
mSelectionCircle.cl_UpdateLocation(aDeltaTime);                           
}
}
event sv_PlayerInput(float DeltaSeconds) {
}
event cl_PlayerInput(Game_PlayerController aController,float DeltaSeconds) {
if (aController != None) {                                                  
if (aController.PlayerInput.bInvertMouse) {                               
aController.aLookUp -= aController.aMouseY;                             
} else {                                                                  
aController.aLookUp += aController.aMouseY;                             
}
}
}
event FocusChanged(bool aHasFocus) {
if (!aHasFocus) {                                                           
ResetInput();                                                             
if (mLeftMouseDown) {                                                     
LeftMouseBinding(False);                                                
}
if (mRightMouseDown) {                                                    
RightMouseBinding(False);                                               
}
if (mMiddleMouseDown) {                                                   
MiddleMouseBinding(False);                                              
}
}
}
event ResetInput() {
mJumpPressed = False;                                                       
mForwardCount = 0;                                                          
mSideCount = 0;                                                             
mDodging = False;                                                           
}
protected final native function SampleMoveCommands(float aDeltaTime);
private final function UpdateFreeCam() {
local Game_PlayerController GPC;
local bool useFreeCam;
GPC = Outer;                                                                
if (GPC != None) {                                                          
useFreeCam = !GetDesktop().IsActive()
&& (mLeftMouseDown && !mRightMouseDown
&& !IsCombatReady()
|| GPC.IsSitting()
|| GPC.Pawn.Physics == 11
|| IsModifierDown(0)
&& (mRightMouseDown || mMiddleMouseDown)
|| Game_Pawn(GPC.Pawn).CharacterStats.IsMovementFrozen()
&& !IsCombatReady());
if (!useFreeCam && GPC.bFreeCam && !mRightMouseDown
&& VSize(GPC.Pawn.Velocity) == 0) {
useFreeCam = True;                                                      
}
GetCamera().SetFreeCam(useFreeCam);                                       
}
}
function UpdateMouseWalking() {
if (!mMouseWalking && mForwardPressed) {                                    
return;                                                                   
}
if (mMiddleMouseDown
|| mLeftMouseDown && mRightMouseDown
&& !IsCombatReady()
&& (mMouseWalking
|| !GetDesktop().IsRadialInteractionPossible())) {
GoForward(True);                                                          
mMouseWalking = True;                                                     
} else {                                                                    
if (mMouseWalking) {                                                      
GoForward(False);                                                       
mMouseWalking = False;                                                  
}
}
}
event cl_OnPlayerTick(float DeltaTime) {
local Game_PlayerController GPC;
local Game_Pawn gamePawn;
GPC = Outer;                                                                
if (GPC != None) {                                                          
UpdateMouseWalking();                                                     
UpdateFreeCam();                                                          
cl_PlayerInput(GPC,DeltaTime);                                            
GPC.UpdateRotation(DeltaTime,2.00000000);                                 
gamePawn = Game_Pawn(GPC.Pawn);                                           
if (gamePawn != None) {                                                   
cl_UpdateTargetProjectorAndReticule();                                  
if (mSelectionCircle != None) {                                         
mSelectionCircle.cl_OnPlayerTick(DeltaTime);                          
}
}
if (!GPC.IsViewingCinematic()) {                                          
UpdateViewRotation();                                                   
SampleMoveCommands(DeltaTime);                                          
} else {                                                                  
cl2sv_SetViewTarget_CallStub(GPC.ViewTarget.Location);                  
ResetInput();                                                           
}
}
if (Game_Pawn(mTargetActor) == None
|| !mTargetActor.IsValidActor()
|| mTargetPawn.Physics == 21) {
cl_SetTargetActor(None);                                                  
}
if (mDrawSheatheCooldown > 0.00000000) {                                    
mDrawSheatheCooldown -= DeltaTime;                                        
}
}
protected native function cl2sv_SetViewTarget_CallStub();
event cl2sv_SetViewTarget(Vector aViewTarget) {
Outer.SetLocation(aViewTarget);                                             
Outer.sv_OnSetViewTarget();                                                 
}
exec function cl_SetAutoRun(bool B) {
mAutoRun = B;                                                               
}
exec function ToggleAutoRun() {
mAutoRun = !mAutoRun;                                                       
}
exec function Jump(bool aJump) {
if (aJump) {                                                                
if (!mJumpJustPressed
&& (Outer.Pawn.IsGrounded() || Outer.Pawn.Physics == 11)) {
mJumpJustPressed = True;                                                
mJumpPressed = True;                                                    
}
} else {                                                                    
mJumpJustPressed = False;                                                 
mJumpPressed = False;                                                     
}
}
final exec function GoRight(bool B) {
if (Outer.Pawn.Physics == 4 && B == False) {                                
Outer.Pawn.Velocity = vect(0.000000, 0.000000, 0.000000);                 
}
mRightPressed = B;                                                          
}
final exec function GoLeft(bool B) {
if (Outer.Pawn.Physics == 4 && B == False) {                                
Outer.Pawn.Velocity = vect(0.000000, 0.000000, 0.000000);                 
}
mLeftPressed = B;                                                           
}
final exec function GoBackward(bool B) {
if (Outer.Pawn.Physics == 4 && B == False) {                                
Outer.Pawn.Velocity = vect(0.000000, 0.000000, 0.000000);                 
}
if (mAutoRun && B && !mPreviousBackwardPressed) {                           
mAutoRun = False;                                                         
}
mBackwardPressed = B;                                                       
mPreviousBackwardPressed = B;                                               
}
final exec function GoForward(bool B) {
if (Outer.Pawn.Physics == 4 && B == False) {                                
Outer.Pawn.Velocity = vect(0.000000, 0.000000, 0.000000);                 
}
if (mAutoRun && B && !mPreviousForwardPressed) {                            
mAutoRun = False;                                                         
}
mForwardPressed = B;                                                        
mPreviousForwardPressed = B;                                                
}
final exec function RotateRight(bool B) {
if (Outer != None && !Outer.IsViewingCinematic()) {                         
Outer.aTurn += FClamp(mKeyboardRotateSpeed,0.50000000,5.00000000);        
}
mRotateRightPressed = B;                                                    
}
final exec function RotateLeft(bool B) {
if (Outer != None && !Outer.IsViewingCinematic()) {                         
Outer.aTurn -= FClamp(mKeyboardRotateSpeed,0.50000000,5.00000000);        
}
mRotateLeftPressed = B;                                                     
}
exec function DrawSheatheWeapon() {
local Game_PlayerPawn gamePlayerPawn;
local export editinline FSkill_Type selectedSkillType;
local byte combatMode;
gamePlayerPawn = Game_PlayerPawn(Outer.Pawn);                               
if (gamePlayerPawn == None) {                                               
return;                                                                   
}
if (gamePlayerPawn.IsDead()) {                                              
return;                                                                   
}
if (gamePlayerPawn.mPvPSettings != None
&& !gamePlayerPawn.mPvPSettings.AllowDrawWeapon
|| gamePlayerPawn.Physics == 11) {
gamePlayerPawn.SendDesktopMessage("",Class'StringReferences'.default.Cannot_draw_weapon_here.Text,Class'Game_Desktop'.7);
return;                                                                   
}
if (gamePlayerPawn.MiniGameProxy != None
&& gamePlayerPawn.MiniGameProxy.IsPlaying()) {
return;                                                                   
}
if (gamePlayerPawn.IsShifted()) {                                           
return;                                                                   
}
if (gamePlayerPawn.IsInShop()) {                                            
return;                                                                   
}
if (mDrawSheatheCooldown <= 0.00000000) {                                   
IsDrawingWeapon = !IsDrawingWeapon;                                       
if (PreviousSkillIndex >= 0) {                                            
selectedSkillType = gamePlayerPawn.Skills.GetActiveTierSlotSkill(PreviousSkillIndex);
switch (selectedSkillType.RequiredWeapon) {                             
case 1 :                                                              
combatMode = 1;                                                     
break;                                                              
case 2 :                                                              
combatMode = 2;                                                     
break;                                                              
default:                                                              
combatMode = 3;                                                     
break;                                                              
}
} else {                                                                  
combatMode = 1;                                                         
}
Game_PlayerCombatState(gamePlayerPawn.combatState).cl2sv_DrawSheatheWeapon_CallStub(combatMode);
mDrawSheatheCooldown = cCooldown;                                         
}
}
function cl_UpdateTargetProjectorAndReticule() {
local export editinline FSkill_Type selectedSkill;
local Vector targetingVector;
local float Distance;
local float MinDistance;
local float MaxDistance;
local float paintRadius;
local Game_Pawn gamePawn;
gamePawn = Game_Pawn(Outer.Pawn);                                           
if (mTargetProjector == None) {                                             
mTargetProjector = gamePawn.Spawn(Class'Game_TargetProjector',Outer);     
mTargetProjector.SetIsVisible(False);                                     
}
selectedSkill = cl_GetSelectedSkill();                                      
mSkillStartFailure = gamePawn.Skills.CanActivateSpecificSkill(selectedSkill);
if (selectedSkill != None && mSkillStartFailure == 0) {                     
if (selectedSkill.PaintLocation) {                                        
MinDistance = gamePawn.Skills.sv_GetTokenEffect(selectedSkill,2,selectedSkill.PaintLocationMinDistance);
MaxDistance = gamePawn.Skills.sv_GetTokenEffect(selectedSkill,3,selectedSkill.PaintLocationMaxDistance);
paintRadius = gamePawn.Skills.sv_GetTokenEffect(selectedSkill,4,selectedSkill.GetTargetMaxRange(gamePawn));
if (mPawnUnderReticule != None) {                                       
mTargetLocation = mPawnUnderReticule.Location;                        
}
if (mTargetProjector != None) {                                         
if (!IsScreenshotMode()) {                                            
mTargetProjector.SetIsVisible(True);                                
mTargetProjector.ProjectOnToLocation(mTargetLocation,gamePawn.Location,paintRadius);
} else {                                                              
mTargetProjector.SetIsVisible(False);                               
}
}
} else {                                                                  
MinDistance = selectedSkill.MinDistance;                                
MaxDistance = gamePawn.Skills.sv_GetTokenEffect(selectedSkill,4,selectedSkill.MaxDistance);
paintRadius = 0.00000000;                                               
if (mTargetProjector != None) {                                         
mTargetProjector.SetIsVisible(False);                                 
}
}
if (MinDistance >= MaxDistance) {                                         
MinDistance = 0.00000000;                                               
MaxDistance = 10000.00000000;                                           
}
mOutOfRangeState = 0;                                                     
if (mPawnUnderReticule != None || selectedSkill.PaintLocation) {          
targetingVector = mTargetLocation - Outer.Pawn.Location;                
Distance = VSize(targetingVector);                                      
if (selectedSkill.PaintLocation) {                                      
if (Distance > MaxDistance) {                                         
mOutOfRangeState = 1;                                               
} else {                                                              
if (Distance < MinDistance) {                                       
mOutOfRangeState = 2;                                             
}
}
} else {                                                                
if (Distance - mPawnUnderReticule.SkillRadius > MaxDistance) {        
mOutOfRangeState = 1;                                               
} else {                                                              
if (Distance + mPawnUnderReticule.SkillRadius < MinDistance) {      
mOutOfRangeState = 2;                                             
}
}
}
}
if (!IsPaintLocationWithinAngle(gamePawn.Location,Outer.Pawn.Rotation,90.00000000,mTargetLocation,paintRadius)) {
mOutOfRangeState = 1;                                                   
}
if (mLeftMouseDown && mOutOfRangeState == 0
&& !IsModifierDown(0)
&& IsCombatReady()
&& !GetDesktop().IsActive()) {
ActivateSelectedSkill();                                                
}
} else {                                                                    
mOutOfRangeState = 0;                                                     
if (mTargetProjector != None) {                                           
mTargetProjector.SetIsVisible(False);                                   
}
}
}
function bool IsPaintLocationWithinAngle(Vector pawnLocation,Rotator pawnRotation,float maxAngleInDegrees,Vector aPaintLocation,float aRadius) {
local float Yaw;
Yaw = static.ConvertURUToDegrees(pawnRotation.Yaw);                         
Yaw = Yaw % 360;                                                            
if (Yaw < 0) {                                                              
Yaw += 360;                                                               
}
return static.IsInAngle(maxAngleInDegrees,pawnLocation,Yaw,aPaintLocation,aRadius);
}
event FSkill_Type cl_GetSelectedSkill() {
local Game_Pawn gamePawn;
gamePawn = Game_Pawn(Outer.Pawn);                                           
if (!SkillsEnabled || SelectedSkillIndex == -1) {                           
return None;                                                              
}
return gamePawn.Skills.GetActiveTierSlotSkill(SelectedSkillIndex);          
}
event cl_EnableMouseTrace(bool aEnableFlag) {
mIgnoreTrace = !aEnableFlag;                                                
}
function cl_TraceMouseCursor(float aMouseX,float aMouseY,float aCenterX,float aCenterY,out Vector aHit,out Actor outActor) {
local Game_PlayerController GPC;
local Vector mouseLocation;
local Vector centerLocation;
local Vector norm;
local Vector mouseWorldVector;
local Vector centerWorldVector;
local Vector startTrace;
local Vector endTrace;
local float Distance;
local Actor centerActor;
local Game_Pawn newPawnUnderReticule;
Distance = 4096.00000000;                                                   
GPC = Outer;                                                                
if (GPC != None && GPC.Player != None) {                                    
if (aMouseX > 0 || aMouseY > 0) {                                         
mouseLocation.X = aMouseX;                                              
mouseLocation.Y = aMouseY;                                              
mouseLocation.Z = 0.00000000;                                           
}
mouseWorldVector = GPC.Player.LocalInteractions[0].ScreenToWorld(mouseLocation,GPC.CalcViewLocation,GPC.CalcViewRotation);
startTrace = GPC.CalcViewLocation + mouseWorldVector;                     
mouseWorldVector = Normal(mouseWorldVector);                              
endTrace = startTrace + mouseWorldVector * Distance;                      
outActor = GPC.Trace(aHit,norm,endTrace,startTrace,True);                 
if (IsCombatReady()) {                                                    
centerLocation.X = aCenterX;                                            
centerLocation.Y = aCenterY;                                            
centerLocation.Z = 0.00000000;                                          
centerWorldVector = GPC.Player.LocalInteractions[0].ScreenToWorld(centerLocation,GPC.CalcViewLocation,GPC.CalcViewRotation);
startTrace = GPC.CalcViewLocation + centerWorldVector;                  
centerWorldVector = Normal(centerWorldVector);                          
endTrace = startTrace + centerWorldVector * Distance;                   
centerActor = GPC.Trace(aHit,norm,endTrace,startTrace,True);            
} else {                                                                  
centerActor = None;                                                     
}
if (centerActor != None) {                                                
mTargetLocationValid = True;                                            
newPawnUnderReticule = Game_Pawn(centerActor);                          
} else {                                                                  
mTargetLocationValid = False;                                           
newPawnUnderReticule = None;                                            
}
if (newPawnUnderReticule != mPawnUnderReticule) {                         
if (mPawnUnderReticule != None) {                                       
mPawnUnderReticule.Effects.cl_SetTargetInteractionEffect(0);          
}
mPawnUnderReticule = newPawnUnderReticule;                              
if (mPawnUnderReticule != None) {                                       
mPawnUnderReticule.Effects.cl_SetTargetInteractionEffect(1);          
}
}
}
}
function cl_ResetMouseSelection() {
if (mActorUnderMouse != None) {                                             
mActorUnderMouse.cl_NotifyUnderCursor(False);                             
mActorUnderMouse = None;                                                  
}
}
function Game_Pawn sv_GetTargetPawn() {
return mTargetPawn;                                                         
}
event Game_Pawn cl_GetTargetPawn() {
return mTargetPawn;                                                         
}
event Actor cl_GetActorUnderMouse() {
return mActorUnderMouse;                                                    
}
function Actor cl_GetTargetActor() {
return mTargetActor;                                                        
}
protected native function cl2sv_SetTargetPawn_CallStub();
private event cl2sv_SetTargetPawn(Game_Pawn targetPawn) {
mTargetPawn = targetPawn;                                                   
}
event cl_SetTargetActor(Actor aTargetActor) {
if (Game_Pawn(mTargetActor) != None
&& (mTargetActor == None && aTargetActor == None
|| mTargetActor == aTargetActor && mTargetActor != None
&& mTargetActor.IsValidActor())) {
return;                                                                   
}
if (Outer.IsDead()) {                                                       
return;                                                                   
}
if (mTargetPawn != None) {                                                  
mTargetPawn.cl_NotifySelected(False);                                     
}
mTargetActor = aTargetActor;                                                
mTargetPawn = Game_Pawn(mTargetActor);                                      
if (mTargetPawn != None
&& Game_StatuePawn(mTargetPawn) != None) {    
if (Game_StatuePawn(mTargetPawn) != None) {                               
mTargetPawn = None;                                                     
}
}
if (mTargetPawn != None) {                                                  
mTargetPawn.cl_NotifySelected(True);                                      
}
if (ShowSelectionCircle && mSelectionCircle != None) {                      
mSelectionCircle.SetPawn(mTargetPawn);                                    
}
if (IsClient()) {                                                           
Outer.GUI.TargetActorChanged();                                           
}
}
event bool cl_SelectTargetUnderMouse() {
local Game_GameMasterController GMC;
cl_SetTargetActor(mActorUnderMouse);                                        
GMC = Game_GameMasterController(Outer);                                     
if (GMC == None) {                                                          
return False;                                                             
}
if (Pawn(mActorUnderMouse) != None) {                                       
GMC.SpwnieControl.SetTarget(Editor_Spwnie(mTargetActor));                 
return True;                                                              
} else {                                                                    
GMC.SpwnieControl.SetTarget(None);                                        
return False;                                                             
}
}
event cl_UpdateMousePosition(float aMouseX,float aMouseY,float aCenterX,float aCenterY) {
local Actor currentActorUnderMouse;
if (mIgnoreTrace) {                                                         
mActorUnderMouse = None;                                                  
return;                                                                   
}
currentActorUnderMouse = mActorUnderMouse;                                  
cl_TraceMouseCursor(aMouseX,aMouseY,aCenterX,aCenterY,mTargetLocation,mActorUnderMouse);
if (currentActorUnderMouse != None
&& mActorUnderMouse != currentActorUnderMouse) {
currentActorUnderMouse.cl_NotifyUnderCursor(False);                       
}
if (mActorUnderMouse != None) {                                             
mActorUnderMouse.cl_NotifyUnderCursor(GetDesktop().IsRadialInteractionPossible());
}
}
final event UpdateViewRotation() {
ViewRotation.Yaw = Outer.Pawn.Rotation.Yaw;                                 
ViewRotation.Pitch = Outer.CalcViewRotation.Pitch;                          
ViewRotation.Roll = 0;                                                      
}
event cl_OnInit() {
Super.cl_OnInit();                                                          
Outer.UnPressButtons();                                                     
if (mSelectionCircle == None) {                                             
mSelectionCircle = Outer.Spawn(Class'Game_SelectionCircle',Outer);        
}
UpdateViewRotation();                                                       
mAutoRun = False;                                                           
}
delegate OnActivateSkillFailed();
*/