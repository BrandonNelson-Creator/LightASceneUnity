using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{

    public GameObject staticLights;
    public GameObject lightShutoff;
    public GameObject player;
    public GameObject cam;
    public GameObject music;
    public GameObject musicChase;
    public Vector3 vector;
    
    public GameObject player1;

    private void OnTriggerEnter(Collider other)
    {


        staticLights.SetActive(false);
        lightShutoff.SetActive(true);
        player.SetActive(false);
        cam.SetActive(true);
        music.SetActive(false);
        musicChase.SetActive(true);
        StartCoroutine(FinishCut());
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(9);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
       
       

        player1.SetActive(true);
        cam.SetActive(false);
        


    }
}
