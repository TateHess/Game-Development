using UnityEngine;

public class Coin : MonoBehaviour
{
    [Header("Coin Attributes")]
    public int scoreToGive; // How many points do we give the player
    private float startYPos; // Coin start position on the y-axis
    public float bobHeight; // How high will the coin bob
    public float bobSpeed; // How fast the coin will bob

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Check to see if we are colliding with the player
        if (collision.CompareTag("Player"))
        {
            //Increase the score
            collision.GetComponent<PlayerController2D>().AddScore(scoreToGive);
            //Destroy the coin
            Destroy(gameObject);
        }
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startYPos = transform.position.y; //Set the start position to the current position
    }

    // Update is called once per frame
    void Update()
    {
        //Move the coin up and down aka make the coin bob
        float newY = startYPos + (Mathf.Sin(Time.time * bobSpeed) * bobHeight);
        transform.position = new Vector3(transform.position.x, newY, 0);
    }
}
