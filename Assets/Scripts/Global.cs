using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Global : MonoBehaviour
{
    private static int hearts = 3;
    public static int Hearts {
        get { return hearts; }
        set {
            hearts = value;
            
            if (hearts <= 0) {
                UpdateHighestBalloonsPopped();
                SceneManager.LoadScene(0);
            }
        }
    }

    public static int balloonsPopped = 0;

    public static int highestBalloonsPopped = 0;
    public static void UpdateHighestBalloonsPopped() {
        if (balloonsPopped > highestBalloonsPopped) {
            highestBalloonsPopped = balloonsPopped;
        }
    }
}
