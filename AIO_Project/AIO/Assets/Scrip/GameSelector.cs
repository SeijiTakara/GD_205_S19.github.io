﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameSelector : MonoBehaviour
{
    public void SceneSwitcher()
    {
        SceneManager.LoadScene(1);
    }
}
