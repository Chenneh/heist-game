﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITest : MonoBehaviour
{
    enum AIState
    {
        good,
        medium,
        bad
    }

    [SerializeField]
    private Material mMat;

    private AIState _state;

    private AIState mState
    {
        get
        {
            return _state;
        }

        set
        {
            _state = value;
            mMat.color = value == AIState.bad ? Color.red : value == AIState.medium ? Color.yellow : Color.green;
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
