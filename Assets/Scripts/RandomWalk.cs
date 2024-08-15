using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomWalk : MonoBehaviour
{
       public float _Range = 25.0f;


       UnityEngine.AI.NavMeshAgent _Agent;

    // Start is called before the first frame update
    void Start()
       {
           _Agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
       }

    // Update is called once per frame
    void Update()
       {
              // && And
              // || Or
              // == Equal to
              // != NOT Equal To
              // < Less Than
              // > Greater Than
              // <= Less Than or Equal To
              // => Greater Than or Equal To


              //If AI is still moving
           if (_Agent.pathPending || !_Agent.isOnNavMesh || _Agent.remainingDistance > 0.1f)
              {
                     // Exit function (update) here
                  return;
              }


              // Choose a random point
           Vector3 randomPosition = _Range * Random.insideUnitCircle;

           randomPosition = new Vector3(randomPosition.x, 0, randomPosition.y);

           _Agent.destination = transform.position + randomPosition;
    }
}
