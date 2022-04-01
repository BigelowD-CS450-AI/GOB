using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep_On_Couch : Action
{
    public Sleep_On_Couch()
    {
        type = ActionType.Sleep_On_Couch;
        duration = 1.5f;
        goalChanges = new Dictionary<GoalType, float>
        {
            {GoalType.Bathroom, 0 },
            {GoalType.Depression, 3 },
            {GoalType.Eat, 0 },
            {GoalType.Sleep, -2 },
            {GoalType.Thirst, 0 }
        };
    }
}
