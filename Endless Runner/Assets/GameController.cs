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
  //  GameObject Point;
    public Text scoreText;
    public GameObject EndPanel;
    public GameObject StartPanel;
    public GameObject BackGround;
    public List<Sprite> backgorunds;
    public List<Sprite> wallBackGrounds;
    public List<Sprite> pointBackGrounds;

    bool mode = false;
    int interval15=0;


    // Use this for initialization
    void Start () {
        wallHolder = new GameObject("Wall Holder");
        pointHolder = new GameObject("Point Holder");
        Instantiate(wall, wallHolder.transform);
        spawnPoint = wall.transform.position;
        Time.timeScale = 0;
        StartPanel.SetActive(true);
        point.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = pointBackGrounds[0];

    }

    // Update is called once per frame
    void Update () {

        if (wallHolder.GetComponent<Transform>().childCount != 0)  { 
         lastWall = wallHolder.GetComponent<Transform>().GetChild(wallHolder.GetComponent<Transform>().childCount - 1).gameObject;


        if (lastWall.transform.position.y<2.75)
        {

            wall.transform.position = new Vector3(Random.Range(-8,8),spawnPoint.y);

            Instantiate(wall, wallHolder.transform);


        }

            if (Time.timeSinceLevelLoad / 15 > interval15)
            {
                interval15++;
                ChangeMode();
            }

        }
    if(lastWall.transform.position.y < 2.75)
            {
            int rand = Random.Range(0, 6);
            if (rand>2)
                
                Instantiate(point, new Vector3(Random.Range(-8, 8), spawnPoint.y+1.75f), Quaternion.identity, pointHolder.transform);
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


    void ChangeMode()
    {
        
        mode = !mode;
        if (mode)
        {
            BackGround.GetComponent<SpriteRenderer>().sprite = backgorunds[0];
            foreach (Transform t in wall.transform)
            {
                if (t.tag == "WallPart")
                {
                    foreach (Transform tt in t)
                    {
                        tt.GetComponent<SpriteRenderer>().sprite = wallBackGrounds[0];
                    }
                }
            }
            point.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = pointBackGrounds[0];
        }
        else
        {
            BackGround.GetComponent<SpriteRenderer>().sprite = backgorunds[1];
            foreach (Transform t in wall.transform)
            {
                if (t.tag == "WallPart")
                {
                    foreach (Transform tt in t)
                    {
                        tt.GetComponent<SpriteRenderer>().sprite = wallBackGrounds[1];
                    }
                }
            }
            point.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = pointBackGrounds[1];

        }

    }
}
