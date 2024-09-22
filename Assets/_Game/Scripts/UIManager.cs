using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject winDialog;
    public GameObject loseDialog;
    public GameObject tutDialog;
   
   public void Tutorial(bool boolean)
    {
        tutDialog.gameObject.SetActive(boolean);
    }
    public void LoseGame()
    {
        loseDialog.gameObject.SetActive(true);
    }

    public void WinGame()
    {
        winDialog.gameObject.SetActive(true);
    }
}
