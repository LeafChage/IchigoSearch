using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LeafChage
{
    public class DummyButton : MonoBehaviour
    {
        [SerializeField] private RectTransform rect;
        [SerializeField] private Button button;
		[SerializeField] private GameObject doon;

        void Start()
        {
            this.button.SetOnClickAction(() =>
            {
                this.buttonClicked();
            });

            this.rect.position = new Vector3(
                 Random.Range(0, Screen.width),
                 Random.Range(0, Screen.height),
                 0);
        }

        // buttonを押した時
        private void buttonClicked()
        {
            // 音ならしたい!
			Instantiate(this.doon);
            Destroy(this.gameObject);
            Destroy(this);
        }
    }
}