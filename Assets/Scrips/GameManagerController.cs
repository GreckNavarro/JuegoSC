using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Text vidaText;
    [SerializeField] private Text perdisText;
    [SerializeField] private int vidaactual;

    private void Awake()
    {
        vidaactual = player.GetComponent<DefensaController>().GetVida();
    }

    public void SetVida(int vida)
    {
        vidaactual = vida;
    }
    void Update()
    {
            vidaText.text = "Vida: " + vidaactual.ToString();
        
    }



    public void ReiniciarNivel()
    {
        int escenaActual = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(escenaActual);

    }

    public void setDerrota()
    {
        perdisText.text = " Fuiste Derrotado";
    }
}
