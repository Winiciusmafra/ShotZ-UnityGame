using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public float Velocidade = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float eixoX = Input.GetAxis("Horizontal"); 
        float eixoZ = Input.GetAxis("Vertical"); 
        Vector3 direcao = new Vector3(eixoX, 0, eixoZ);
        transform.Translate(direcao * Velocidade * Time.deltaTime);
    }
}
