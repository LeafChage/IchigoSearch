using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class ExtensionMethods
{
    /*
	button
	 */
    //ボタンのコールバック関数をセットするため
    public static void SetOnClickAction(this Button button, Action action)
    {
        button.onClick.AddListener(() =>
        {
            action();
        });
    }

    public static bool GetIsActive(this MonoBehaviour self)
    {
        return self.gameObject.activeSelf;
    }

    public static void SetIsActive(this MonoBehaviour self, bool isHidden)
    {
        self.gameObject.SetActive(isHidden);
    }
}