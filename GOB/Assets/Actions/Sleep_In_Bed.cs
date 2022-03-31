using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep_In_Bed : Action
{
    public Sleep_In_Bed()
    {
        type = ActionType.Sleep_In_Bed;
        duration = 8.0f;
        goalChanges = new Dictionary<GoalType, float>
        {
            {GoalType.Bathroom, 2 },
            {GoalType.Eat, 1 },
            {GoalType.Sleep, -5 },
            {GoalType.Thirst, 3 }
        };
    }
}
