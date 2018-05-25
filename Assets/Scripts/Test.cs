using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct SkillTreeData
{
    public string Name;

    public SkillTreeData(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return string.Format("SkillTreeData:{0}", Name);
    }
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        //测试一个树状图
        CheckTree();

    }
	
	private void CheckTree ()
    {
        TreeData<SkillTreeData> t1 = new TreeData<SkillTreeData>(new SkillTreeData("1"));
        TreeData<SkillTreeData> t1_1 = new TreeData<SkillTreeData>(new SkillTreeData("1-1"));
        TreeData<SkillTreeData> t1_1_1 = new TreeData<SkillTreeData>(new SkillTreeData("1-1-1"));
        TreeData<SkillTreeData> t1_1_2 = new TreeData<SkillTreeData>(new SkillTreeData("1-1-2"));
        TreeData<SkillTreeData> t1_1_2_1 = new TreeData<SkillTreeData>(new SkillTreeData("1-1-2-1"));
        TreeData<SkillTreeData> t1_2 = new TreeData<SkillTreeData>(new SkillTreeData("1-2"));

        t1.AddChildNode(t1_1);
        t1_1.AddChildNode(t1_1_1);
        t1_1.AddChildNode(t1_1_2);
        t1_1_2.AddChildNode(t1_1_2_1);
        t1.AddChildNode(t1_2);

        t1.DebugNodes();
        foreach(TreeData<SkillTreeData> node in t1.ChildDataList)
        {
            node.DebugNodes();
        }

    }
}
