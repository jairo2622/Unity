using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_personaje : MonoBehaviour
{

    public float velocidad=5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcesarMovimiento();
    }

    void ProcesarMovimiento()
    {
        float inputMovimiento = Input.GetAxis("Horizontal");
        Rigidbody2D rigidbody=GetComponent<Rigidbody2D>();

        rigidbody.velocity=new Vector2(inputMovimiento * velocidad, rigidbody.velocity.y);
    }
}
