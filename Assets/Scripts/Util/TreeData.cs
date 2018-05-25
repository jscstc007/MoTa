using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 简易树状图
/// </summary>
public class TreeData<T> {

    /// <summary> 当前节点数据 </summary>
    public T NodeData;

    /// <summary> 子节点数据(如果没有子节点则为空) </summary>
    public List<TreeData<T>> ChildDataList;

    public TreeData(T nodeData)
    {
        NodeData = nodeData;
    }

    public TreeData(T nodeData, List<TreeData<T>> childDataList) : this(nodeData)
    {
        ChildDataList = childDataList;
    }

    /// <summary> 添加一个子节点 </summary>
    public void AddChildNode (TreeData<T> node)
    {
        if (null == ChildDataList)
        {
            ChildDataList = new List<TreeData<T>>();
        }
        ChildDataList.Add(node);
    }

    /// <summary> 移除一个子节点 </summary>
    public void RemoveChildNode (TreeData<T> node)
    {
        if (null != ChildDataList)
        {
            if (ChildDataList.Contains(node))
            {
                ChildDataList.Remove(node);
            }
        }
    }

    /// <summary> 打印节点 </summary>
    public void DebugNodes ()
    {
        string info = "Node:{0} -- Child:{1}";
        string nodeInfo = NodeData.ToString();
        string childInfo = string.Empty;
        if (null != ChildDataList)
        {
            foreach(TreeData<T> child in ChildDataList)
            {
                childInfo = string.Format("{0} {1}",childInfo,child.NodeData.ToString() );
            }
        }
        Util.Log(string.Format(info, nodeInfo, childInfo));
    }

}
