using UnityEngine;
using System.Collections;
using System.Collections.Generic;//Allows us to use Lists. 
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.

    // SCORE
  	public int score = 0;
    private static int penalty = -100;                      // Penalty for going out of bounds?
    private static int center = 100;                        // Score value for core area
    private static int mid = 50;                            // Score value for mid ring
    private static int outer = 25;                          // Score value for outer ring

    // TIME
    private float maxTime = 120.0f;
    public float currentTime;
    private bool isPaused = true;

	public GameObject spotchecker;
    public GameObject[] nodes;

    //Awake is always called before any Start functions
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);

        //Get a component reference to the attached BoardManager script
        //boardScript = GetComponent<BoardManager>();

        //Call the InitGame function to initialize the first level 
        InitGame();
    }

    //Initializes the game for each level.
    void InitGame()
    {
        //Call the SetupScene function of the BoardManager script, pass it current level number.
        //boardScript.SetupScene(level);
        
        score = 0;
        currentTime = maxTime;
        isPaused = true;
    }

    //Update is called every frame.
    void Update()
    {

		currentTime -= Time.deltaTime;
        // debug
        if( Input.GetKeyUp("space"))
        {
            if (isPaused)
                isPaused = false;
            else
                isPaused = true;

            print("isPaused: " + isPaused);
        }

        // timer
        if( !isPaused )
        {
            //Debug.Log("currentTime: " + currentTime);

            if( currentTime <= 0)
            {
                // TODO: Time has run out, game over!
            }
        }
    }

    public void pauseGame()
    {
        isPaused = !isPaused;

        Debug.Log("isPaused" + isPaused);
    }

    public void updateScore(int value)
    {
        score += value;

        // TODO: update UI
    }
}