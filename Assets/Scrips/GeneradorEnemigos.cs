using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{
    [SerializeField] GameObject prefabEnemigo; 
    [SerializeField] private float respawn; 
    [SerializeField] GameObject player;
    [SerializeField] private GameObject[] listasdepuntos;
    [SerializeField] private List<EnemyController> enemigosActivos;



    void Start()
    {
        InvokeRepeating("GenerarEnemigos", 0.5f, respawn);
    }

    void GenerarEnemigos()
    {
        if (player != null)
        {
            int random = Random.Range(0, listasdepuntos.Length);
            GameObject enemy = Instantiate(prefabEnemigo, listasdepuntos[random].transform.position, Quaternion.identity);
            enemy.GetComponent<EnemyController>().SetDefensaController(player.GetComponent<DefensaController>());
            enemigosActivos.Add(enemy.GetComponent<EnemyController>());
        }
    }
}

