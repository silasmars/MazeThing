using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

   [RequireComponent(typeof(NavMeshAgent))]

public class AILogic : MonoBehaviour
{
          // Reference to other things
       public Transform key;
       public MoveDoor door;
       public Transform player;
       GameObject test;


       //Self reference
       public RandomWalk randomWalk;
       private NavMeshAgent _agent;

    // Start is called before the first frame update
    void Start()
       {
           _agent = GetComponent<NavMeshAgent>();
       }

    // Update is called once per frame
    void Update()
       {
           if (door.isOpen == false && key != null)
              {
                  _agent.destination = key.position;
              }
       }

    private void OnTriggerEnter(Collider other)
       {
           if (key == other.gameObject) //other.GetComponent<Key>() != null)
              {
                  door.unlockDoor = true;

                  Destroy(other.gameObject);
              }
       }
}
