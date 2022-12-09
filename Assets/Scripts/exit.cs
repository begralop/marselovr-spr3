using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class exit : MonoBehaviour
{
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        // Checks for screen touches.
        if (timer > 2)
        {
            if (Input.GetButton("A"))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
        
    }
}
