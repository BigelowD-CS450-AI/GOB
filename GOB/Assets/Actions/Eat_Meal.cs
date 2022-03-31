using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat_Meal : Action
{
    public Eat_Meal()
    {
        type = ActionType.Eat_Meal;
        duration = 1f;
        goalChanges = new Dictionary<GoalType, float>
        {
            {GoalType.Bathroom, 0 },
            {GoalType.Eat, -5 },
            {GoalType.Sleep, 1 },
            {GoalType.Thirst, 1 }
        };
    }
}
