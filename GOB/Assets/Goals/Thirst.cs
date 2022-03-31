using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thirst : Goal
{
    public Thirst(float initialInsistance)
    {
        type = GoalType.Thirst;
        value = initialInsistance;
        change = 1.0f;
    }
}
