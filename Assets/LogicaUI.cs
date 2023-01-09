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
        private Player player;
        public GameObject tetsto2;
        public GameObject tetsto3;
        public GameObject tetsto4;
        public GameObject abi;


        // Start is called before the first frame update
        void Start()
        {

            tetsto2 = GameObject.Find("dos");
            tetsto2.SetActive(false); 
            tetsto3 = GameObject.Find("tres");
            tetsto3.SetActive(true);
            player = Player.instance;
            abi = GameObject.Find("abi-down");
            tetsto4 = GameObject.Find("cuatro");
        }

        // Update is called once per frame
        void Update()
        {
            if(Vector3.Distance(player.transform.position, abi.transform.position) < 2)
            {
                tetsto3.SetActive(false);
                tetsto4.SetActive(true);
            }
        }
    }
}
