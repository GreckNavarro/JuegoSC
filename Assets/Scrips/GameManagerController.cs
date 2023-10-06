using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject perdiste;
    [SerializeField] private Text vidaText;
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
        if (player != null)
        {
            vidaText.text = "Vida: " + vidaactual.ToString();
        }
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
