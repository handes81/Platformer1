using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f; // Kecepatan pemain, dapat diedit dari Unity
    public LayerMask groundLayer; // Layer tanah
    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Mendapatkan input horizontal (-1 untuk kiri, 1 untuk kanan)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Menggerakkan pemain
        Vector2 movement = new Vector2(horizontalInput * speed, rb.velocity.y);
        rb.velocity = movement;

        // Mengecek lompatan hanya jika pemain berada di atas tanah
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 1.4f, groundLayer);

        if (isGrounded && Input.GetKey(KeyCode.Space))
        {
            // Ubah kecepatan vertikal untuk lompatan
            rb.velocity = new Vector2(rb.velocity.x, 5f); // Ganti 5f dengan kekuatan lompatan yang diinginkan
        }
    }
}
