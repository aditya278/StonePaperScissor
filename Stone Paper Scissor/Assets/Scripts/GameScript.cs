using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{

    public int UserScore = 0;
    public int BotScore = 0;

    public Text userScoreText;
    public Text botScoreText;
    public Text winner;

    public int round = 0;

    public UserScript userScipt;
    public int botChoice = 0;
    public Image BotImg;

    public Sprite[] sprites;

    public GameObject resultCanvas;
    public Image result;
    public Sprite winSprite;
    public Sprite loseSprite;

    // Use this for initialization
    void Start()
    {
        BotImg.enabled = false;
        resultCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (userScipt.userChose && round < 10)
        {
            round++;
            botChoice = Random.Range(1, 4);
            BotImg.enabled = true;
            BotImg.sprite = sprites[botChoice - 1];

            if (userScipt.choice == botChoice)
            {
                winner.text = "Draw";
                UserScore += 5;
                BotScore += 5;
                
            }

            if (userScipt.choice == 1 && botChoice == 3)
            {
                winner.text = "Won";
                UserScore += 10;

            } else if(userScipt.choice == 1 && botChoice == 2)
            {
                winner.text = "Lost";
                BotScore += 10;
                //User Lose
            }

            if (userScipt.choice == 2 && botChoice == 1)
            {
                winner.text = "Won";
                UserScore += 10;
                //User Win
            }
            else if (userScipt.choice == 2 && botChoice == 3)
            {
                winner.text = "Lost";
                BotScore += 10;
                //User Lose
            }

            if (userScipt.choice == 3 && botChoice == 2)
            {
                winner.text = "Won";
                UserScore += 10;
                //User Win
            }
            else if (userScipt.choice == 3 && botChoice == 1)
            {
                winner.text = "Lost";
                BotScore += 10;
                //User Lose
            }

            userScoreText.text = UserScore.ToString();
            botScoreText.text = BotScore.ToString();

            userScipt.userChose = false;
        }

        if(round == 10)
        {
            Results();
        }

    }

    public void Results()
    {
        resultCanvas.SetActive(true);

        if(UserScore > BotScore)
        {
            result.sprite = winSprite;
            Debug.Log("Player Wins!");

        } else if(BotScore > UserScore)
        {
            result.sprite = loseSprite;
            Debug.Log("Bot Wins!!");

        } else
        {
            Debug.Log("Draw!!");
            round--;
        }
    }
}
