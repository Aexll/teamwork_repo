using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{

    [SerializeField] private GameObject _hud_settings;
    [SerializeField] private GameObject _hud_menu;


    // Start is called before the first frame update
    void Start()
    {
        OpenMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenSettings()
    {
        _hud_settings.SetActive(true);
        _hud_menu.SetActive(false);
    }

    public void OpenMenu()
    {
        _hud_settings.SetActive(false);
        _hud_menu.SetActive(true);
    }

    public void LaunchGame()
    {
        /* do somthing here */
    }
}
