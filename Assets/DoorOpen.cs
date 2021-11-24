using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject door;
    public GameObject doorOpen;

    private void OnTriggerEnter(Collider other)
    {
        door.SetActive(false);
        doorOpen.SetActive(true);
        StartCoroutine(FinishCut());

    }
    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(2);
        doorOpen.SetActive(false);
    }

    
    
    

}
