using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    private static GameController instance;
    public static GameController Instance
    {
        get
        {
            if (null == instance)
            {
                instance = FindObjectOfType<GameController>();
            }
            return instance;
        }
    }

    private void Start()
    {
        InitData();
    }

    /// <summary>初始化数据 </summary>
    public void InitData ()
    {
        //TODO
    }
}
