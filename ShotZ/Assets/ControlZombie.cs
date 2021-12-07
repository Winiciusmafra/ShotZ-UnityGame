using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlZombie : MonoBehaviour
{
    public GameObject Jogador;
    public float Velocidade = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 direcao = Jogador.transform.position - transform.position; 
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + direcao.normalized * Velocidade * Time.deltaTime);
    }
}
