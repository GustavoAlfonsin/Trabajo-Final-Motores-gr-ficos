using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMenu : MonoBehaviour
{
   public void BotonStart()
    {
        SceneManager.LoadScene("EscenaJuego");
    }

    public void botonQuit()
    {
        Debug.Log("Quitamos la aplicacion");
        Application.Quit();
    }
}
