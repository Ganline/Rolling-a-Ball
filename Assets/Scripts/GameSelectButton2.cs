﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSelectButton2 : MonoBehaviour
{
    public void LoadingNewScene()
    {
        SceneManager.LoadScene("Stage2");
    }
}


