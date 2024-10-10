using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void LoadScene1()
    {
        SceneManager.LoadScene("Escenario_1"); // Reemplaza "Scene1" con el nombre de tu primera escena
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("Scene2"); // Reemplaza "Scene2" con el nombre de tu segunda escena
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("Scene3"); // Reemplaza "Scene3" con el nombre de tu tercera escena
    }
}     