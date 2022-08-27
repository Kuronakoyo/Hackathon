using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseCara : MonoBehaviour
{
    
    // Start is called before the first frame update
    public enum PlayerStatus
    {
        Live,
        Dead,
        Respon
    }
    public PlayerStatus playerStatus { get; set;}
    [SerializeField]
    protected Transform respawnPosition;
    protected int zanki = 3;
    void Update()
    {
        
    }
    protected void PlayerIsAlive()
    {
        //this.GetComponent<BoxCollider2D>().enabled = true;
    }
    protected void PlayerIsDead()
    {
        this.transform.position = respawnPosition.position;
        zanki--;
        //this.GetComponent<BoxCollider2D>().enabled = false;
        playerStatus = PlayerStatus.Respon;
    }
    protected void RespawnEnd()
    {
        playerStatus = PlayerStatus.Live;

    }
}
