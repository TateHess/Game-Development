using UnityEngine;
using UnityEngine.SceneManagement; // Add Scene management namespace
using TMPro; // Add the TMPro Namespace (UI)

public class PlayerController2D : MonoBehaviour
{
    //Value Types
    [Header("Player Settings")]
    public float moveSpeed; //How fast is the player going to move from side to side
    public float jumpForce; //How high the player jumps
    public bool isGrounded; //Is the player grounded true/false
    public int bottomBound = -4; // Store bottom boundry value
    [Header("Score")]
    public int score; //Store the score value


    //Reference Types
    public Rigidbody2D rig; //Rigidbody reference
    public TextMeshProUGUI scoreText; //Text UI reference

    //Increase the score and Update the score text UI
    public void AddScore(int amount)
    {
        //Add to score
        score += amount;
        //Update score text UI
        scoreText.text = "Score: " + score;
    }


    void FixedUpdate()
    {
        //Gather Inputs
        float moveInput = moveInput.GetAxisRaw("Horizontal");
        //Make the player move side to side
        rig.velocity = new Vector2(moveInput * moveSpeed, rig.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        // If we press the jump button and we are grounded, then jump
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            ifGrounded = false;
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); //Makes the player jump with all of the force applied
        }
        // If we fall below bottomBound(-4) on the Y axis then game over is triggered
        if (transform.position.y < bottomBound)
        {
            GameOver();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //If player is touching the ground set isGrounded to true
        if (collision.GetContact(0).normal == Vector2.up)
        {
            isGrounded = true;
        }
    }
    //Called when hit by an enemy or hwne you fall of the level
    public void GameOver()
    {
        scoreManager.LoadScene(ScoreManager.GetActiveScene().buildIndex);
    }
}
