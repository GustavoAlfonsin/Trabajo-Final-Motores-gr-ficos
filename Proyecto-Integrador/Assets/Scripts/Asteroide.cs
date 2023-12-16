using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide : MonoBehaviour
{
    public int vida;
    public int puntos;
    private Puntaje controJuego;

    private void Start()
    {
        controJuego = GameObject.FindGameObjectWithTag("puntaje").GetComponent<Puntaje>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            vida--;
            if (vida <= 0)
            {
                Destroy(gameObject);
                controJuego.sumarPuntos(puntos);
            }
        }
        else if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            controJuego.FinDelJuego();
        }
    }

}
