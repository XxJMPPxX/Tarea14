using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{

    private Rigidbody2D _compRigidbody2D;
    

    public float velocidadX;
    public float velocidadY;
    private float horizontal;
    private float vertical;

    public GameObject BulletPrefab;

    void Update()
    {


        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Instantiate(BulletPrefab, transform.position, transform.rotation);
            
        }




    }
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(horizontal * velocidadX, vertical * velocidadY);

    }

   
}