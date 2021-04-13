using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Restore : MonoBehaviour
{
    [SerializeField] private float res;
    [SerializeField] private Texthealth Health;

    // Start is called before the first frame update
    public void restore()
    {
        Health.playerhealth = Health.playerhealth + res;
        Health.UpdateHealth();
        this.gameObject.SetActive(false);
    }

   
}
