﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
    public void OnClick() {
        Destroy(gameObject);
    }
}
