using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 基础技能数据
/// </summary>
public struct BaseSkillData
{
    public int SkillID;
    public string SkillName;
    public string SkillIcon;
    public string SkillDes;

    public int NeedLevel;
    public int[] NeedMajor;

    public int[] SkillCost_HP;
    public int[] SkillCost_VP;
    public int[] SkillCost_MP;

    public BaseSkillData(int skillID, string skillName, string skillIcon, string skillDes, int needLevel, int[] needMajor, int[] skillCost_HP, int[] skillCost_VP, int[] skillCost_MP, int skillCost_AP)
    {
        SkillID = skillID;
        SkillName = skillName;
        SkillIcon = skillIcon;
        SkillDes = skillDes;
        NeedLevel = needLevel;
        NeedMajor = needMajor;
        SkillCost_HP = skillCost_HP;
        SkillCost_VP = skillCost_VP;
        SkillCost_MP = skillCost_MP;
    }
}

public class SkillInfo : ASingleton<SkillInfo> {

    /*
     * 技能说明
     * 技能按照'专精'进行分类
     * 技能有使用需求，主要按照等级,专精来决定
     * 技能有使用消耗，主要由3种属性条决定(hp,vp,mp)
     * 
     */

	//TODO

    
}
