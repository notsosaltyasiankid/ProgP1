using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeepScore : MonoBehaviour
{
    private TMP_Text textfield;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        textfield = GetComponent<TMP_Text>();
        Pickup.scoreAdd += Getpoints;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Getpoints()
    {
        score += 50;
        textfield.text = "score :" + score;
    }
}
