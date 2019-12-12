using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    float curHP = 0;
    float maxHP = 0;
    public GameObject Sphere;
    public GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Sphere.activeInHierarchy)
        {
            curHP = Sphere.GetComponent<BallRoller>().curHp; // Obtaining Component for Current HP.
            maxHP = Sphere.GetComponent<BallRoller>().maxHp;
        }
        else
        {
            curHP = Cube.GetComponent<PlayerController>().curHp;
            maxHP = Cube.GetComponent<PlayerController>().maxHp;
        }

        curHP = (curHP / maxHP); // Converted to percentage. (1.0 = 100)

        Vector3 scale = transform.localScale;
        Vector3 pos = transform.localPosition;
        if (curHP > 0)
        {
            scale.x = curHP;
        } else
        {
            scale.x = 0;
        }
        transform.localScale = scale;
    }
}
