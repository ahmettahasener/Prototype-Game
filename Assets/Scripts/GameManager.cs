using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject restartGame;
    public GameObject playerCar;
    public Image finishScene;
    //public Button restartGameButton; sanýrým gereksiz denemek için yorum satýrýna aldým.
    // Start is called before the first frame update
    public bool isGameActive;
    public PlayerController playerController;
    void Start()
    {
        isGameActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        FinishGame();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Prototype 1");
    }

    public void MainMenu()
    {
        
        SceneManager.LoadScene("Main Menu");
        
    }
    
    void FinishGame()
    {
        if (playerCar.gameObject.transform.position.z > 370)
        {
            finishScene.gameObject.SetActive(true);
            isGameActive = false;
            playerController.speed = 0;
            playerController.turnSpeed = 0;
        }
        else if (playerCar.gameObject.transform.position.y < 0)
        {
            restartGame.gameObject.SetActive(true);
            isGameActive = false;
            playerController.speed = 0;
            playerController.turnSpeed = 0;
        }
    }
}
