using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LeafChage
{
    public class SE : MonoBehaviour
    {
        [SerializeField] private AudioClip audioClip;

        float time = 0;
        void Update()
        {
            this.time = Time.deltaTime;
            if (time > this.audioClip.length)
            {
                Destroy(this.gameObject);
                Destroy(this);
            }
        }
    }
}
