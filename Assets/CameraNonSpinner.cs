using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraNonSpinner : MonoBehaviour
{

    public GameObject Sphere;
    public GameObject Cube;
    public Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Sphere.activeInHierarchy)
   
        {
            transform.position = offset + Sphere.transform.position;

            transform.RotateAround(Sphere.transform.position, Vector3.up, Input.GetAxis("Mouse X"));
        }
        else
        {
            transform.position = offset + Cube.transform.position;

            transform.RotateAround(Cube.transform.position, Vector3.up, Input.GetAxis("Mouse X"));
        }

    }


}


