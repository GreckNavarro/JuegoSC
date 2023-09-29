using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarVida : MonoBehaviour
{
    [SerializeField] GameObject prefabVida;
    Vector2 posicion;
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Generar()
    {
        int xpos = Random.RandomRange(-7, 7);
        int ypos = Random.RandomRange(-5, 5);
        posicion = new Vector2(xpos, ypos);
        GameObject vida = Instantiate(prefabVida, posicion, Quaternion.identity);
    }
}
