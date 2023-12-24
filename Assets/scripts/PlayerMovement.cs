using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float jumpSpeed;
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private AudioSource dieSFX;
    [SerializeField] private AudioSource pointSFX;
    [SerializeField] private AudioSource flySFX;


    private Rigidbody2D rb2d;
    private void Start()
    {
        Time.timeScale = 1f;
        deathScreen.SetActive(false);
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.velocity = Vector2.up * 6f;
            flySFX.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Scoring")
        {

            FindObjectOfType<GameManager>().IncreaseScore();
            pointSFX.Play();
        }



    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Obtancle")
        {
            Time.timeScale = 0f;
            deathScreen.SetActive(true);
            dieSFX.Play();
            //oyun sonu ekraným gelsin.
        }
    }
}











