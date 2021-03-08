using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Trajeto : MonoBehaviour
{

    NavMeshAgent meuNavMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        meuNavMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            definirUmaRotaDeDestino();
        }
    }

    private void definirUmaRotaDeDestino()
    {
        RaycastHit hit;
        Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(raio, out hit))
        {
            meuNavMeshAgent.SetDestination(hit.point);
        }
    }
}
