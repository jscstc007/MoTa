﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ASingleton<T> where T : new() {

    private static T instance;
    public static T Instance
    {
        get
        {
            if (null == instance)
            {
                instance = new T();
            }
            return instance;
        }
    }
}
