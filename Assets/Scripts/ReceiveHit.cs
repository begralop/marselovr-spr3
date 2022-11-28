using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ReceiveHit : MonoBehaviour
{
    public UnityEvent myEvent;
    public void EntradaPuntero1()
    {
        this.GetComponent<Animator>().SetTrigger("Highlighted");
    }
    public void SalidaPuntero1()
    {
        this.GetComponent<Animator>().SetTrigger("Normal");
    }
    public void OnPointerClick()
    {
        myEvent.Invoke();
    }
}
