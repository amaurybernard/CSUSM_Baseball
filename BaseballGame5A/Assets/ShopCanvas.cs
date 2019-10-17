using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopCanvas : MonoBehaviour
{
    public String categoryName = null;
    public GameObject categoriesMenu;
    public List<GameObject> CategoryItemsMenu;
    public GameObject ActiveMenu;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PreviousAction()
    {
        if (categoryName == null) {
            SceneManager.LoadScene("SampleScene");
        } else {
            ActiveMenu.SetActive(false);
            categoriesMenu.SetActive(true);
        }
    }
    
    public void switchToMenu(GameObject menu)
    {
        ActiveMenu.SetActive(false);
        menu.SetActive(true);
        ActiveMenu = menu;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
