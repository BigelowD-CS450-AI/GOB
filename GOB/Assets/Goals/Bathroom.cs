using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bathroom : Goal
{
    public Bathroom(float initialInsistance)
    {
        type = GoalType.Bathroom;
        value = initialInsistance;
        change = 0.5f;
    }
}
