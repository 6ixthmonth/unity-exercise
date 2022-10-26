using System.Collections;
using System.Collections.Generic;
using Platformer.Gameplay;
using UnityEngine;
using static Platformer.Core.Simulation;

namespace Platformer.Mechanics
{
    /// <summary>
    /// DeathZone components mark a collider which will schedule a
    /// PlayerEnteredDeathZone event when the player enters the trigger.
    /// </summary>
    public class TeleportationZone : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D collider)
        {
            var p = collider.gameObject.GetComponent<PlayerController>();
            if (p != null)
            {
                if (p.transform.position.y < -10)
                {
                    p.transform.position = new Vector3(0, 0, 1);
                }
                else
                {
                    p.transform.position = new Vector3(2, -12.5f, 1);
                }
                p.velocity.x = 0;
                p.velocity.y = 0;
            }
        }
    }
}