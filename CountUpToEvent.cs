using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Feedbacks;

//This class is a number counter for playing feedbacks. It has a current number and a target number.
//This class counts through unity events
//It can play feedbacks on each count and specify feedbacks if it is under, on &/or over the taget number.  
public class CountToPlayFeedback : MonoBehaviour
{
    //The Number the counter is currently on
    public int currentNumber = 0;
    //The Number the counter is trying to reach
    public int targetNumber;

    //Feedbacks to be used with MoreMountainsFeels
    public MMFeedbacks underMaxNumberCountFeedback;
    public MMFeedbacks targetCountFeedback;
    public MMFeedbacks overMaxNumberCountFeedback;

    //Do you want to reset the counter once it reaches its target number?
    public bool ResetCountOnTargetNumber;
 
    // This counts the current number up one. Each count it checks if it is under, or over the target number. 
    // It runs a feedback if assigned to each of the above.
    public void CountUp()
    {
        currentNumber++;
         if(currentNumber == targetNumber)
        {
          targetCountFeedback?.PlayFeedbacks();
          // If the ResetCountOnTargetNumber returns true and we are over the target number, then it sets the current number to 0, if not it continues to count up.  
          if(ResetCountOnTargetNumber == true)
          {
            currentNumber = 0;
          }  
        }
        else
        {
          if(currentNumber <= targetNumber)
          {
            underMaxNumberCountFeedback?.PlayFeedbacks();
          }
          if(currentNumber >= targetNumber)
          {
            overMaxNumberCountFeedback?.PlayFeedbacks();
          }
        }
    }
    
    public void CountDown()
    {
        currentNumber--;
    }


    // This Resets the counter to 0
    public void ResetCount()
    {
      currentNumber = 0;
    }
}
