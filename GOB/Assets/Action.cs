using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action
{
    public Dictionary<GoalType, float> goalChanges;
    public ActionType type;
    protected float duration;
    public float getGoalChange(Goal goal)
    {
        return goalChanges[goal.type];
    }
    public float getDuration()
    {
        return duration;
    }
}

public enum ActionType {Drink_Soda, Drink_Water, Eat_Meal, Eat_Snack, Go_To_Bathroom, Sleep_In_Bed, Sleep_On_Couch, Do_Nothing}