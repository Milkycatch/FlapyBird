using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class controls : MonoBehaviour
{
    public static controls instance;
    public GameObject gameOverText;
    public bool gameOver = false;
   
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI Continue;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if instance != this)
        {
            Destroy(gameObject);
        }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BirdDie()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
