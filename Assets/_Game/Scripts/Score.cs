using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Image ScoreImage;
    public Text scoreTxt;
    public RectTransform pointer;
    public RectTransform background;
   public void UpdateScore(string text,Color color)
    {
        if(scoreTxt != null) scoreTxt.text = text;
        scoreTxt.color=color;
        float newX = Mathf.Lerp(background.rect.xMin, background.rect.xMax, ScoreImage.fillAmount);

       
        pointer.anchoredPosition = new Vector2(newX/2.54f, pointer.anchoredPosition.y);
    }
    public void SetScore(float score)
    {
        ScoreImage.fillAmount = score / 10;
    }
    public void ActiveScore()
    {
        gameObject.SetActive(true);
    } public void DeActiveScore()
    {
        gameObject.SetActive(false);
    }
}
