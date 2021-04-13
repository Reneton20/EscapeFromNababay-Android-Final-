using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpbutton : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpforce = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            rb.AddForce(new Vector3(0f, jumpforce, 0), ForceMode.Force);
        }
    }
}
