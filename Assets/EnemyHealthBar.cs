using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    public EnemyTarget enemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float curHP = enemy.CurHp; // Obtaining Component for Current HP.
        float maxHP = enemy.MaxHp;
        curHP = (curHP / maxHP); // Converted to percentage. (1.0 = 100)

        Vector3 scale = transform.localScale;
        Vector3 pos = transform.localPosition;
        scale.x = curHP;

        transform.localScale = scale;
        Debug.Log(curHP);
    }
}
