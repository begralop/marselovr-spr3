using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class readInput : MonoBehaviour
{
    private TextMeshProUGUI texto;
    void Start()
    {
        texto = this.GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        if (texto != null)
        {
            texto.text = Input.GetAxis("eje1").ToString();
        }
        /*System.Array values = System.Enum.GetValues(typeof(KeyCode));
        foreach (KeyCode code in values)
        {
            if (Input.GetKeyDown(code)) { texto.text = (System.Enum.GetName(typeof(KeyCode), code)); }
        }*/
    }
}
