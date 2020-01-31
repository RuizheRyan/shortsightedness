﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ValueController : MonoBehaviour
{
    public float TargetWork;
    public float MaxSight;
    public float WorkValue;
    public float Sight;
    public Slider WorkSlider;
    public Slider SightSlider;
    public float workspeed;
    public float sightspeed;
    public Transform LookPosition;
    // Start is called before the first frame update
    void Start()
    {
        WorkSlider.value = 1;
        SightSlider.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        WorkSlider.value = (float)WorkValue / TargetWork;
        SightSlider.value = (float)Sight / MaxSight;
        if (WorkValue >= TargetWork) { this.transform.position = LookPosition.position; }
    }
}