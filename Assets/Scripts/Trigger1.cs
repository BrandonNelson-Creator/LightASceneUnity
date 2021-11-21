using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{
    public GameObject Player;
    public GameObject SceneCam;
    public GameObject Trigger;
    public float movementX;
    public float movementY;
    public float movementZ;
    public Transform player;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        SceneCam.SetActive(true);
        Player.SetActive(false);
        Trigger.SetActive(true);

        StartCoroutine(FinishCut());
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(7);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        Player.SetActive(true);
        Trigger.SetActive(false);
        SceneCam.SetActive(false);
        Player.transform.position = new Vector3(-42.14f, 0.9549f, -29.361f);
    }




    // Update is called once per frame




}
