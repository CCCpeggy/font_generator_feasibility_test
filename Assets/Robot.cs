using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    bool isRotation = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotation)
        {
            Vector3 rotate = new Vector3(0, 1, 0);
            gameObject.transform.Rotate(rotate);
        }
        if (Input.GetKey(KeyCode.W))
        {
            forward(Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            left(Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            back(Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            right(Time.deltaTime);
        }
    }

    public void forward(float time = 1)
    {
        gameObject.transform.Translate(Vector3.forward * time);
    }

    public void back(float time = 1)
    {
        gameObject.transform.Translate(Vector3.back * time);
    }

    public void left(float time = 1)
    {
        gameObject.transform.Translate(Vector3.left * time);
    }

    public void right(float time = 1)
    {
        gameObject.transform.Translate(Vector3.right * time);
    }

    public void RotationButton()
    {
        isRotation = !isRotation;
    }
}
