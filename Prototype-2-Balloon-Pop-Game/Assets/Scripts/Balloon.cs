using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clicktoPop = 3; //How many click before the balloon pops

    public float scaleToIncrease = 0.15f; //Scale increased each time the ballooon is clicked

    public int scoreToGive; // Score given for the popped balloon

    private ScoreManager scoreManager; // A variable to manage the ScoreManager

    public GameObject popEffect; //Reference pop effect parcticle system

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").
        GetComponent<ScoreManager>();
    }

    void OnMouseDown()
    {
        // Reduce Clicks by 1
        clicktoPop -= 1;

        transform.localScale += Vector3.one * scaleToIncrease;

        if(clicktoPop == 0)
        {
            scoreManager.IncreaseScoreText(scoreToGive); //Increase Score
            //Instant
            Instantiate(popEffect, transform.position, transform.rotation);
            Destroy(gameObject); // POP Balloon
        }
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
