using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public GameObject jugador;
    public float velocidadMovimiento = 5f;
    public float distanciaMinima = 10f;
    public float tiempoDisparo = 2f;
    public GameObject balaPrefab;
    public Transform puntoDisparo;

    private float tiempoDisparoActual;

    private void Start()
    {
        tiempoDisparoActual = tiempoDisparo;
    }

    private void Update()
    {   
        Vector3 direccionJugador = jugador.transform.position - transform.position;
        direccionJugador.Normalize();

        transform.position -= direccionJugador * velocidadMovimiento * Time.deltaTime;

        transform.rotation = Quaternion.LookRotation(-direccionJugador);

        float distanciaJugador = Vector3.Distance(transform.position, jugador.transform.position);
        if (distanciaJugador <= distanciaMinima)
        {
            tiempoDisparoActual -= Time.deltaTime;
            if (tiempoDisparoActual <= 0)
            {
                Disparar();
                tiempoDisparoActual = tiempoDisparo;
            }
        }
    }

    private void Disparar()
    {
        GameObject bala = Instantiate(balaPrefab, puntoDisparo.position, puntoDisparo.rotation);
        bala.GetComponent<Rigidbody>().velocity = (jugador.transform.position - puntoDisparo.position).normalized * 10f;
    }
}