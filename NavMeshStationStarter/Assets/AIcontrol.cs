using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIcontrol : MonoBehaviour
{
    //Setando a variavel NaveMesh
    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        //pegando o component NavMesh
        agent = this.GetComponent<NavMeshAgent>();
    }

}
