﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameStartButton : MonoBehaviour {

    /// ボタンをクリックした時の処理
    public void OnClick()
    {
        SceneManager.LoadScene("GameSelect");
    }
}
