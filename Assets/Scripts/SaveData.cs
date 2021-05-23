﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData 
{
    //Singleton
    private static SaveData _current;

    public static SaveData current
    {
        
        get
        {
            if (_current == null)
            {
                _current = new SaveData();
            }
            return _current;
        }
        set
        {
            if (value != null)
            {
                _current = value;
            }
        }
    }

    public List<ObjectData> objectsToSave = new List<ObjectData>();
}
