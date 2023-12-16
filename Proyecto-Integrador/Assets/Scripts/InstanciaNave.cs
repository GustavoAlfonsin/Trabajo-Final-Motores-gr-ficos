using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciaNave : MonoBehaviour
{
    public GameObject enemigo;
    public float velocidad = 5f;
    public float tiempoAparicion = 0;
    private float timer = 0;
    public int vidaAsteroide = 2;

    // Update is called once per frame
    void Update()
    {
        if ((int)timer == tiempoAparicion)
        {
            InstanciarEnemigo();
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
    void InstanciarEnemigo()
    {
        GameObject nuevoEnemigo = Instantiate(enemigo);


        int bordeAleatorio = Random.Range(0, 4);
        Vector2 posicionInicial = Vector2.zero;
        Vector2 direccionMovimiento = Vector2.zero;

        switch (bordeAleatorio)
        {
            case 0: // Izquierda
                posicionInicial = new Vector2(-9f, Random.Range(-5f, 5f));
               // direccionMovimiento = Vector2.right; // Mover hacia la derecha
                break;
            case 1: // Derecha
                posicionInicial = new Vector2(9f, Random.Range(-5f, 5f));
               // direccionMovimiento = Vector2.left; // Mover hacia la izquierda
                break;
            case 2: // Arriba
                posicionInicial = new Vector2(Random.Range(-9f, 9f), 5f);
               // direccionMovimiento = Vector2.down; // Mover hacia abajo
                break;
            case 3: // Abajo
                posicionInicial = new Vector2(Random.Range(-9f, 9f), -5f);
                //direccionMovimiento = Vector2.up; // Mover hacia arriba
                break;
        }

        nuevoEnemigo.transform.position = posicionInicial;

        Rigidbody2D rb2d = nuevoEnemigo.GetComponent<Rigidbody2D>();


        if (rb2d != null)
        {
            rb2d.velocity = direccionMovimiento * velocidad;
        }
        OnBecameInvisible();
    }

    void OnBecameInvisible()
    {
        //Metodo para destruir objeto cuando salga de view port
        Destroy(enemigo);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {

            RestarVida();


        }
    }
    void RestarVida()
    {
        vidaAsteroide--;
        Debug.Log(vidaAsteroide);

        if (vidaAsteroide <= 0)
        {

            Destroy(enemigo);
        }
    }
}
