﻿using System;
using System.Collections.Generic;
using Engine;
using Sirenix.OdinInspector;
using UnityEngine;

namespace SBGame
{
    [Serializable] public class Item_Type : Content_Type
    {
        [FieldConst()]
        public List<Item_Component> Components = new List<Item_Component>();

        [FoldoutGroup("ReadOnly")]
        [FieldConst()]
        [NonSerialized, HideInInspector]
        public string Logo; //texture

        [FoldoutGroup("ReadOnly")]
        [FieldConst()]
        [NonSerialized, HideInInspector]
        public string SecondaryLogo; //texture

        [NonSerialized, HideInInspector]
        [FieldTransient()]
        private bool RequiresTicksValue;

        [NonSerialized, HideInInspector]
        [FieldTransient()]
        private bool RequiresTicksDetermined;

        [FoldoutGroup("ReadOnly")]
        [FieldConst()]
        public byte ItemType;

        [FoldoutGroup("General")]
        [FieldConst()]
        public int StackableAmount;

        [FoldoutGroup("General")]
        [FieldConst()]
        public bool Tradable;

        [FoldoutGroup("General")]
        [FieldConst()]
        public bool RecyclableIntoMoney;

        [FoldoutGroup("General")]
        [FieldConst()]
        public bool Sellable;

        [FoldoutGroup("General")]
        [FieldConst()]
        public byte EquipmentSlot;

        [FoldoutGroup("General")]
        [FieldConst()]
        public bool Equipable;

        [FoldoutGroup("General")]
        [FieldConst()]
        public bool BindOnPickup;

        [FoldoutGroup("General")]
        [FieldConst()]
        public bool BindOnEquip;

        [FoldoutGroup("General")]
        [FieldConst()]
        public byte ItemRarity;

        [FoldoutGroup("General")]
        [FieldConst()]
        protected int BuyPriceValue;

        [FoldoutGroup("General")]
        [FieldConst()]
        protected int SellPriceValue;

        [FoldoutGroup("General")]
        [FieldConst()]
        protected int RecyclePriceValue;

        [FoldoutGroup("General")]
        [FieldConst()]
        public byte MinLevel;

        [FieldConst()]
        public List<Content_Requirement> Requirements = new List<Content_Requirement>();

        [FoldoutGroup("Info")]
        [FieldConst()]
        public LocalizedString Name;

        [FoldoutGroup("Info")]
        [FieldConst()]
        public LocalizedString Description;

        [FoldoutGroup("OnUse")]
        [FieldConst()]
        public float UseCooldown;

        [FieldConst()]
        [NonSerialized, HideInInspector]
        [FieldTransient()]
        public List<Content_Event> UseEvents = new List<Content_Event>();

        public Item_Type()
        {
        }

        public enum EItemType
        {
            IT_BodySlot,

            IT_JewelryRing,

            IT_JewelryNecklace,

            IT_JewelryQualityToken,

            IT_WeaponQualityToken,

            IT_SkillToken,

            IT_QuestItem,

            IT_Trophy,

            IT_ContainerSuitBag,

            IT_ContainerExtraInventory,

            IT_Resource,

            IT_WeaponOneHanded,

            IT_WeaponDoublehanded,

            IT_WeaponDualWielding,

            IT_WeaponRanged,

            IT_WeaponShield,

            IT_ArmorHeadGear,

            IT_ArmorLeftShoulder,

            IT_ArmorRightShoulder,

            IT_ArmorLeftGauntlet,

            IT_ArmorRightGauntlet,

            IT_ArmorChest,

            IT_ArmorBelt,

            IT_ArmorLeftThigh,

            IT_ArmorLeftShin,

            IT_ClothChest,

            IT_ClothLeftGlove,

            IT_ClothRightGlove,

            IT_ClothPants,

            IT_ClothShoes,

            IT_MiscellaneousTickets,

            IT_MiscellaneousKey,

            IT_MiscellaneousLabyrinthKey,

            IT_Recipe,

            IT_ArmorRightThigh,

            IT_ArmorRightShin,

            IT_ItemToken,

            IT_Consumable,

            IT_Broken,
        }

        public enum EItemRarity
        {
            IR_Trash,

            IR_Resource,

            IR_Common,

            IR_Uncommon,

            IR_Rare,

            IR_Ancestral,

            IR_Mumian,
        }
    }
}
/*
final event int GetBreakdownValue() {
return RecyclePriceValue;                                                   
}
final event int GetSellValue() {
return SellPriceValue;                                                      
}
final event int GetBuyPrice() {
return BuyPriceValue;                                                       
}
event Material GetDragLogo(Game_Pawn aPawn) {
local Shader tempShader;
local Combiner tempCombiner;
if (ItemType == 5) {                                                        
if (ShouldUseSecondaryLogo(aPawn)) {                                      
return SecondaryLogo;                                                   
} else {                                                                  
return Logo;                                                            
}
} else {                                                                    
if (ItemType == 36) {                                                     
tempCombiner = new Class'Combiner';                                     
tempCombiner.CombineOperation = 5;                                      
tempCombiner.AlphaOperation = 0;                                        
tempCombiner.Material1 = Logo;                                          
tempCombiner.Material2 = SecondaryLogo;                                 
tempCombiner.Mask = SecondaryLogo;                                      
tempShader = new Class'Shader';                                         
tempShader.Diffuse = tempCombiner;                                      
tempShader.Opacity = Logo;                                              
return tempShader;                                                      
} else {                                                                  
return GetLogo(aPawn);                                                  
}
}
}
function Material GetLogo(Game_Pawn aPawn) {
local Material itemMaterial;
local export editinline IC_Broken componentBroken;
local export editinline IC_Recipe componentRecipe;
local Combiner Combiner01;
local Combiner combiner02;
if (aPawn != None) {                                                        
if (ShouldUseSecondaryLogo(aPawn)) {                                      
itemMaterial = SecondaryLogo;                                           
} else {                                                                  
itemMaterial = Logo;                                                    
}
if (itemMaterial.IsA('Texture')) {                                        
Texture(itemMaterial).UClampMode = 2;                                   
Texture(itemMaterial).VClampMode = 2;                                   
}
if (ItemType == 38) {                                                     
componentBroken = IC_Broken(GetComponentByClass(Class'IC_Broken'));     
if (componentBroken != None && componentBroken.Recipe != None) {        
componentRecipe = IC_Recipe(componentBroken.Recipe.GetComponentByClass(Class'IC_Recipe'));
if (componentRecipe != None
&& componentRecipe.ProducedItem != None) {
itemMaterial = componentRecipe.ProducedItem.GetLogo(aPawn);         
}
}
Combiner01 = new Class'Combiner';                                       
Combiner01.CombineOperation = 2;                                        
Combiner01.AlphaOperation = 2;                                          
Combiner01.Material1 = itemMaterial;                                    
switch (GetResourceId() % 8) {                                          
case 0.00000000 :                                                     
Combiner01.Material2 = Texture'crack-01';                           
break;                                                              
case 1.00000000 :                                                     
Combiner01.Material2 = Texture'crack-02';                           
break;                                                              
case 2.00000000 :                                                     
Combiner01.Material2 = Texture'crack-03';                           
break;                                                              
case 3.00000000 :                                                     
Combiner01.Material2 = Texture'crack-04';                           
break;                                                              
case 4.00000000 :                                                     
Combiner01.Material2 = Texture'crack-05';                           
break;                                                              
case 5.00000000 :                                                     
Combiner01.Material2 = Texture'crack-06';                           
break;                                                              
case 6.00000000 :                                                     
Combiner01.Material2 = Texture'crack-07';                           
break;                                                              
case 7.00000000 :                                                     
Combiner01.Material2 = Texture'crack-08';                           
break;                                                              
default:                                                              
}
Combiner01.Mask = itemMaterial;                                         
return Combiner01;                                                      
}
if (ItemType == 33) {                                                     
componentRecipe = IC_Recipe(GetComponentByClass(Class'IC_Recipe'));     
if (componentRecipe != None
&& componentRecipe.ProducedItem != None) {
itemMaterial = componentRecipe.ProducedItem.GetLogo(aPawn);           
}
Combiner01 = new Class'Combiner';                                       
Combiner01.CombineOperation = 5;                                        
Combiner01.AlphaOperation = 0;                                          
Combiner01.Material1 = itemMaterial;                                    
Combiner01.Material2 = Texture'Recipe_Overlay';                         
Combiner01.Mask = Texture'Recipe_Overlay';                              
return Combiner01;                                                      
}
if (ItemType == 5) {                                                      
Combiner01 = new Class'Combiner';                                       
Combiner01.CombineOperation = 5;                                        
Combiner01.AlphaOperation = 0;                                          
Combiner01.Material1 = Texture'SigilSlot_B';                            
Combiner01.Material2 = itemMaterial;                                    
Combiner01.Mask = itemMaterial;                                         
return Combiner01;                                                      
}
if (ItemType == 36) {                                                     
Combiner01 = new Class'Combiner';                                       
Combiner01.CombineOperation = 5;                                        
Combiner01.AlphaOperation = 0;                                          
Combiner01.Material1 = Logo;                                            
Combiner01.Material2 = SecondaryLogo;                                   
Combiner01.Mask = SecondaryLogo;                                        
combiner02 = new Class'Combiner';                                       
combiner02.CombineOperation = 5;                                        
combiner02.AlphaOperation = 0;                                          
combiner02.Material1 = Texture'SigilBackplate';                         
combiner02.Material2 = Combiner01;                                      
combiner02.Mask = Logo;                                                 
return combiner02;                                                      
}
return itemMaterial;                                                      
}
return None;                                                                
}
function string GetTypeName() {
switch (ItemType) {                                                         
case 0 :                                                                  
return Class'StringReferences'.default.BodySlot.Text;                   
case 34 :                                                                 
return Class'StringReferences'.default.Right_Thigh_Armour.Text;         
case 35 :                                                                 
return Class'StringReferences'.default.Right_Shin_Armour.Text;          
case 16 :                                                                 
return Class'StringReferences'.default.Head_Gear.Text;                  
case 17 :                                                                 
return Class'StringReferences'.default.Left_Shoulder_Armour.Text;       
case 18 :                                                                 
return Class'StringReferences'.default.Right_Shoulder_Armour.Text;      
case 19 :                                                                 
return Class'StringReferences'.default.Left_Gauntlet.Text;              
case 20 :                                                                 
return Class'StringReferences'.default.Right_Gauntlet.Text;             
case 21 :                                                                 
return Class'StringReferences'.default.Chest_Armour.Text;               
case 22 :                                                                 
return Class'StringReferences'.default.Belt.Text;                       
case 23 :                                                                 
return Class'StringReferences'.default.Left_Thigh_Armour.Text;          
case 24 :                                                                 
return Class'StringReferences'.default.Left_Shin_Armour.Text;           
case 25 :                                                                 
return Class'StringReferences'.default.Chest_Clothing.Text;             
case 26 :                                                                 
return Class'StringReferences'.default.Left_Glove.Text;                 
case 27 :                                                                 
return Class'StringReferences'.default.Right_Glove.Text;                
case 28 :                                                                 
return Class'StringReferences'.default.Pants.Text;                      
case 29 :                                                                 
return Class'StringReferences'.default.Shoes.Text;                      
case 11 :                                                                 
return Class'StringReferences'.default.Single_Handed_Weapon.Text;       
case 12 :                                                                 
return Class'StringReferences'.default.Double_Handed_Weapon.Text;       
case 13 :                                                                 
return Class'StringReferences'.default.Dual_Wielding_Weapon.Text;       
case 14 :                                                                 
return Class'StringReferences'.default.Ranged_Weapon.Text;              
case 15 :                                                                 
return Class'StringReferences'.default.Shield.Text;                     
case 1 :                                                                  
return Class'StringReferences'.default.Ring.Text;                       
case 2 :                                                                  
return Class'StringReferences'.default.Necklace.Text;                   
case 36 :                                                                 
return Class'StringReferences'.default.Item_Sigil.Text;                 
case 5 :                                                                  
return Class'StringReferences'.default.Skill_Sigil.Text;                
case 3 :                                                                  
return "Sigil";                                                         
case 4 :                                                                  
return "Sigil";                                                         
case 33 :                                                                 
return Class'StringReferences'.default.Recipe.Text;                     
case 10 :                                                                 
if (ItemRarity == 0) {                                                  
return Class'StringReferences'.default.Waste_Item.Text;               
} else {                                                                
return Class'StringReferences'.default.Resource.Text;                 
}
case 7 :                                                                  
return Class'StringReferences'.default.Trophy.Text;                     
case 6 :                                                                  
return Class'StringReferences'.default.Quest_Item.Text;                 
case 30 :                                                                 
return Class'StringReferences'.default.Ticket.Text;                     
case 31 :                                                                 
return Class'StringReferences'.default.Key.Text;                        
case 32 :                                                                 
return Class'StringReferences'.default.Labyrinth_Key.Text;              
case 37 :                                                                 
return Class'StringReferences'.default.Consumable.Text;                 
case 8 :                                                                  
return Class'StringReferences'.default.Bag.Text;                        
case 9 :                                                                  
return Class'StringReferences'.default.Extra_Inventory.Text;            
case 38 :                                                                 
return Class'StringReferences'.default.Broken_Item.Text;                
default:                                                                  
return "";                                                              
}
}
}
final function string GetTooltipType() {
switch (ItemType) {                                                         
case 0 :                                                                  
return "HUD_ItemBodySlotTooltip";                                       
case 16 :                                                                 
case 21 :                                                                 
return "HUD_ItemWithSigilsTooltip";                                     
case 34 :                                                                 
case 35 :                                                                 
case 17 :                                                                 
case 18 :                                                                 
case 19 :                                                                 
case 20 :                                                                 
case 22 :                                                                 
case 23 :                                                                 
case 24 :                                                                 
return "HUD_ItemAttunedTooltip";                                        
case 25 :                                                                 
case 26 :                                                                 
case 27 :                                                                 
case 28 :                                                                 
case 29 :                                                                 
return "HUD_ItemAttunedTooltip";                                        
case 36 :                                                                 
return "HUD_ItemSigilTooltip";                                          
case 5 :                                                                  
return "HUD_ItemAttunedTooltip";                                        
case 15 :                                                                 
return "HUD_ItemAttunedTooltip";                                        
case 14 :                                                                 
case 11 :                                                                 
case 12 :                                                                 
case 13 :                                                                 
return "HUD_ItemWithSigilsTooltip";                                     
case 1 :                                                                  
case 2 :                                                                  
return "HUD_ItemWithSigilsTooltip";                                     
case 33 :                                                                 
return "HUD_ItemRecipeTooltip";                                         
case 38 :                                                                 
return "HUD_ItemBrokenTooltip";                                         
case 10 :                                                                 
case 7 :                                                                  
case 6 :                                                                  
case 30 :                                                                 
case 31 :                                                                 
case 32 :                                                                 
case 37 :                                                                 
case 8 :                                                                  
case 9 :                                                                  
default:                                                                  
return "HUD_ItemTooltip";                                               
}
}
}
event Color GetRarityColor() {
local Color Result;
Result.A = 255;                                                             
switch (ItemRarity) {                                                       
case 0 :                                                                  
Result.R = 183;                                                         
Result.G = 183;                                                         
Result.B = 183;                                                         
break;                                                                  
case 1 :                                                                  
Result.R = 102;                                                         
Result.G = 214;                                                         
Result.B = 76;                                                          
break;                                                                  
case 2 :                                                                  
Result.R = 184;                                                         
Result.G = 182;                                                         
Result.B = 189;                                                         
break;                                                                  
case 3 :                                                                  
Result.R = 199;                                                         
Result.G = 218;                                                         
Result.B = 152;                                                         
break;                                                                  
case 4 :                                                                  
Result.R = 204;                                                         
Result.G = 135;                                                         
Result.B = 75;                                                          
break;                                                                  
case 5 :                                                                  
Result.R = 212;                                                         
Result.G = 63;                                                          
Result.B = 63;                                                          
break;                                                                  
case 6 :                                                                  
Result.R = 179;                                                         
Result.G = 100;                                                         
Result.B = 182;                                                         
break;                                                                  
default:                                                                  
Result.R = 184;                                                         
Result.G = 182;                                                         
Result.B = 189;                                                         
break;                                                                  
}
return Result;                                                              
}
event string GetActiveText(Game_ActiveTextItem aItem) {
return GetName();                                                           
}
function bool IsNPCType() {
local int i;
i = 0;                                                                      
while (i < Components.Length) {                                             
if (Components[i].IsNPCItem()) {                                          
return True;                                                            
}
++i;                                                                      
}
return False;                                                               
}
event string GetName() {
if (Len(Name.Text) > 0) {                                                   
return Name.Text;                                                         
} else {                                                                    
return Class'StringReferences'.default._Unknown_item_.Text;               
}
}
final native function IC_EquipEffects GetEquipEffectsTokenComponent();
final native function IC_TokenItem GetItemTokenComponent();
final native function IC_TokenSkill GetSkillTokenComponent();
final native function Appearance_Base GetAppearance();
event byte GetWeaponType() {
return 0;                                                                   
}
event int GetComponent(class<Object> ComponentClass) {
local int i;
i = 0;                                                                      
while (i < Components.Length) {                                             
if (Components[i].Class == ComponentClass) {                              
return i;                                                               
}
i++;                                                                      
}
return -1;                                                                  
}
event OnSheathe(Game_Pawn aPawn) {
local int i;
i = 0;                                                                      
while (i < Components.Length) {                                             
Components[i].OnSheathe(aPawn);                                           
i++;                                                                      
}
}
event OnDraw(Game_Pawn aPawn) {
local int i;
i = 0;                                                                      
while (i < Components.Length) {                                             
Components[i].OnDraw(aPawn);                                              
i++;                                                                      
}
}
event OnUnequip(Game_Pawn aPawn,Game_Item aItem) {
local int i;
i = 0;                                                                      
while (i < Components.Length) {                                             
Components[i].OnUnequip(aPawn,aItem);                                     
i++;                                                                      
}
}
event OnEquip(Game_Pawn aPawn,Game_Item aItem) {
local int i;
i = 0;                                                                      
while (i < Components.Length) {                                             
Components[i].OnEquip(aPawn,aItem);                                       
i++;                                                                      
}
}
event OnUse(Game_Pawn aPawn,Game_Item aItem) {
local int i;
i = 0;                                                                      
while (i < Components.Length) {                                             
Components[i].OnUse(aPawn,aItem);                                         
i++;                                                                      
}
if (UseCooldown > 0) {                                                      
aItem.OnItemUsed();                                                       
}
}
event bool CanEquip(Game_Pawn aPawn,Game_Item aItem) {
local int i;
i = 0;                                                                      
while (i < Components.Length) {                                             
if (!Components[i].CanEquip(aPawn,aItem)) {                               
return False;                                                           
}
i++;                                                                      
}
return True;                                                                
}
event bool sv_CanUse(Game_Pawn aPawn,Game_Item aItem) {
local int i;
i = 0;                                                                      
while (i < Components.Length) {                                             
if (!Components[i].CanUse(aPawn,aItem)) {                                 
return False;                                                           
}
i++;                                                                      
}
i = 0;                                                                      
while (i < Requirements.Length) {                                           
if (Requirements[i] == None
|| !Requirements[i].CheckPawn(aPawn)) {
return False;                                                           
}
i++;                                                                      
}
if (aPawn.CharacterStats.mRecord.FameLevel < MinLevel) {                    
return False;                                                             
}
return True;                                                                
}
final native function byte GetItemLevel();
final native function bool ShouldUseSecondaryLogo(Game_Pawn aPawn);
final native function Item_Component GetComponentByClass(class<Item_Component> aComponentClass);
static native function LoadAllItems();
*/