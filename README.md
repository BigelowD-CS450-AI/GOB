# Goal Oriented Behaviour (GOB) Production
### [Playable Link](https://bigelowd-cs450-ai.github.io/GOB/)

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
    * Sleep -0.5
* **Drink_Soda** 
  * Duration 0.5
  * Goal Modifiers
    * Bathroom +1
    * Depression +1
    * Eat -1
    * Thirst -1
* **Drink_Water**
  * Duration 0.5
  * Goal Modifiers
    * Bathroom +3
    * Depression -1
    * Thirst -5
* **Eat_Meal**
  * Duration 1.5
  * Goal Modifiers
    * Depression 1
    * Eat -7
    * Sleep +1
* **Eat_Snack**
  * Duration 0.5
  * Goal Modifiers
    * Depression +1
    * Eat -2
* **Go_To_Bathroom**
  * Duration 0.5
  * Goal Modifiers
    * Bathroom -100
    * Eat +1
    * Sleep +1
    * Thirst +1
* **Sleep_In_Bed**
  * Duration 6.0
  * Goal Modifiers
    * Depression -2
    * Sleep -100
* **Sleep_On_Couch:** 
  * Duration 1.5
  * Goal Modifiers
    * Bathroom -0.5
    * Depression +1
    * Eat -0.5
    * Sleep -3
    * Thirst -0.5
