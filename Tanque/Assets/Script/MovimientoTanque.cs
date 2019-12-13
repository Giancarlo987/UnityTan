using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTanque : MonoBehaviour
{
    private Rigidbody rb;
    private float fuerzaIzqDer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float translationH = Input.GetAxis("Horizontal");
        float translationV = Input.GetAxis("Vertical");
        transform.Translate(0, 0, translationV * Time.deltaTime * 10);
        transform.Translate(translationH * Time.deltaTime * 10, 0, 0);

    }




}
