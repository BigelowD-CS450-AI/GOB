using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Goal
{
    public GoalType type;
    protected float value;
    protected float change;
    public float getDiscontentment(float newValue)
    {
        return newValue * newValue;
    }
    public float getChange()
    {
        return change;
    }
    public float getValue()
    {
        return value;
    }
    public void passTime(float passedTime)
    {
        value = Mathf.Min(value + passedTime * change, 5);
    }
}

public enum GoalType { Eat, Sleep, Bathroom, Thirst};
