using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EquipPosition
{
    None = -1,
    Weapon = 0,
    Armour = 1,
    Shield = 2,
    WeaponOrShield = 3,//可装备武器或盾牌
    Accessories = 4,
}

public enum CareerType
{
    None = -1,

    Saber,
    Archer,
    Doctor,
    Magician,
    Creator,
    //...
}

/// <summary>
/// 基础职业数据
/// </summary>
public struct BaseCareerData
{
    public int CareerID;
    public string CareerName;
    public string CareerIcon;
    public string CareerDes;

    public CareerType BaseCareerType;//该职业的基础类别
    public int NeedLevel;
    public int[] NeedMajor;

    public EquipPosition[] CareerEquipPos;//该职业的装备栏
}

public class CareerInfo : ASingleton<CareerInfo> {

    /*
    * 职业说明
    * 职业按照'职业类别'分为基础类
    * 职业有使用需求，主要按照等级,专精来决定
    * 职业有对应的装备栏位，不同职业装备栏位可能不一样
    * 进阶职业按基础类进行树状图，已解锁的职业可任意切换(注意装备栏位问题)
    */
}
