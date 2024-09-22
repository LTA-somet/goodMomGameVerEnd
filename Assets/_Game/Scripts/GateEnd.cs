using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateEnd : MonoBehaviour
{
    [SerializeField] private GameObject goodStage;
    [SerializeField] private GameObject badStage;
    [SerializeField] private CharacterMove character;
    public GameObject goodGate;
    public GameObject badGate;
    public GameObject goodFlower;
    public GameObject badFlower;
   
    private void Update()
    {
        if (character.isGood2  )
        {
            goodGate.SetActive(false);  
            goodFlower.SetActive(false);
            goodStage.transform.DOScale(Vector3.one, 1.5f);
            
            character.isGood = false;
            character.finalScore += 2;
        }
        if (character.isBad2 )
        {
            badGate.SetActive(false);   
            badFlower.SetActive(false);
            badStage.transform.DOScale(Vector3.one, 1.5f);
            
            character.isBad = false;
            character.finalScore -= 3;
        }
      

    }
}
