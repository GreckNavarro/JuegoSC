using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject perdiste;


    
    void Update()
    {
        
    }

    public void TerminoJuego()
    {
            perdiste.gameObject.SetActive(true);
    }

    public void ReiniciarNivel()
    {
        int escenaActual = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(escenaActual);

    }
}
