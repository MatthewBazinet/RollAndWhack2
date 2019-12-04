using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float curHP = GameObject.Find("Cube (Player)").GetComponent<PlayerController>().curHp; // Obtaining Component for Current HP.
        float maxHP = GameObject.Find("Cube (Player)").GetComponent<PlayerController>().maxHp;

        curHP = (curHP / maxHP); // Converted to percentage. (1.0 = 100)

        Vector3 scale = transform.localScale;
        Vector3 pos = transform.localPosition;
        scale.x = curHP;

        transform.localScale = scale;
    }
}
