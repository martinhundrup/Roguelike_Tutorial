using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Roguelike.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private PlayerStats playerStats;

        private Rigidbody2D rb;
        private SpriteRenderer sr;
        private Animator animator;

        private void Awake()
        {
            rb = this.GetComponent<Rigidbody2D>();  
            sr = this.GetComponentInChildren<SpriteRenderer>();
            animator = this.GetComponentInChildren<Animator>();
        }

        private void Update()
        {
            HandleMovement();
        }

        private void HandleMovement()
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            if (x != 0f)
                sr.flipX = x < 0;

            Vector2 movementVector = new Vector2 (x, y);

            if (movementVector.magnitude > 0f)
            {
                animator.Play("run");
            }
            else
            {
                animator.Play("idle");
            }

            rb.velocity = movementVector.normalized * playerStats.Speed;
        }
    }
}