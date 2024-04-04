using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject trangPhuc; // Menu c?n t?t
    void Start()
    {
        // ��ng k? s? ki?n
        UnityEngine.UI.Button button = GetComponent<UnityEngine.UI.Button>();
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        HideMenu();
        // Vi?t m? x? l? b?n mu?n th?c hi?n khi n�t ��?c nh?n ? ��y
    }
    public void HideMenu()
    {
        trangPhuc.SetActive(false); // Hi?n th? Menu
    }
}
