using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink_Soda : Action
{
    public Drink_Soda()
    {
        type = ActionType.Drink_Soda;
        duration = .5f;
        goalChanges = new Dictionary<GoalType, float>
        {
            {GoalType.Bathroom, 2 },
            {GoalType.Depression, 1 },
            {GoalType.Eat, -1 },
            {GoalType.Sleep, 0 },
            {GoalType.Thirst, 1 }
        };
    }
}
