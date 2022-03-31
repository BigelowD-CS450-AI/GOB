using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : Goal
{
    public Eat(float initialInsistance)
    {
        type = GoalType.Eat;
        value = initialInsistance;
        change = 5.0f / 3.0f;
    }
}
