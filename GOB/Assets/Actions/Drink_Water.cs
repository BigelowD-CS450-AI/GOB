using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink_Water : Action
{
    public Drink_Water()
    {
        type = ActionType.Drink_Water;
        duration = .5f;
        goalChanges = new Dictionary<GoalType, float>
        {
            {GoalType.Bathroom, 2 },
            {GoalType.Depression, -0.25f },
            {GoalType.Eat, 0 },
            {GoalType.Sleep, 0 },
            {GoalType.Thirst, -5 }
        };
    }
}
