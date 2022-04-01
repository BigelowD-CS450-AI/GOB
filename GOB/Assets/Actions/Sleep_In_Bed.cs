using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep_In_Bed : Action
{
    public Sleep_In_Bed()
    {
        type = ActionType.Sleep_In_Bed;
        duration = 6.0f;
        goalChanges = new Dictionary<GoalType, float>
        {
            {GoalType.Bathroom, 0 },
            {GoalType.Depression, -2 },
            {GoalType.Eat, 0 },
            {GoalType.Sleep, -5 },
            {GoalType.Thirst, 0 }
        };
    }
}
