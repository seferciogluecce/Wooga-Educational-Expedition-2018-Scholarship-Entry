using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public GameObject wall;
    public GameObject point;
    Vector3 spawnPoint;
    GameObject wallHolder;
    GameObject pointHolder;
    GameObject lastWall;
    public Text scoreText;
    public GameObject EndPanel;
    public GameObject StartPanel;


    // Use this for initialization
    void Start () {
        wallHolder = new GameObject("Wall Holder");
        pointHolder = new GameObject("Point Holder");
        Instantiate(wall, wallHolder.transform);
        spawnPoint = wall.transform.position;
        Time.timeScale = 0;
        StartPanel.SetActive(true);

    }

    // Update is called once per frame
    void Update () {

        if (wallHolder.GetComponent<Transform>().childCount != 0)  { 
         lastWall = wallHolder.GetComponent<Transform>().GetChild(wallHolder.GetComponent<Transform>().childCount - 1).gameObject;


        if (lastWall.transform.position.y<3.5)
        {

            wall.transform.position = new Vector3(Random.Range(-8,8),spawnPoint.y);

            Instantiate(wall, wallHolder.transform);


        }
        }
    if(lastWall.transform.position.y < 3.5)
            {
            int rand = Random.Range(0, 6);
            Debug.Log(rand);
            if (rand>2)


                Instantiate(point, new Vector3(Random.Range(-8, 8), spawnPoint.y+1), Quaternion.identity, pointHolder.transform);
            }

    }
    public void UpdateScore(int scoreUpdate)
    {
        scoreText.text = (System.Int32.Parse(scoreText.text) + scoreUpdate).ToString();
    }
    public void GameOver()
    {
        Time.timeScale = 0;
       EndPanel.SetActive(true);
    }



    public void TryAgain()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        StartPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
