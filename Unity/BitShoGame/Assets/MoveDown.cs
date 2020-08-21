﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveDown : MonoBehaviour
{
    public float MoveSpeed = 0.1f;
    public Text myText;

    // Start is called before the first frame update
    void Start()
    {
        myText.text = GameController.instance.GetRandomString();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0, -MoveSpeed));
    }

    public void SetText(string str)
    {
        myText.text = str;
    }
}