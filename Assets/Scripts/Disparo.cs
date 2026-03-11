using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject balaPrefab;
    public float balaVelocidad;
    public GameObject balaInicio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject BalaTemporal = Instantiate(balaPrefab, balaInicio.transform.position, balaInicio.transform.rotation) as GameObject;
            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
            rb.AddForce(BalaTemporal.transform.right * balaVelocidad);
            Destroy(BalaTemporal, 3.0f);
        }
    }
}
