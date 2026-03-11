using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TanqueMov : MonoBehaviour
{
    public GameObject referencia;
    private float _velocidadRot = 0.1f;
    private float _velocidadMov = 1.5f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            rb.AddForce((referencia.transform.position - transform.position) * _velocidadMov);
        }
        if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            rb.AddForce((transform.position - referencia.transform.position) * _velocidadMov);
        }
        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            this.transform.Rotate(0, -_velocidadRot, 0);
        }
        if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            this.transform.Rotate(0, _velocidadRot, 0);
        }
    }
}
