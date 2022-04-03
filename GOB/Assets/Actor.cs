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
                transform.position = new Vector3(0.0f, 1.5f, 7.5f);
                transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                break;
            case ActionType.Drink_Water:
                CurrentAction.text = "Drinking Water"; 
                transform.position = new Vector3(3.0f, 1.5f, 7.5f);
                transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                break;
            case ActionType.Eat_Meal:
                CurrentAction.text = "Eating a Meal";
                transform.position = new Vector3(-2.0f, 1.0f, 6.0f);
                transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                break;
            case ActionType.Eat_Snack:
                CurrentAction.text = "Eating a Snack";
                transform.position = new Vector3(0.0f, 1.5f, 7.5f);
                transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                break;
            case ActionType.Go_To_Bathroom:
                CurrentAction.text = "Going to Bathroom";
                transform.position = new Vector3(5.5f, 1.5f, 0.0f);
                transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                break;
            case ActionType.Sleep_In_Bed:
                CurrentAction.text = "Seeping in the Bed";
                transform.position = new Vector3(7.25f, 1.5f, 7f);
                transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
                break;
            case ActionType.Sleep_On_Couch:
                CurrentAction.text = "Sleeping on the Couch";
                transform.position = new Vector3(-6.6f, 1.5f, 2.3f);
                transform.rotation = Quaternion.Euler(80.0f, 0.0f, 0.0f);
                break;
            case ActionType.Do_Nothing:
                CurrentAction.text = "Doing nothing";
                transform.position = new Vector3(0.0f, 1.5f, 0.0f);
                transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                break;
            default:
                CurrentAction.text = "ERROR!!";
                break;
        }
    }
    //1 hour = SecondsPerHour seconds
    const float SecondsPerHour = 2.0f;
    IEnumerator DecideAndDoAction()
    {
        //Debug.Log("Made to cooroutine");
        Action action = ChooseAction();
        foreach (Goal goal in goals)
            goal.passTime(action.getDuration());
        hoursPassed += action.getDuration();
        Act(action);
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
            float newValue = Mathf.Max(0.0f, goal.getValue() + action.getGoalChange(goal));
            newValue += action.getDuration() * goal.getChange() * 0.25f;
            discontentment += goal.getDiscontentment(newValue);
        }
        return discontentment;
    }
}
