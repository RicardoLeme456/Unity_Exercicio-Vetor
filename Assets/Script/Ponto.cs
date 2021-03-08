using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ponto : MonoBehaviour
{
    public Transform[] pontosDePassagem;
    public int rapidez;

    private int indiceDePontoDePassagem;
    private float distância;

    // Start is called before the first frame update
    void Start()
    {
        indiceDePontoDePassagem = 0;
        transform.LookAt(pontosDePassagem[indiceDePontoDePassagem].position);
        
    }

    // Update is called once per frame
    void Update()
    {
        distância = Vector3.Distance(transform.position, pontosDePassagem[indiceDePontoDePassagem].position);
        if(distância < 1f)
        {
            AumentarIndice();
        }
        Patrulha();
    }

    void Patrulha()
    {
        transform.Translate(Vector3.forward * rapidez * Time.deltaTime);
    }

    void AumentarIndice()
    {
        indiceDePontoDePassagem++;
        if (indiceDePontoDePassagem >= pontosDePassagem.Length)
        {
            indiceDePontoDePassagem = 0;
        }
        transform.LookAt(pontosDePassagem[indiceDePontoDePassagem].position);
    }

   
}
