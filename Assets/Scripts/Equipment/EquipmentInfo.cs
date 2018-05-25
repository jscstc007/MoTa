using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> 装备的类型 </summary>
public enum EquipType
{
    None = -1,
    Weapon = 0,
    Armour = 1,
    Shield = 2,
    Accessories = 3,
}

public struct BaseEquipmentData
{
    public int EquipmentID;
    public string EquipmentName;
    public string EquipmentIcon;
    public string EquipmentDes;

    public EquipType EquipmentType;
    public int NeedLevel;
    public int[] NeedMajor;

    public BaseEquipmentData(int equipmentID, string equipmentName, string equipmentIcon, string equipmentDes, EquipType equipmentType, int needLevel, int[] needMajor)
    {
        EquipmentID = equipmentID;
        EquipmentName = equipmentName;
        EquipmentIcon = equipmentIcon;
        EquipmentDes = equipmentDes;
        EquipmentType = equipmentType;
        NeedLevel = needLevel;
        NeedMajor = needMajor;
    }
}

public class EquipmentInfo : ASingleton<EquipmentInfo> {

    /*
    * 装备说明
    * 装备按照'装备类别'进行分类
    * 装备有使用需求，主要按照等级,专精来决定
    * 
    */

    //TODO
}
