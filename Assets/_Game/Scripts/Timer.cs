using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Image TimeImage;
   
    public void SetTimer(float curDistance, float distance)
    {
        TimeImage.fillAmount = curDistance/distance;
    }
    public void ActiveTimer()
    {
        gameObject.SetActive(true);
    }
    public void DeActiveTimer()
    {
        gameObject.SetActive(false);
    }
}
