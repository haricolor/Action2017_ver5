using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public static GameObject gameManager;

    public float speed = 5;
    public static float HP = 100;
    public static string Vector = "Front";
    public float InvincibleTime;
    public float BlinkInterval;
    private float NextTime;
    Animator HeroAnimation;
    Collider2D HeroCollider;
    GameObject[] PlayerRenderer;
    bool Flash = true;

    void Start()
    {
        HeroAnimation = GetComponent<Animator>();
        HeroCollider = GetComponent<Collider2D>();
        NextTime = Time.time;
        PlayerRenderer = GameObject.FindGameObjectsWithTag("Player");
    }

    void Update()
    {
        Move();
        GameOver();
        OutStage();
    }

    void OnCollisionEnter2D(Collider other)
    {
        if (other.tag == "enemy")
        {
            HP -= 10;
            HeroCollider.isTrigger = true;
            StartCoroutine("Blinker");
        }
        if (other.tag == "bullet")
        {
            HP -= 5;
            HeroCollider.isTrigger = true;
            StartCoroutine("Blinker");
        }
        Invoke("StartCollider", InvincibleTime);
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 direction = new Vector2(x, y).normalized;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            HeroAnimation.SetBool("IsRight", true);
            Vector = "Right";
        }
        else
        {
            HeroAnimation.SetBool("IsRight", false);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            HeroAnimation.SetBool("IsLeft", true);
            Vector = "Left";
        }
        else
        {
            HeroAnimation.SetBool("IsLeft", false);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            HeroAnimation.SetBool("IsBack", true);
            Vector = "Back";
        }
        else
        {
            HeroAnimation.SetBool("IsBack", false);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            HeroAnimation.SetBool("IsFront", true);
            Vector = "Front";
        }
        else
        {
            HeroAnimation.SetBool("IsFront", false);
        }

        GetComponent<Rigidbody2D>().velocity = direction * speed;

    }

    public static bool GameOver()
    {
        if(HP <= 0)
        {
            gameManager.GetComponent<GameManage>().GameOver = true;
            return true;
        }
        else
        {
            return false;
        }
    }

    void OutStage()
    {
        if (GetComponent<Renderer>().isVisible)
        {
            GameOver();
        }
    }

    void StartCollider()
    {
        HeroCollider.isTrigger = false;
        Flash = false;
    }

    IEnumerator Blinker()
    {
        while (Flash)
        {
            yield return new WaitForSeconds(0.4f);
            foreach (GameObject playerrenderer in PlayerRenderer)
            {
                playerrenderer.GetComponent<Renderer>().enabled = !playerrenderer.GetComponent<Renderer>().enabled;
            }
        }
    }
}
