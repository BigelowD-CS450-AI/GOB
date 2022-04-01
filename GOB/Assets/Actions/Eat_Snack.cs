using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat_Snack : Action
{
    public Eat_Snack()
    {
        type = ActionType.Eat_Snack;
        duration = .5f;
        goalChanges = new Dictionary<GoalType, float>
        {
            {GoalType.Bathroom, 0 },
            {GoalType.Depression, 2 },
            {GoalType.Eat, -2 },
            {GoalType.Sleep, 0 },
            {GoalType.Thirst, 3 }
        };
    }
}
