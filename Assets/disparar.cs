using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
public class disparar : MonoBehaviour
{
public SteamVR_Action_Boolean fireAction;
public GameObject bala;
public Transform zonaDisparo;
public float speed = 20.0f;
void Update()
{
if (this .GetComponent <Interactable>().attachedToHand != null)
{
SteamVR_Input_Sources source = this.GetComponent<Interactable>().attachedToHand.handType;
if (fireAction [source].stateDown)
{
disparo();
}
}
}
private void disparo()
{
Rigidbody balaRB = Instantiate(bala, zonaDisparo.position, zonaDisparo.rotation).GetComponent<Rigidbody>();
balaRB.velocity = zonaDisparo.forward * speed;
}
}
