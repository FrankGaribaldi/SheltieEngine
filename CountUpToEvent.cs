using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Feedbacks;


public class CountUpToEvent : MonoBehaviour
{
    public int currentNumber = 0;
    public int maxNumber;
    public MMFeedbacks EndCountFeedback;

    public void CountUp()
    {
        currentNumber++;
         if(currentNumber == maxNumber)
        {
          EndCountFeedback?.PlayFeedbacks();
        }
    }

}
