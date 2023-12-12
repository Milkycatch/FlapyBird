using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GamesControls : MonoBehaviour
{
    public static GamesControls instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollspeed = -1.5f;

    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI Continue;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
        // Update is called once per frame
        void Update()
        {
         if (gameOver == true && Input.GetMouseButton (0))
         {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
         }
        }

        public void BirdDied()
        {
            gameOverText.SetActive(true);
            gameOver = true;
        }
    
}
