using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueController : MonoBehaviour
{
    [SerializeField] Rigidbody2D myrb;
    [SerializeField] private int velocity;

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
        Vector2 inputs = new Vector2(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2"));
        myrb.velocity = inputs * velocity;
    }
}