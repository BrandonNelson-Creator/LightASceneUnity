using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{

    public GameObject staticLights;
    public GameObject lightShutoff;

    private void OnTriggerEnter(Collider other)
    {


        staticLights.SetActive(false);
        lightShutoff.SetActive(true);
        StartCoroutine(FinishCut());
    }

    IEnumerator FinishCut()
    {

        yield return new WaitForSeconds(7);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        staticLights.SetActive(true);
        lightShutoff.SetActive(false);
        
    }
}
