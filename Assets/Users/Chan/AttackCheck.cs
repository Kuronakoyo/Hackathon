using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AttackCheck : MonoBehaviour
{
    public UnityEvent Atk;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var Enemy = collision.gameObject.GetComponent<BaseCara>();
        Enemy.playerStatus = BaseCara.PlayerStatus.Dead;
        Atk.Invoke();
    }

}
