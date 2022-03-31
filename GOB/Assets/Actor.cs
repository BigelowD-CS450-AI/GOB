using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    float hoursPassed = 0;
    Action[] actions =
    {
        new Drink_Soda(),
        new Drink_Water(),
        new Eat_Meal(),
        new Eat_Snack(),
        new Go_To_Bathroom(),
        new Sleep_In_Bed(),
        new Sleep_On_Couch(),
    };

    Goal[] goals =
    {
        new Eat(2),
        new Bathroom(1),
        new Sleep(0)
    };

    public void Start()
    {
        StartCoroutine(DecideAndDoAction());
    }
    public void Act(Action action)
    {
        switch (action.type)
        {
            case ActionType.Drink_Soda:
                Debug.Log("Hour: " + hoursPassed + "  Drinking Soda");
                break;
            case ActionType.Drink_Water:
                Debug.Log("Hour: " + hoursPassed + "  Drinking Water"); 
                break;
            case ActionType.Eat_Meal:
                Debug.Log("Hour: " + hoursPassed + "  Eating a Meal");
                break;
            case ActionType.Eat_Snack:
                Debug.Log("Hour: " + hoursPassed + "  Eating a Snack");
                break;
            case ActionType.Go_To_Bathroom:
                Debug.Log("Hour: " + hoursPassed + "  Going to Bathroom");
                break;
            case ActionType.Sleep_In_Bed:
                Debug.Log("Hour: " + hoursPassed + "  Seeping in the Bed");
                break;
            case ActionType.Sleep_On_Couch:
                Debug.Log("Hour: " + hoursPassed + "  Sleeping on the Couch");
                break;
            default:
                Debug.Log("Shouldnt be here");
                break;
        }
    }
    IEnumerator DecideAndDoAction()
    {
        //Debug.Log("Made to cooroutine");
        Action action = ChooseAction();
        Act(action);
        foreach (Goal goal in goals)
            goal.passTime(action.getDuration());
        hoursPassed += action.getDuration();
        yield return new WaitForSeconds(action.getDuration());
        StartCoroutine(DecideAndDoAction());
    }

    public Action ChooseAction()
    {
/*        Goal topGoal = goals[0];
        foreach (Goal goal in goals)
            if (goal.value > topGoal.value)
                topGoal = goal;*/

        Action bestAction = null;
        float bestValue = Mathf.Infinity;
        foreach (Action action in actions)
        {
            float value = discontentment(action,goals);

            if (value < bestValue)
            {
                bestValue = value;
                bestAction = action;
            }
        }
        
        return bestAction;
    }
    public float discontentment(Action action, Goal[] goals)
    {
        float discontentment = 0;

        foreach(Goal goal in goals)
        {
            float newValue = goal.getValue() + action.getGoalChange(goal);
            newValue += action.getDuration() * goal.getChange();
            discontentment += goal.getDiscontentment(newValue);
        }
        return discontentment;
    }
}
