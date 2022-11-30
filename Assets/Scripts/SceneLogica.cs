using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLogica : MonoBehaviour
{
    public void reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void jugar()
    {
        SceneManager.LoadScene("HelloCardboard");
    }

    public void video()
    {
        SceneManager.LoadScene("VideoScene");
    }
    public void menu()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void instrucciones()
    {
        SceneManager.LoadScene("InstruccionesScene");
    }

}
