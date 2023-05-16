using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public float velocidadInicial = 5f;
    public float incrementoVelocidad = 0.5f;

    private float velocidadActual;

    void Start()
    {
        velocidadActual = velocidadInicial;
    }

    void Update()
    {
        velocidadActual += incrementoVelocidad * Time.deltaTime;
        transform.Translate(Vector3.forward * velocidadActual * Time.deltaTime);
    }
}