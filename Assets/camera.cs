﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    bool isRotation = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotation)
        {
            Vector3 rotate = new Vector3(0, 1, 0);
            gameObject.transform.Rotate(rotate);
        }
    }

    public void RotationButton()
    {
        isRotation = !isRotation;
    }
}
