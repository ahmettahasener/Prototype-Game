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
    public GameObject inGameUI;
    public Image finishScene;
    public TextMeshProUGUI speedometer;
    public PlayerController playerController;

    public float speed;
    public bool isGameActive;
    
    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        PlayerController playerController = playerCar.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        FinishGame();
        if (playerController.IsOnGround())
        {
            Speedometer();
        }   
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
            playerController.horsePower = 0;
            playerController.turnSpeed = 0;
            inGameUI.SetActive(false);
        }
        else if (playerCar.gameObject.transform.position.y < 0)
        {
            restartGame.gameObject.SetActive(true);
            isGameActive = false;
            playerController.horsePower = 0;
            playerController.turnSpeed = 0;
            inGameUI.SetActive(false);
        }
    }

    void Speedometer()
    {       
        speed = Mathf.RoundToInt(playerController.vehicleRb.velocity.magnitude * 3.6f); //for calculating kmh we multiply 3.6
        speedometer.text = ("Speed: " + speed + " kmh");
    }
}
