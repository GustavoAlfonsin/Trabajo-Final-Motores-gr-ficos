using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController2D : MonoBehaviour
{
    public float velocidad = 5f;
    public int vida = 3;
    private float velocidadRotacion = 720f;
    private float angulo;

    // Update is called once per frame
    void Update()
    {
        Vector2 direccion = Movimiento.movimiento - (Vector2)transform.position;
        direccion.Normalize();
        transform.Translate(direccion * velocidad * Time.deltaTime);
        if (direccion != Vector2.zero)
        {
            angulo = Mathf.Atan2(direccion.x, -direccion.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, angulo), velocidadRotacion * Time.deltaTime);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Bullet"))
        {
            vida--;
            if (vida <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

}
