using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  [SerializeField] private Camera Camera;   
  [SerializeField] private GameObject camIntro;   
  [SerializeField] private GameObject camFollow;   
   // [SerializeField] private Vector3 offset;
   public bool demoCamera=true;
 public bool end=false;
    private void Start()
    {
     //   Camera.transform.position = new Vector3(0, 3f, 180f);
    //    Camera.transform.DOMove(new Vector3(0, 3f, 126f), 4f);
        StartCoroutine(StartCamIntro());
    }
    void Update()
    {
        //if (demoCamera==false&&end==false)
           // Camera.transform.position = offset + transform.position;
      //  StartCoroutine(StartCam());
       
    }
    private IEnumerator StartCam()
    {     
        yield return new WaitForSeconds(4.5f);
       
        demoCamera =false;
    } 
    private IEnumerator StartCamIntro()
    {     
        yield return new WaitForSeconds(1f);

        camIntro.gameObject.SetActive(false);
    }
     public IEnumerator CamZoom()
    {
        
        yield return new WaitForSeconds(2.8f);
        Camera.transform.DOMove(new Vector3(0, 2.21f, 186.4f),1f);
      camFollow.gameObject.SetActive(false);
    }
}
