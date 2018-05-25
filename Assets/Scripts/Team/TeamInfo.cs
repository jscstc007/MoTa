using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct BaseRoleData
{
    public int RoleID;
    public BaseCareerData CareerData;
    public List<BaseSkillData> SkillData;
    public List<BaseEquipmentData> EquipmentData;

    public BaseRoleData(int roleID,  BaseCareerData careerData, List<BaseSkillData> skillData, List<BaseEquipmentData> equipmentData)
    {
        RoleID = roleID;
        CareerData = careerData;
        SkillData = skillData;
        EquipmentData = equipmentData;
    }
}


public class TeamInfo : ASingleton<TeamInfo> {

    /// <summary> 我的队伍成员 </summary>
    public List<BaseRoleData> MyTeamDataList = new List<BaseRoleData>();

    /// <summary> 检查我的队伍成员中是否有指定ID的人物 </summary>
    public bool CheckHasRole (int roleId)
    {
        bool hasRole = false;
        foreach(BaseRoleData data in MyTeamDataList)
        {
            if (data.RoleID == roleId)
            {
                hasRole = true;
                break;
            }
        }
        return hasRole;
    }

    /// <summary> 获取我的队伍成员中指定ID人物的INDEX,不存在时返回-1 </summary>
    public int GetRoleIndex(int roleId)
    {
        int index = -1;
        int count = MyTeamDataList.Count;
        for (int i = 0;i < count;i ++)
        {
            if (MyTeamDataList[i].RoleID == roleId)
            {
                index = i;
                break;
            }
        }
        return index;
    }

    /// <summary> 添加一个成员到我的队伍中 </summary>
    public void AddRoleToMyTeam(BaseRoleData roleData)
    {
        if (CheckHasRole(roleData.RoleID))
        {
            Util.LogError("队伍成员中已有该人物了");
        }
        else
        { 
            MyTeamDataList.Add(roleData);
        }
    }

    /// <summary> 移除一个我的队伍成员 </summary>
    public void RemoveRoleFromMyTeam (int roleId)
    {
        int roleIndex = GetRoleIndex(roleId);
        if (roleIndex != -1)
        {
            MyTeamDataList.RemoveAt(roleIndex);
        }
    }
}
