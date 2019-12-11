using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
    private float velocidad = 20f;
    // Start is called before the first frame update
    
    void Start()
    {

    }



    void Update()
    {

        transform.position += new Vector3(0,0 , Time.deltaTime * velocidad);
        if (transform.position.z > 50)
        {
            Destroy(gameObject);
        };
    }

}
