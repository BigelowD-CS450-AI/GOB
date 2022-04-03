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
            {GoalType.Bathroom, -.5f },
            {GoalType.Depression, 1 },
            {GoalType.Eat, -.5f },
            {GoalType.Sleep, -3 },
            {GoalType.Thirst, -.5f }
        };
    }
}
