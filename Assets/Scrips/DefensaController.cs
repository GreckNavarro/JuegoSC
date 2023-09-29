using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefensaController : MonoBehaviour
{
    [SerializeField] int vida;
    [SerializeField] Rigidbody2D myrb;
    [SerializeField] private int velocity;
    [SerializeField] private GeneradorEnemigos enemigos;
    [SerializeField] private GameManagerController gameManager;

    // Start is called before the first frame update
    void Start()
    {
        myrb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        onMovement();
    }

    void onMovement()
    {
        Vector2 inputs = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        myrb.velocity = inputs * velocity;
    }

    public void DamagePlayer(int damage)    
    {
        vida -= damage;
        if (vida <= 0)
        {
            Destroy(gameObject);
            gameManager.GetComponent<GameManagerController>().TerminoJuego();
        }
    }
}
