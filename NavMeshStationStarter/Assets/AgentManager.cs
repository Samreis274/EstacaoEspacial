using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentManager : MonoBehaviour
{
    //Cria uma array de gameobjets
    GameObject[] agents;
    // Start is called before the first frame update
    void Start()
    {
        //Verifica a tag dos gameobjets
        agents = GameObject.FindGameObjectsWithTag("ai");
    }

    // Update is called once per frame
    void Update()
    {
        //Input do botao do mouse
        if (Input.GetMouseButtonDown(0))
        {
            //Criando uma variavel RaycastHit
            RaycastHit hit;

            //Cria um Raycast da posicao do mouse
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out hit, 100))
            {
                //Foreach para que ele possa sempre repetir a funçao
                foreach (GameObject a in agents)
                    //Seta o destino do player no navemesh dele
                    a.GetComponent<AIcontrol>().agent.SetDestination(hit.point);
            }
        }
    }
}
