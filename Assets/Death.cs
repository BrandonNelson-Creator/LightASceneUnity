using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject deathSound;
    public GameObject attackMonster;
    public GameObject currentMonster;
    public GameObject deathCam;
    public GameObject sceneCut;
    public GameObject player;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        deathSound.SetActive(true);
        attackMonster.SetActive(true);
        currentMonster.SetActive(false);
        deathCam.SetActive(true);
        player.SetActive(false);
        sceneCut.SetActive(false);

    }
}
