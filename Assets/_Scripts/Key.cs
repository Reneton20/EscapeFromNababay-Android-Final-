using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    public Text complete;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Collect();
        }
    }

    void Collect()
    {
        this.gameObject.SetActive(false);
        complete.gameObject.SetActive(true);
    }
}
