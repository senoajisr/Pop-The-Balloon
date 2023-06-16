using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeSceneOnClick : MonoBehaviour
{
    public int sceneIdToLoad;

    public void OnClick() {
        SceneManager.LoadScene(sceneIdToLoad);
    }
}
