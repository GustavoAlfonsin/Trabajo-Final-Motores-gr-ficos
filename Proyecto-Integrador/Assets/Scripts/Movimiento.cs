using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private float velocidad = 3f;
    private float velocidadRotacion = 720f;
    private float angulo;
    private float horizontal;
    private float vertical;
    public static Vector2 movimiento;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        movimiento = new Vector2(horizontal, vertical);
        movimiento.Normalize();
        transform.Translate(movimiento * velocidad * Time.deltaTime, Space.World);
        if (movimiento != Vector2.zero)
        {
            angulo = Mathf.Atan2(movimiento.x, -movimiento.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0,0,angulo), velocidadRotacion * Time.deltaTime);
        }
        
    }
}
