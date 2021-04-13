using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keycard : MonoBehaviour
{
    public Text complete;
    public AudioSource soundz;
    public GameObject ach;
    public float sec = 5f;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            soundz.Play();
            ach.gameObject.SetActive(true);
            complete.gameObject.SetActive(true);
        }
    }


    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            ach.gameObject.SetActive(false);
        }
    }

    /* void Collect()
     {
         soundz.Play();
         ach.gameObject.SetActive(true);
         //this.gameObject.SetActive(false);
         complete.gameObject.SetActive(true);
     }*/


}
