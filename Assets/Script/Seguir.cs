using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : MonoBehaviour
{
    public float posiçãoDoInimigo;

    private Transform posiçãoDoJogador;

    // Start is called before the first frame update
    void Start()
    {
        posiçãoDoJogador = GameObject.FindGameObjectWithTag("Alvo").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(posiçãoDoJogador.gameObject != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, posiçãoDoJogador.position, posiçãoDoInimigo * Time.deltaTime);
        }
    }
}
