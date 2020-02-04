using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float force = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * force);

        if (Input.GetKey(KeyCode.S))
            gameObject.GetComponent<Rigidbody>().AddForce(-transform.forward * force);

        if (Input.GetKey(KeyCode.A))
            gameObject.GetComponent<Rigidbody>().AddForce(-transform.right * force);

        if (Input.GetKey(KeyCode.D))
            gameObject.GetComponent<Rigidbody>().AddForce(transform.right * force);
    }
}
