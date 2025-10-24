using UnityEngine;
using UnityEngine.SceneManagement; //Add the scene management namespace

public class EndFlag : MonoBehaviour
{
    public bool finalLevel;
    public string nextLevelName;

    //Collision detection
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Did the player hit us?
        if (collision.CompareTag("Player"))
        {
            //If this is the final level go to menu
            if (finalLevel == true)
            {
                SceneManager.LoadScene(0);
            }

            //Otherwise load up next level
            else
            {
                SceneManager.LoadScene(nextLevelName);
            }
        }
    }

}
