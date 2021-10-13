using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code was used from https://learn.unity.com/tutorial/lesson-3-1-jump-force?uv=2020.3&courseId=5cf96c41edbc2a2ca6e8810f&projectId=5cf9639bedbc2a2b1fe1e848#5ce35aa5edbc2a29e31b3c74

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce = 9;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }

        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            gameOver = true;
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}