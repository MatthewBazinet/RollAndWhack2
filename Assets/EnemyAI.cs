using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI: MonoBehaviour
{
    NavMeshAgent myNavMeshAgent;
    float oldtime = 0.0f;
    Vector3 position = new Vector3(0, 0, 0);
    public GameObject Sphere;
    public GameObject Cube;

    // Start is called before the first frame update
    void Start()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();
        if (Sphere.activeInHierarchy)
        {
            position = Sphere.transform.position;
        } else if (Cube.activeInHierarchy)
        {
            position = Cube.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > 2 + oldtime)
        {
            if (Sphere.activeInHierarchy)
            {
                position = Sphere.transform.position;
            }
            else if (Cube.activeInHierarchy)
            {
                position = Cube.transform.position;
            }

            oldtime = Time.time;
        }
        myNavMeshAgent.SetDestination(position);
    }


}
