using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class information : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMenu3();
    }

    public GameObject menu1;
    public GameObject menu2;

    public void ShowMenu3()
        {
            menu1.SetActive(false);
            menu2.SetActive(false);
        }

    void Update()
    {
        
    }
}
