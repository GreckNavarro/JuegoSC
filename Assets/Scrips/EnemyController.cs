using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] DefensaController player;
    [SerializeField] Rigidbody2D myRB2D;
    [SerializeField] int velocity;

    public void SetDefensaController(DefensaController _playerController)
    {
        player = _playerController;
    }
    private void Start()
    {
        myRB2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if(player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, velocity * Time.deltaTime);
        }
        else if(player == null)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            collision.GetComponent<DefensaController>().DamagePlayer(1);
        }

        if (collision.gameObject.tag == "Ataque")
        {

            Destroy(gameObject);
        }
    }

    public void Destruir()
    {
        if (player == null)
        {
            Destroy(gameObject);
        }
    }
}
