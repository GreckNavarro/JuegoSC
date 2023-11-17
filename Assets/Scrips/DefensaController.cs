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


    private float minX, maxX, minY, maxY;

 
    void Start()
    {
        myrb = GetComponent<Rigidbody2D>();
        minX = -6.22f;
        maxX = 6.22f;
        minY = -4.55f;
        maxY = 4.55f;

    }

    public int GetVida()
    {
        return vida;
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
        Vector2 newPosition = myrb.position + inputs * velocity * Time.fixedDeltaTime;


        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        myrb.position = newPosition;
    }

    public void DamagePlayer(int damage)    
    {
        vida -= damage;
        gameManager.GetComponent<GameManagerController>().SetVida(vida);
        if (vida <= 0)
        {
            gameManager.GetComponent<GameManagerController>().SetVida(vida);
            gameManager.GetComponent<GameManagerController>().setDerrota();
            Destroy(gameObject);
           
        }
    }

    public void Curar(int curacion)
    {
        vida += curacion;
        gameManager.GetComponent<GameManagerController>().SetVida(vida);
    }
}
