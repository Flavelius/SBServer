﻿using System;
using System.Collections.Generic;

namespace SBGame
{
    [Serializable] public class Game_PlayerAppearance : Game_EquippedAppearance
    {
        private byte mLowestReceivedLOD;

        public List<byte> mLODData0 = new List<byte>();

        public List<byte> mLODData1 = new List<byte>();

        public List<byte> mLODData2 = new List<byte>();

        public List<byte> mLODData3 = new List<byte>();

        public Game_PlayerAppearance()
        {
        }
    }
}
/*
protected native function UnpackBaseData(int aAppearancePart1,int aAppearancePart2);
protected native function UnpackLodData(int aLevel);
protected function UnpackLodDataAll() {
UnpackLodData(0);                                                           
UnpackLodData(1);                                                           
UnpackLodData(2);                                                           
UnpackLodData(3);                                                           
}
protected native function RepackLodData(int aLevel);
native function PackBaseData(out int outMSB,out int outLSB);
function byte GetLowestReceivedLOD() {
return mLowestReceivedLOD;                                                  
}
final native event RepackLodDataAll();
function ConditionalUnpackLODData() {
if (mLODData0.Length > 0) {                                                 
UnpackLodData(0);                                                         
}
if (mLODData1.Length > 0) {                                                 
UnpackLodData(1);                                                         
}
if (mLODData2.Length > 0) {                                                 
UnpackLodData(2);                                                         
}
if (mLODData3.Length > 0) {                                                 
UnpackLodData(3);                                                         
}
}
function GetLODData(out array<byte> oLOD0,out array<byte> oLOD1,out array<byte> oLOD2,out array<byte> oLOD3) {
RepackLodDataAll();                                                         
oLOD0 = mLODData0;                                                          
oLOD1 = mLODData1;                                                          
oLOD2 = mLODData2;                                                          
oLOD3 = mLODData3;                                                          
}
event SetLODData(array<byte> aLOD0,array<byte> aLOD1,array<byte> aLOD2,array<byte> aLOD3) {
mLODData0 = aLOD0;                                                          
mLODData1 = aLOD1;                                                          
mLODData2 = aLOD2;                                                          
mLODData3 = aLOD3;                                                          
ConditionalUnpackLODData();                                                 
Apply();                                                                    
}
event SetBaseAppearance(int aAppearancePart1,int aAppearancePart2) {
UnpackBaseData(aAppearancePart1,aAppearancePart2);                          
Apply();                                                                    
}
function app(int A) {
Super.app(A);                                                               
cl_ConsoleMessage("----------------------------");                          
if (A == 0) {                                                               
cl_ConsoleMessage("mLODData0.length == " $ string(mLODData0.Length));     
cl_ConsoleMessage("mLODData1.length == " $ string(mLODData1.Length));     
cl_ConsoleMessage("mLODData2.length == " $ string(mLODData2.Length));     
cl_ConsoleMessage("mLODData3.length == " $ string(mLODData3.Length));     
cl_ConsoleMessage("----------------------------");                        
}
}
function bool IsFullDetail() {
return mLowestReceivedLOD == 0;                                             
}
event cl_OnFrame(float DeltaTime) {
Super.cl_OnFrame(DeltaTime);                                                
ConditionalUnpackLODData();                                                 
}
event cl_OnInit() {
Super.cl_OnInit();                                                          
Apply();                                                                    
}
*/