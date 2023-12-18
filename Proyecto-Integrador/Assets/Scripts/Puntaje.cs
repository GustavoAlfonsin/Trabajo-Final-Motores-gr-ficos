using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puntaje : MonoBehaviour
{
    private static int puntajeAcumulado = 0;
    private string textPuntaje;

    public GameObject botonReinicio;
    public GameObject botonSalir;
    public GameObject mensaje;
    // Start is called before the first frame update
    void Start()
    {
        botonReinicio.SetActive(false);
        botonSalir.SetActive(false);
        mensaje.SetActive(false);
        Time.timeScale = 1.0f;
        puntajeAcumulado = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        textPuntaje = puntajeAcumulado.ToString();
        GameObject.Find("Score").GetComponent<TextMeshProUGUI>().text = textPuntaje;
    }

    public void sumarPuntos(int puntos)
    {
        puntajeAcumulado += puntos;
    }

    public void FinDelJuego()
    {
        Time.timeScale = 0f;
        botonReinicio.SetActive(true);
        botonSalir.SetActive(true);
        mensaje.SetActive(true);
    }
    public void bton_Reiniciar()
    {
        SceneManager.LoadScene("EscenaJuego");
    }
    public void bton_salir()
    {
        Debug.Log("Quitamos la aplicacion");
        Application.Quit();
    }
}
