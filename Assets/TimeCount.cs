using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    public float currentTime = 0f;
    public Enemy enemy;
    [SerializeField]
    public Text countTime;
    public Text finalTime;
    public GameObject finalBox;
    private void Start()
    {
        finalBox.SetActive(false);
        
    }
    private void Update()
    {
        //bool playerInfo = enemy.isDie;
        currentTime += 1 * Time.deltaTime;
        countTime.text = currentTime.ToString("0");
        //if (playerInfo == true)
        //{
        //    finalBox.SetActive(true);
        //    finalTime.text = currentTime.ToString("0");
        //}
    }


}
