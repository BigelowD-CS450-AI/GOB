using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Depression : Goal
{
    public Depression(float initialInsistance)
    {
        type = GoalType.Depression;
        value = initialInsistance;
        change = 0.0f;
    }
}
