using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teletransporte : MonoBehaviour
{
    public GameObject postObj;
    public Vector3 salto;
    public void ejecutaSalto()
    {
        StartCoroutine(saltoTemporizado());
    }
    private IEnumerator saltoTemporizado()
    {
        postObj.SetActive(true);
        while (Vector3.Distance(transform.position, new Vector3(salto.x, 2.2f, salto.z)) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(salto.x, 2.2f, salto.z), Time
            .deltaTime);
            yield return null;
        }
        postObj.SetActive(false);
    }

    public void salta(Transform transform)
    {
        this.transform.position = new Vector3(transform.position.x, 2.2f, transform.position.z);
    }
}
