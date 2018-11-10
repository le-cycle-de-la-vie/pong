using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_setup : MonoBehaviour
{
    // All that relate to the game mechanic, from the camera, scoring system, player position, start and restart.
    public Camera main_camera;

    public BoxCollider2D top_wall;
    public BoxCollider2D bot_wall;
    public BoxCollider2D right_wall;
    public BoxCollider2D left_wall;

    public GameObject player01;
    public GameObject player02;
    public Transform ball;
    static public Rigidbody2D rb_ball;

    public static int player01_score = 0;
    public static int player02_score = 0;

    public GUISkin UI_score;

    // Use this for initialization
    void Start()
    {
        // Move each wall to its edge location
        top_wall.size = new Vector2(main_camera.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        top_wall.offset = new Vector2(0f, main_camera.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);

        bot_wall.size = new Vector2(main_camera.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        bot_wall.offset = new Vector2(0f, main_camera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);

        right_wall.size = new Vector2(1f, main_camera.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        right_wall.offset = new Vector2(main_camera.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).x * -1 + 0.5f, 0f);

        left_wall.size = new Vector2(1f, main_camera.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        left_wall.offset = new Vector2(main_camera.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).x - 0.5f, 0f);

        //  move the character's initial position
        player01.GetComponent<Transform>().position = new Vector3(main_camera.ScreenToWorldPoint(new Vector3(32f, 0f, 0f)).x, 0f, 0f);
        player02.GetComponent<Transform>().position = new Vector3(main_camera.ScreenToWorldPoint(new Vector3(32f, 0f, 0f)).x * -1, 0f, 0f);
        ball = GameObject.FindGameObjectWithTag("Ball").transform;
    }

    public static void Score(Collision2D collision)
    {
        // Si le tag "Left_wall" est touché par une collision, alors ajoute un point au joueur 1 et debug
        if (collision.gameObject.tag == "Left_wall")
        {
            player01_score += 1;
        }
        else if (collision.gameObject.tag == "Right_wall")
        {
            player02_score += 1;
        }
    }

    void OnGUI()
    {
        GUI.skin = UI_score;
        GUI.Label(new Rect(Screen.width / 2 - 150, 20, 100, 100), "" + player01_score);
        GUI.Label(new Rect(Screen.width / 2 + 150, 20, 100, 100), "" + player02_score);

        if (GUI.Button(new Rect(Screen.width / 2 - 121 / 2, 35, 121, 53), "RESET"))
        {
            player01_score = 0;
            player02_score = 0;
            ball.gameObject.SendMessage("BallReset");
            ball.gameObject.SendMessage("BallBegin");

        }
    }
}
