using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct BaseRoleData
{
    public int RoleId;
    public string RoleName;
    public string RoleIcon;
    public string RoleDes;

    public BaseCareerData careerData;
    public Dictionary<EquipPosition, BaseEquipmentData> equipmentDatas;
    public List<BaseSkillData> skillDatas;

    public int Level;
    public int Exp;
    public int MaxExp;

    public int HP;
    public int MaxHP;
    public int VP;
    public int MaxVP;
    public int MP;
    public int MaxMP;

    public int Speed;

    public int Major_Fight;
    //...
    //TODO
}

public class RoleInfo : ASingleton<RoleInfo> {

	//TODO
}
