using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTanque : MonoBehaviour
{
    private Rigidbody rb;
    private float fuerzaIzqDer;
    private float tiempoVida = 0;
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
        Disparar();
    }

    private void Disparar()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            tiempoVida -= Time.deltaTime;
            if (tiempoVida <= 0)
            {
                CrearBala();
                tiempoVida = 0.2f;
            }
        }
    }

    private void CrearBala()
    {
        Instantiate(Resources.Load("Bala"), new Vector3(transform.position.x+2.6f, transform.position.y, transform.position.z), Quaternion.identity);
    }


}
