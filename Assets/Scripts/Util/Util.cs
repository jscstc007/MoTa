using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util : MonoBehaviour{

    public static void Log(string info)
    {
        Debug.Log(info);
    }

    public static void LogWarning(string info)
    {
        Debug.LogWarning(info);
    }

    public static void LogError(string info)
    {
        Debug.LogError(info);
    }
}
