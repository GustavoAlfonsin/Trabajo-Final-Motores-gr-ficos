using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float Velocidad;

    [SerializeField] private float Daño = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Velocidad * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
