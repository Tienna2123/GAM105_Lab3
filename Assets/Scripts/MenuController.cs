using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menuCanvas;
    public GameObject trangPhuc;
    void Start()
    {
        HideMenu();
        HideTrangPhuc();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menuCanvas.activeSelf)
            {
                HideMenu();
            }
            else
            {
                ShowMenu();
            }
        }
    }

    void ShowMenu()
    {
        menuCanvas.SetActive(true);
        Time.timeScale = 0f; // D?ng th?i gian trong tr? chõi khi hi?n th? menu
    }

    void HideMenu()
    {
        menuCanvas.SetActive(false);
        Time.timeScale = 1f; // Khôi ph?c th?i gian khi ?n menu
    }
    void HideTrangPhuc()
    {
        trangPhuc.SetActive(false);
        Time.timeScale = 1f; // Khôi ph?c th?i gian khi ?n menu
    }
}
