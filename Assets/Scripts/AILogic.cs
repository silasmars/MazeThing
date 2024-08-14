using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent ]

public class AILogic : MonoBehaviour
{
    //Reference to other things
    public Transform key;
    public MoveDoor key;
    public Transform player;
    GameObject test;

    //Self reference
    public RandomWalk randomWalk;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
       {
           _agent = GetComponent<NavMeshAgent>();
       }

    // Update is called once per frame
    void Update()
       {
           if (door.isOpen == false)
              {
                  _agent.destination = key.position;
              }
       }

    private void OnTriggerEnter(Collider other)
       {
           if (key == other.gameObject) //other.GetComponent<Key>() != null)
              {
                  Destroy(other.gameObject);
              }
       }
}
