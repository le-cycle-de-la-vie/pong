using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_control : MonoBehaviour {

    public Rigidbody2D rb_ball;
    public Rigidbody2D rb_player01;
    public Rigidbody2D rb_player02;
    public Collider2D collision_ball;
    public Collider2D left_wall;
    public Collider2D right_wall;
    public IEnumerator delay;
    public AudioSource click;

    IEnumerator Start () 
    {
        yield return new WaitForSeconds(2);
        BallBegin();
    }

    void BallBegin()
    {
        float random_n = Random.Range(0, 2);
        rb_ball = GetComponent<Rigidbody2D>();
        rb_player01 = GetComponent<Rigidbody2D>();
        rb_player02 = GetComponent<Rigidbody2D>();

        if (random_n <= 0.5)
        {
            rb_ball.AddForce(new Vector2(80, 10));
        }
        else
        {
            rb_ball.AddForce(new Vector2(-80, 10));
        }
    }

    void BallReset()
    {
        rb_ball.velocity = new Vector2(0, 0);
        rb_ball.transform.position = new Vector3(0, 0, 0);
    }

     
    void OnCollisionEnter2D(Collision2D collision)
    {
        game_setup.Score(collision);
        //sound setup
        if(collision.collider.tag == "Player01")
        {
            click.pitch = Random.Range(1, 3);
            click.Play();
        }
        else if(collision.collider.tag == "Player02")
        {
            click.pitch = Random.Range(1, 3);
            click.Play();

        }

        //ball reset (no cooldown!)
        if (collision.collider.tag == "Left_wall")
        {
            BallReset();
            BallBegin();
        }
        if (collision.collider.tag == "Right_wall")
        {
            BallReset();
            BallBegin();
        }

    }
}
