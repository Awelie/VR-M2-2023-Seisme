using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class accueil : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMenu1();
    }

    public GameObject menu1;
    public GameObject menu2;

    public void ShowMenu1()
        {
            menu1.SetActive(true);
            menu2.SetActive(false);
        }
    
    void Update()
    {
        
    }
}
