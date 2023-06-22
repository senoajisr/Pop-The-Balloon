using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighestScoreText : MonoBehaviour
{
    private Text textComponent;

    void Start()
    {
        textComponent = gameObject.GetComponent<Text>();
    }

    void Update()
    {
        textComponent.text = Global.highestBalloonsPopped.ToString();
    }
}
