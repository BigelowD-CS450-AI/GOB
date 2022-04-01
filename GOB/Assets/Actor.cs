using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Actor : MonoBehaviour
{
    public Text[] GoalValTextLabels;
    public Text CurrentAction;
    public Text[] GoalModTextLabels;
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
        new Do_Nothing()
    };

    Goal[] goals =
    {
        new Bathroom(1),
        new Depression(0),
        new Eat(2),
        new Sleep(0),
        new Thirst(1)
    };

    public void Start()
    {
        StartCoroutine(DecideAndDoAction());
    }
    public void Act(Action action)
    {
        int i = 0;
        foreach (Goal goal in goals)
        {
            goal.changeInsistance(action.goalChanges[goal.type]);
            GoalValTextLabels[i].text = goal.getValue().ToString();
            GoalModTextLabels[i].text = action.goalChanges[goal.type].ToString();
            ++i;
        }
        switch (action.type)
        {
            case ActionType.Drink_Soda:
                CurrentAction.text = "Drinking Soda";
                break;
            case ActionType.Drink_Water:
                CurrentAction.text = "Drinking Water"; 
                break;
            case ActionType.Eat_Meal:
                CurrentAction.text = "Eating a Meal";
                break;
            case ActionType.Eat_Snack:
                CurrentAction.text = "Eating a Snack";
                break;
            case ActionType.Go_To_Bathroom:
                CurrentAction.text = "Going to Bathroom";
                break;
            case ActionType.Sleep_In_Bed:
                CurrentAction.text = "Seeping in the Bed";
                break;
            case ActionType.Sleep_On_Couch:
                CurrentAction.text = "Sleeping on the Couch";
                break;
            case ActionType.Do_Nothing:
                CurrentAction.text = "Doing nothing";
                break;
            default:
                CurrentAction.text = "ERROR!!";
                break;
        }
    }
    //1 hour = SecondsPerHour seconds
    const float SecondsPerHour = 3.0f;
    IEnumerator DecideAndDoAction()
    {
        //Debug.Log("Made to cooroutine");
        Action action = ChooseAction();
        Act(action);
        foreach (Goal goal in goals)
            goal.passTime(action.getDuration());
        hoursPassed += action.getDuration();
        yield return new WaitForSeconds(action.getDuration() * SecondsPerHour);
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
