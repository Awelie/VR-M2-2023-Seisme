using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMenu2();  
    }

    public GameObject menu1;
    public GameObject menu2;

    public void ShowMenu2()
        {
            menu1.SetActive(false);
            menu2.SetActive(true);
        }
    
    void Update()
    {

    }
}
