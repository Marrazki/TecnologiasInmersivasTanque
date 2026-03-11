using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarTiro : MonoBehaviour
{
    private float _velocidadRotTiro = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Debug.Log("Izq");
            this.transform.Rotate(0, -_velocidadRotTiro, 0);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            Debug.Log("Der");
            this.transform.Rotate(0, _velocidadRotTiro, 0);
        }
    }
}
