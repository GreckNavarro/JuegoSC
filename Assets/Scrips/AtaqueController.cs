using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueController : MonoBehaviour
{
    [SerializeField] Rigidbody2D myrb;
    [SerializeField] private int velocity;

    private float minX, maxX, minY, maxY;
 
    void Start()
    {
        myrb = GetComponent<Rigidbody2D>();
        minX = -6.22f;
        maxX = 6.22f;
        minY = -4.55f;
        maxY = 4.55f;

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
        Vector2 newPosition = myrb.position + inputs * velocity * Time.fixedDeltaTime;


        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        myrb.position = newPosition;
    }
}