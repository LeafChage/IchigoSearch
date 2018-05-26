using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LeafChage
{
    public class Title : MonoBehaviour
    {
        public void ToMainScene()
        {
            SceneManager.LoadScene("Main");
        }
    }
}