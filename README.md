# Goal Oriented Behaviour (GOB) Development
### [Playable Link](https://bigelowd-cs450-ai.github.io/GOB/) This WebGL is the production, to play development please contact me to change what branch the github pages targets.

This is a implementation of Millingotns GOB pseudocode. No all possible actions trigger bsaed on current weights and values. This will be fixed in production.

### Goals
* **Bathroom**
* **Depression**
* **Eat**
* **Sleep**
* **Thirst**

### Actions
* **Do_Nothing**  
  * Duration 1
  * Goal Modifiers
    * Depression +0.5
* **Drink_Soda** 
  * Duration 0.5
  * Goal Modifiers
    * Bathroom +2
    * Depression +1
    * Eat -1
    * Thirst +1
* **Drink_Water**
  * Duration 0.5
  * Goal Modifiers
    * Bathroom +3
    * Depression -1
    * Thirst -5
* **Eat_Meal**
  * Duration 1.5
  * Goal Modifiers
    * Depression -3
    * Eat -5
    * Sleep +1
    * Thirst +1
* **Eat_Snack**
  * Duration 0.5
  * Goal Modifiers
    * Depression +2
    * Eat -3
    * Thirst +3
* **Go_To_Bathroom**
  * Duration 0.5
  * Goal Modifiers
    * Bathroom -4
* **Sleep_In_Bed**
  * Duration 6.0
  * Goal Modifiers
    * Depression -2
    * Sleep -5
* **Sleep_In_Bed:** 
  * Duration 1.5
  * Goal Modifiers
    * Depression 3
    * Sleep -2
