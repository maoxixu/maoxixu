using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    // Create variables
    float movementspeed;
    float horizontalmovemnet;
    float verticalmovemnet;

    [SerializeField] float jumpheight;
    Rigidbody player;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody component attached to the GameObject
        player = GetComponent<Rigidbody>();
        // Set initial values
        setvalue();
        // Print instructions to the console
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        // Handle player movement and actions each frame
        playermovemnt();
        // Check for game over condition
        gameover();
        // Check for success condition
       
    }

    // Handle player movement
    void playermovemnt()
    {
        // Move the player horizontally and vertically
        horzontal_vertic_moving();
        // Handle jumping
        jump_function();
    }

    // Move the player horizontally and vertically based on input
    void horzontal_vertic_moving()
    {
        // Get input for horizontal and vertical movement
        horizontalmovemnet = Input.GetAxis("Horizontal");
        verticalmovemnet = Input.GetAxis("Vertical");
        
        // Translate the player's position based on input and movement speed
        transform.Translate(horizontalmovemnet * movementspeed * Time.deltaTime, 0, 0);
        transform.Translate(0, 0, verticalmovemnet * movementspeed * Time.deltaTime);
    }

    // Handle jumping
    void jump_function()
    {
        // Check for jump input and apply vertical force to the player
        if (Input.GetButtonDown("Jump"))
        {
            player.AddForce(Vector3.up * jumpheight, ForceMode.Impulse);
        }
    }

    // Print game instructions to the console
    void PrintInstruction()
    {
        Debug.Log("Welcome to the New world");
        Debug.Log("You will use WASD to move yourself");
        Debug.Log("Try to not hit anything");
    }

    // Set initial values for movement speed and jump height
    void setvalue()
    {
        movementspeed = 5.5f;  // Set movement speed
        jumpheight = 5f;       // Set jump height
    }

    // Check for game over condition based on player's position
    void gameover()
    {
        if (transform.position.y < -5)
        {
            Debug.Log("GAME OVER");
            // Load the "gameover" scene
            SceneManager.LoadScene("gameover");
        }
    }

    // Check for success condition based on player's position
    void greatgame()
    {
        if (transform.position.y > 3.7)
        {
            Debug.Log("Good Game");
            // Load the "success" scene
            SceneManager.LoadScene("success");
        }
    }
}
