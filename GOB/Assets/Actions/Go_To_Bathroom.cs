using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go_To_Bathroom : Action
{
    public Go_To_Bathroom()
    {
        type = ActionType.Go_To_Bathroom;
        duration = .5f;
        goalChanges = new Dictionary<GoalType, float>
        {
            {GoalType.Bathroom, -100 },
            {GoalType.Depression, 0 },
            {GoalType.Eat, 1 },
            {GoalType.Sleep, 1 },
            {GoalType.Thirst, 1 }
        };
    }
}
