using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeBar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float chargeTime = GameObject.Find("Cube (Player)").GetComponent<PlayerController>().chargeTime;
        float maxCharge = GameObject.Find("Cube (Player)").GetComponent<PlayerController>().chargeMax;

        chargeTime = chargeTime / maxCharge;

        Vector3 scale = transform.localScale;
        Vector3 pos = transform.localPosition;
        scale.x = 1 - chargeTime;

        transform.localScale = scale;
    }
}
