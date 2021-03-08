using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Andar : MonoBehaviour
{
    float andar;
    

    // Start is called before the first frame update
    void Start()
    {
        andar = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate((andar * Time.deltaTime), 0, 0);
        }
        
    }
}
