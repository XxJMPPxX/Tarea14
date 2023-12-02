using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody2D _compRigidbody2D;
    private int direccionY;

    void Update()
    {
       
        
           
            direccionY = -1;
        
    }

    void FixedUpdate()
    {
       
        _compRigidbody2D.velocity = new Vector2(0, direccionY);
    }

    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }
}