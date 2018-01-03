﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

    GameObject glavMenu;
    public GameObject ChooseLvlsPanel;
    public GameObject SettingsPanel;
    public GameObject InfoPanel;

    public void Awake()
    {
        glavMenu = GameObject.Find("GlavMenu");
    }

    public void Start()
    {
        glavMenu = GameObject.Find("GlavMenu");
        if (glavMenu == null) return;
    }

    public void ONchooselvls()
    {
        glavMenu.SetActive(false);
        ChooseLvlsPanel.SetActive(true);
    }

    public void ONsettings()
    {
        glavMenu.SetActive(false);
        SettingsPanel.SetActive(true);
    }

    public void ONInfo()
    {
        glavMenu.SetActive(false);
        InfoPanel.SetActive(true);
    }

    public void ClosChooselvls()
    {
        glavMenu.SetActive(true);
        ChooseLvlsPanel.SetActive(false);
    }

    public void CloseSettings()
    {
        glavMenu.SetActive(true);
        SettingsPanel.SetActive(false);
    }

    public void CloseInfo()
    {
        glavMenu.SetActive(true);
        InfoPanel.SetActive(false);
    }

    public void ExitG()
    {
        PlayerPrefs.Save();
        Application.Quit();
    }
}
