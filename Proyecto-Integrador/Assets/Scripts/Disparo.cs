using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] private Transform ControladorDisparo;

    [SerializeField] private GameObject bala;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Disparar();
        }
    }
    private void Disparar()
    {
        Instantiate(bala, ControladorDisparo.position, ControladorDisparo.rotation);
    }
}
