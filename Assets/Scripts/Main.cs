using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace LeafChage
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private IchigoChan ichigoChan;
        [SerializeField] private GameObject[] ichigoDummys;
        [SerializeField] private Text text;
        [SerializeField] private Text timeText;
        [SerializeField] private GameObject byebye;
#if UNITY_EDITOR
        const int dummyCount = 5;
#else
        const int dummyCount = 500;
#endif
        private bool isFinished = false;

        void Start()
        {
            this.text.gameObject.SetActive(false);
            this.ichigoChan.IchigoButton.SetOnClickAction(() =>
            {
                Instantiate(this.byebye);
                this.finish();
            });

            for (int i = 0; i < dummyCount; i++)
            {
                int rnd = Random.Range(0, this.ichigoDummys.Length);
                GameObject button = Instantiate(this.ichigoDummys[rnd]) as GameObject;
                button.transform.SetParent(this.transform);
            }
        }

        float time = 0;
        void Update()
        {
            if (!this.isFinished)
            {
                this.time += Time.deltaTime;
                this.timeText.text = Mathf.RoundToInt(this.time).ToString();
                this.timeText.gameObject.transform.SetAsLastSibling();
            }
        }

        // 終了
        private void finish()
        {
            this.isFinished = true;
            this.text.gameObject.SetActive(true);
            this.text.text = "ありがとぉぉぉ";
            StartCoroutine("toTitleScene");
        }

        private float finishedTime = 0;
        private IEnumerator toTitleScene()
        {
            while (this.finishedTime < 5)
            {
                finishedTime += Time.deltaTime;
                yield return null;
            }
            SceneManager.LoadScene("Title");
        }
    }
}

