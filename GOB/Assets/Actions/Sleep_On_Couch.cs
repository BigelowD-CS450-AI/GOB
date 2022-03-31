using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep_On_Couch : Action
{
    public Sleep_On_Couch()
    {
        type = ActionType.Sleep_On_Couch;
        duration = 2.0f;
        goalChanges = new Dictionary<GoalType, float>
        {
            {GoalType.Bathroom, 1 },
            {GoalType.Eat, 0 },
            {GoalType.Sleep, -2 },
            {GoalType.Thirst, 1 }
        };
    }
}
