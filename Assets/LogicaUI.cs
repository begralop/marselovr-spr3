using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif
namespace Valve.VR.InteractionSystem
{
    public class LogicaUI : MonoBehaviour
    {
        private GameObject player;
        private GameObject tetsto2;
        private GameObject tetsto3;
        private GameObject tetsto4;
        private GameObject tetsto5;
        private GameObject fh;
        public GameObject abi;
        public GameObject cohete;
        public bool tamuerto;


        // Start is called before the first frame update
        void Start()
        {
            tamuerto = false;
            // buscar ui
            GameObject temp = new GameObject();
            UnityEngine.Object.DontDestroyOnLoad(temp);
            UnityEngine.SceneManagement.Scene dontDestroyOnLoad = temp.scene;
            UnityEngine.Object.DestroyImmediate(temp);
            temp = null;

            GameObject[] gameObjects = dontDestroyOnLoad.GetRootGameObjects();
            foreach (GameObject go in gameObjects)
            {
                if (go.name == "Player")
                {
                    player = go.gameObject;
                    foreach (Transform t in go.transform.GetComponentsInChildren<Transform>())
                    {
                        if (t.name == "CanvasPlayer")
                        {
                            Debug.Log("uno");
                            fh = t.gameObject;
                            tetsto2 = t.GetChild(1).gameObject;
                            tetsto3 = t.GetChild(2).gameObject;
                            tetsto4 = t.GetChild(3).gameObject;
                            tetsto5 = t.GetChild(4).gameObject;

                            tetsto2.SetActive(false);
                            tetsto3.SetActive(true);

                        }

                    }
                }
            }
        }

        // Update is called once per frame
        void Update()
        {
            
            if(tetsto3 != null && tetsto4 != null && player != null && tetsto5 != null)
            {
                
                    if (Vector3.Distance(player.transform.position, abi.transform.position) < 1)
                    {
                        tetsto3.SetActive(false);
                        tetsto4.SetActive(true);
                    }
                    tamuerto = true;
                
                
                
                if (Vector3.Distance(player.transform.position, cohete.transform.position) < 20)
                {
                    tetsto4.SetActive(false);
                    tetsto5.SetActive(true);
                }
            }
           
        }
    }
}
