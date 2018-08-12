﻿using System;
using SBBase;

namespace SBGame
{
#pragma warning disable 414   

    [Serializable] public class Game_Appearance : Base_Component
    {
        public const int RACE_DAEVIE = 1;

        public const int RACE_HUMAN = 0;

        public byte mRace;

        public byte mGender;

        public byte mBody;

        public byte mVoice;

        public float mScale;

        public int mStatue;

        public int mGhost;

        private int mErrors;

        private Game_Pawn mWorkPawn;

        public bool mClientInitialized;

        private string mVoicePackage = string.Empty;

        public Game_Appearance()
        {
        }

        public enum EPreviewCamera
        {
            PC_COMPLETE_FRONT,

            PC_COMPLETE_FRONT_2,

            PC_HEAD,

            PC_HEAD_CLOSEUP,

            PC_TATTOOS,
        }
    }
}
/*
protected native function string cl_GetHexAddress(Object aObject);
protected function cl_ConsoleMessage(string aString) {
PlayerController(Outer.Controller).Player.Console.Message(aString,0.00000000);
}
protected final native function bool ApplyToPawn(Game_Pawn aPawn);
native function GetPreviewCamera(byte aPreviewCamera,out Vector Translation,out Rotator Rotation);
function app(int A) {
if (A == 0) {                                                               
cl_ConsoleMessage("Current appearance overview:");                        
cl_ConsoleMessage("----------------------------");                        
cl_ConsoleMessage("Appearance == " $ cl_GetHexAddress(self));             
cl_ConsoleMessage("mClientInitialized == " $ string(mClientInitialized)); 
}
}
function Material GetAvatarTexture() {
return mAvatarTexture;                                                      
}
function SetAvatarTexture(Material aNewVal) {
mAvatarTexture = aNewVal;                                                   
}
function bool GetStatue() {
return mStatue > 0;                                                         
}
function SetStatue(bool aOn) {
if (aOn) {                                                                  
mStatue++;                                                                
} else {                                                                    
mStatue--;                                                                
}
}
function bool GetGhost() {
return mGhost > 0;                                                          
}
function SetGhost(bool aOn) {
if (aOn) {                                                                  
mGhost++;                                                                 
} else {                                                                    
if (mGhost <= 0) {                                                        
}
mGhost--;                                                                 
}
}
function float GetScale() {
return mScale;                                                              
}
function byte GetBody() {
return mBody;                                                               
}
function byte GetGender() {
return mGender;                                                             
}
function byte GetRace() {
return mRace;                                                               
}
function SetScale(float aNewVal) {
mScale = aNewVal;                                                           
}
function SetBody(byte aNewVal) {
mBody = aNewVal;                                                            
}
function SetGender(byte aNewVal) {
mGender = aNewVal;                                                          
mVoicePackage = "";                                                         
}
function SetRace(byte aNewVal) {
mRace = aNewVal;                                                            
}
event bool Check() {
return True;                                                                
}
event string GetVoicePackage() {
if (mVoice < 255) {                                                         
if (Len(mVoicePackage) == 0 && mGender <= 1) {                            
mVoicePackage = "voice_";                                               
if (mGender == 0) {                                                     
} else {                                                                
}
if (IsPlayer()) {                                                       
} else {                                                                
if (IsKid()) {                                                        
} else {                                                              
if (mVoice >= Class'NPC_Appearance'.9) {                            
} else {                                                            
}
}
}
}
} else {                                                                    
mVoicePackage = "";                                                       
}
return mVoicePackage;                                                       
}
function bool IsNPC() {
return !IsKid() && !IsPlayer();                                             
}
function bool IsPlayer() {
return Game_PlayerPawn(Outer) != None || Game_EditorPawn(Outer) != None
|| Character_Pawn(Outer) != None;
}
function bool IsKid() {
return mBody == 4;                                                          
}
function byte GetVoice() {
return mVoice;                                                              
}
function SetVoice(byte aNewVal) {
mVoice = aNewVal;                                                           
mVoicePackage = "";                                                         
}
function bool IsFullDetail() {
return True;                                                                
}
final native function Apply();
event cl_OnFrame(float DeltaTime) {
}
event cl_OnInit() {
Super.cl_OnInit();                                                          
mClientInitialized = True;                                                  
}
event OnConstruct() {
}
*/