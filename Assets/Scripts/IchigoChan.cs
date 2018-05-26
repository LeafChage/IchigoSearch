using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LeafChage
{
    public class IchigoChan : MonoBehaviour
    {
		[SerializeField] private Button button;
		public Button IchigoButton { get{ return this.button; } }

		[SerializeField] private RectTransform rect;

		void Start(){
            this.rect.pivot = Vector2.zero;
            this.rect.position = new Vector3(
                 Random.Range(0, Screen.width - this.rect.sizeDelta.x),
                 Random.Range(0, Screen.height - this.rect.sizeDelta.y),
                 0);
        }
    }
}
