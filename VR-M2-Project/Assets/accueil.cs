using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class accueil : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowAccueil();
    }

    public GameObject panel_accueil;
    public GameObject panel_credits;
    
    public void ShowAccueil()
        {
            panel_accueil.SetActive(true);
            panel_credits.SetActive(false);
        }

    public void ShowCredits()
        {
            panel_accueil.SetActive(false);
            panel_credits.SetActive(true);
        }

    public void ShowSeisme()
        {
            panel_accueil.SetActive(false);
            panel_credits.SetActive(false);
            LoadSeisme();
        }

    public void LoadAccueil(){
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        ShowAccueil();
    }

    public void LoadSeisme(){
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}