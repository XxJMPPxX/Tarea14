using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEnemyController : MonoBehaviour
{
    private Rigidbody2D _compRigidbody2D;
    private Animator _compAnimator;
    private AudioSource _audioSource;

    

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Bala" || collision.gameObject.tag == "HORIZONTAL")
        {
            _compAnimator.SetTrigger("IsExploting");

            _audioSource.Play();
        }
    }
    void Awake()
    {
    _compRigidbody2D = GetComponent<Rigidbody2D>();
       _compAnimator = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
    }

    public void Muerte()
    {
        Destroy(this.gameObject);
    }

}
