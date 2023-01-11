using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogerBidon : MonoBehaviour
{
    
    public bool isBidownCogido;
    public GameObject tpToMoto;
    public GameObject tpToCohete;
    public GameObject tpWin;

    public void cogido()
    {
        isBidownCogido = true;

        tpToMoto.SetActive(true);
        tpToCohete.SetActive(true);
        tpWin.SetActive(true);
    }

    public void NoCogido()
    {
        isBidownCogido = false;

        tpToMoto.SetActive(false);
        tpToCohete.SetActive(false);
        tpWin.SetActive(false);
    }
}
