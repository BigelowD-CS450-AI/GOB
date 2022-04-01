using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Do_Nothing : Action
{
    public Do_Nothing()
    {
        type = ActionType.Do_Nothing;
        duration = 1.0f;
        goalChanges = new Dictionary<GoalType, float>
        {
            {GoalType.Bathroom, 0 },
            {GoalType.Depression, 0.5f },
            {GoalType.Eat, 0 },
            {GoalType.Sleep, 0 },
            {GoalType.Thirst, 0 }
        };
    }
}
