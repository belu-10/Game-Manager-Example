using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; //creamos una variable estatica para el singleton

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else //si instance es nulo, vacio
        {
            Instance = this; //yo soy instance --> este script
        }

        DontDestroyOnLoad(this); //para q esto se manetenga en tds las escenas 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)) //vuelve al scene game
        {
            ChangeScene("Game"); 
        }

        if (Input.GetKeyDown(KeyCode.M)) //vuele al scene menu
        {
            ChangeScene("Menu");
        }
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName); 
    }
}
