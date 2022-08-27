using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaControl : BaseCara
{
    public float moveSpeed = 3f;
    public float jumpPower = 10f;
    private bool isOnGround = false;
    private bool canAtk = true;
    [SerializeField]GroundCheck groundCheck;
    public GameObject idle,atk;
    Rigidbody2D rb;
    Sprite sp;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<Sprite>();
    }

    // Update is called once per frame
    void Update()
    {

        Move();

        if(zanki <= 0)
        Debug.Log("hello");

        if(Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(Attack());
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        switch(playerStatus)
        {
            case PlayerStatus.Live:
            PlayerIsAlive();
            break;
            case PlayerStatus.Respon:
            RespawnEnd();
            break;
            case PlayerStatus.Dead:
            PlayerIsDead();
            break;
        }
        isOnGround = groundCheck.isOnGround;
        
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        if(x > 0)
        {
            transform.localScale = new Vector3 (-1, 1, 1);
        }
        else if(x < 0)
        {
            transform.localScale = new Vector3 (1, 1, 1);
        }
        rb.velocity = new Vector2(x * moveSpeed, rb.velocity.y);
    }

    void Jump()
    {
        if(!isOnGround)
        {            
            Debug.Log("Nope");
            return;
        }
        
        rb.AddForce(transform.up * 50 * jumpPower);
    }
    IEnumerator Attack()
    {
        if(isOnGround || !canAtk)
            yield break;

        canAtk = false;
        idle.SetActive(false);
        atk.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        atk.SetActive(false);
        idle.SetActive(true);

        yield return new WaitForSeconds(1f);
        canAtk = true;
    }
    public void Damage(Collision2D collision2)
    {
        
    }
}
