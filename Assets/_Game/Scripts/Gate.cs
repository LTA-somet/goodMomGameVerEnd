using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gate : MonoBehaviour
{
    public GameObject goodCarpet; 
    public GameObject badCarpet;
    public GameObject goodGate;
    public GameObject badGate;
    public GameObject goodBackup;
    public GameObject badBackup;

    [SerializeField] private CharacterMove character;

    private void Update()
    {
        if (character.isGood)
        {
            goodGate.SetActive(false);
            goodCarpet.SetActive(true);
            character.isGood = false;
        StartCoroutine(  Active(goodBackup));
          
            character.finalScore += 3;
        }
        if (character.isBad )
        {
            badGate.SetActive(false);
            badCarpet.SetActive(true);
           character.isBad = false;
           badBackup.SetActive(true);
            
            character.finalScore -= 4;
            StartCoroutine(Active(badBackup));
        }
        

    }
    public IEnumerator Active(GameObject rug)
    {
        yield return new WaitForSeconds(2.2f);
        rug.SetActive(true);
    }
 
}
