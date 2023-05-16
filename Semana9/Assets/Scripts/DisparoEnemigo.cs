using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigo : MonoBehaviour
{
    public GameObject jugador;
    public float velocidadBalaInicial = 10f;
    public float incrementoVelocidadBala = 1f;
    public float incrementoTamanoBala = 0.1f;

    private float velocidadBalaActual;
    private float tamanoBalaActual = 1f;

    void Start()
    {
        velocidadBalaActual = velocidadBalaInicial;
    }

    void Update()
    {
        velocidadBalaActual += incrementoVelocidadBala * Time.deltaTime;
        tamanoBalaActual += incrementoTamanoBala * Time.deltaTime;

        Vector3 direccion = (jugador.transform.position - transform.position).normalized;
        transform.Translate(direccion * velocidadBalaActual * Time.deltaTime);
        transform.localScale = Vector3.one * tamanoBalaActual;
    }
}
