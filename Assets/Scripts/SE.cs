using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LeafChage
{
    public class SE : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSource;

        float time = 0;
        void Update()
        {
            this.time = Time.deltaTime;
            if (!this.audioSource.isPlaying)
            {
                Destroy(this.gameObject);
                Destroy(this);
            }
        }
    }
}
