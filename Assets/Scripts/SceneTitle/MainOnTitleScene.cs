using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MainOnTitleScene : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    /// <summary>
    /// メインシーンを読み込む.
    /// </summary>
    public void LoadMainScene() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
    }

    /// <summary>
    /// メインシーンを読み込む.
    /// </summary>
    public void ExitGame() {
        UnityEngine.Application.Quit();
    }
}