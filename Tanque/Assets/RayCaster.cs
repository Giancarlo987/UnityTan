using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    public GameObject canhon;
    private Vector3 posicionIni;
    private Vector3 posicionFin;
    private LineRenderer laser;

    // Start is called before the first frame update
    void Start()
    {
        laser = transform.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        posicionIni= canhon.GetComponent<Transform>().position;
        posicionIni.z += 60;
        //.startColor = Color.black;
        //laser.endColor = Color.black;
        laser.SetPosition(0, posicionIni);
        posicionFin = canhon.GetComponent<Transform>().position;
        posicionIni.z = 0;
        laser.SetPosition(1, posicionFin);
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Debug.DrawRay(ray.origin, ray.direction * 100, Color.black);
    }
}
