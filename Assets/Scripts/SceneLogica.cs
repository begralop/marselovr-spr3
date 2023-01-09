using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Valve.VR.InteractionSystem
{
    public class SceneLogica : MonoBehaviour
    {
        public Transform tpint;
        private Player player;


        void Start()
        {
            player = Player.instance;
        }
        public void reload()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public void jugar()
        {
            player.transform.position = tpint.position;
            player.transform.rotation = tpint.rotation;
            SceneManager.LoadScene("JugarSinPlayer");
        }

        public void video()
        {

            player.transform.position = tpint.position;
            player.transform.rotation = tpint.rotation;
            SceneManager.LoadScene("VideoScene");
        }
        public void menu()
        {

            player.transform.position = tpint.position;
            player.transform.rotation = tpint.rotation;
            SceneManager.LoadScene("SampleScene");
        }

        public void instrucciones()
        {

            player.transform.position = tpint.position;
            player.transform.rotation = tpint.rotation;
            SceneManager.LoadScene("InstruccionesScene");
        }

    }
}
