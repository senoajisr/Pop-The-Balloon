using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartImage : MonoBehaviour
{
    public int heartIndex = 3;
    public Texture heartFilled;
    public Texture heartEmpty;
    private RawImage rawImageComponent;

    // Start is called before the first frame update
    void Start()
    {
        rawImageComponent = gameObject.GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Global.Hearts < heartIndex && rawImageComponent != heartEmpty) {
            rawImageComponent.texture = heartEmpty;
        } else if (Global.Hearts >= heartIndex && rawImageComponent != heartFilled) {
            rawImageComponent.texture = heartFilled;
        }
    }
}
