using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Roguelike.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private PlayerStats playerStats;

        private Rigidbody2D rb;

        private void Awake()
        {
            rb = this.GetComponent<Rigidbody2D>();  
        }

        private void Update()
        {
            HandleMovement();
        }

        private void HandleMovement()
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            rb.velocity = new Vector3(x, y, 0).normalized * playerStats.Speed;
        }
    }
}