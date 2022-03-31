using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep : Goal
{
    public Sleep(float initialInsistance)
    {
        type = GoalType.Sleep;
        value = initialInsistance;
        change = 1.0f/3.0f;
    }
}
