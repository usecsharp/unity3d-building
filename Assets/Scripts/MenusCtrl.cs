﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenusCtrl : MonoBehaviour
{
    public bool isMenu = false;
    // Start is called before the first frame update

    
    public GameObject gm1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            isMenu = !isMenu;
            if (isMenu) Cursor.visible = true;
            else Cursor.visible = false;
            gameObject.GetComponent<CanvasGroup>().alpha = 1 - gameObject.GetComponent<CanvasGroup>().alpha;

            Time.timeScale = 1-Time.timeScale;
            gm1.SetActive(!isMenu);
        }
    }
}
