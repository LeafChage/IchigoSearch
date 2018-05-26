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
		[SerializeField] private Button finishButton;
        [SerializeField] private GameObject[] ichigoDummys;
        [SerializeField] private Text text;
		[SerializeField] private Text timeText;
		[SerializeField] private GameObject byebye;
        const int dummyCount = 1000;
		private bool isFinished = false;

        void Start()
        {
            this.text.gameObject.SetActive(false);
			this.finishButton.gameObject.SetActive(false);
			this.finishButton.SetOnClickAction(() => {
				SceneManager.LoadScene("Title");
			});

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
			this.finishButton.SetIsActive(true);
            this.isFinished = true;
            this.text.gameObject.SetActive(true);
            this.text.text = "Success!!";
            // いちごちゃん音声
        }
    }
}

