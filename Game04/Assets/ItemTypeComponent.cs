﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTypeComponent : MonoBehaviour
{
    [SerializeField]
    protected ItemType _itemType;
    public ItemType Type
    {
        get
        {
            return _itemType;
        }
        set
        {
            _itemType =value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
