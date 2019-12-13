using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabeza : MonoBehaviour
{
    private string mouseXInputName, mouseYInputName;
    private float mouseSensitivity;
    private float xAxisClamp;
    private float tiempoVida = 0;
    void Start()
    {
        mouseXInputName = "Mouse X";
        mouseYInputName = "Mouse Y";
        mouseSensitivity = 10;
    }

    private void Awake()
    {
        LockCursor();
        xAxisClamp = 0.0f;
    }

    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        CameraRotation();
        LockCursor();
        //if (transform.rotation.y > -0.33 && transform.rotation.y < 0.33)
        //{
           // transform.rotation = Quaternion.Euler(0, Input.mousePosition.x, 0);
            //Debug.Log(transform.rotation.y);


        //}

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
        Disparar();
    }

    private void CrearBala()
    {
        Instantiate(Resources.Load("Bala"), new Vector3(transform.position.x, transform.position.y, transform.position.z + 2), Quaternion.identity);
    }



    private void CameraRotation()
    {
        float mouseX = Input.GetAxis(mouseXInputName) * mouseSensitivity + Time.deltaTime;
        xAxisClamp += mouseX;

        if(xAxisClamp >=30.0f)
        {
            xAxisClamp = 30;
            mouseX = 0.0f;
        }else if (xAxisClamp <= -30.0f)
        {
            xAxisClamp = -30;
            mouseX = 0.0f;
        }


        transform.Rotate(transform.up * mouseX);
    }

}
