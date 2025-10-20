using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador_1 : MonoBehaviour
{
    public float velocidad = 10F;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moverHorizontal = Input.GetAxis("Horizontal");

        float moverVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3 (moverHorizontal*velocidad, rb.velocity.y, moverVertical*velocidad);

        rb.velocity = movimiento;
    }

    
}
