using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Roguelike.Player
{
    [CreateAssetMenu(menuName = "Player/Player Stats")]
    public class PlayerStats : ScriptableObject
    {
        [SerializeField] private float speed;
        [SerializeField] private float health;

        #region Properties

        public float Speed
        {
            get { return speed; }
        }

        public float Health
        {
            get { return health; }
        }

        #endregion
    }
}