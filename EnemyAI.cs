using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent enemy;
    public GameObject player;
    private Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target = player.transform.position;
        enemy.SetDestination(target);
    }
}
   /* public void moveEnemy() 
    {
        enemy.SetDestination(player);
    } */

