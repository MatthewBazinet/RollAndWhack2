using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float direction;
    public float distance; // distance to spawn enemy
    public float delayTime; // delay between spawns
    public float delayLeft; // time until next spawn
    public Transform tf; // transform to use for refernce point
    public GameObject enemy; // enemy to spawn

    // Start is called before the first frame update
    void Start()
    {
        delayLeft = delayTime;
        direction = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (delayLeft <= 0.0f)
        {
            direction = Random.Range(0.0f, 360.0f);
            Instantiate(enemy, 
                tf.position + new Vector3(distance * Mathf.Cos(direction), 
                0.0f, distance * Mathf.Sin(direction)),
                new Quaternion());

            delayLeft = delayTime;
        }
        delayLeft -= Time.deltaTime;
    }
}
