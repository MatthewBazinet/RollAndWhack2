using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformToSphere : MonoBehaviour
{
    GameObject sphere;
    GameObject cube;
    public BallRoller spInfo;
    public bool respawn;
    public float resetDelay;
    public float resetLeft;

    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.FindWithTag("Sphere");
        cube = GameObject.FindWithTag("Cube");
        //cube.SetActive(false);
        spInfo = sphere.GetComponent<BallRoller>();
        cube.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
        respawn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.F)) && (spInfo.curHp > 0.0f))
        {
            if (sphere.active == true)
            {
                sphere.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                cube.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                cube.transform.localPosition = sphere.transform.localPosition;
                //cube.transform.localPosition = new Vector3(0.0f, 0.0f, -0.5f);
                cube.SetActive(true);
                sphere.SetActive(false);
            }
            else if (cube.active == true)
            {
                cube.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                sphere.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                sphere.transform.localPosition = cube.transform.localPosition;
                //sphere.transform.localPosition = new Vector3(0.0f, 0.0f, -0.5f);
                cube.SetActive(false);
                sphere.SetActive(true);
            }

        }

        if ((respawn == true) && (sphere.active == true))
        {
            sphere.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            cube.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            cube.transform.localPosition = sphere.transform.localPosition;
            //cube.transform.localPosition = new Vector3(0.0f, 0.0f, -0.5f);
            cube.SetActive(true);
            sphere.SetActive(false);
        }


        resetLeft -= Time.deltaTime;
        if ((resetLeft <= 0.0f) && (respawn))
        {
            spInfo.curHp = spInfo.maxHp;
            respawn = false;
        }
        if ((spInfo.curHp <= 0.0f) && (!respawn))
        {
            resetLeft = resetDelay;
            respawn = true;
        }
    }
}
