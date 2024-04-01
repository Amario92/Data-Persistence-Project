using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScoreButton : MonoBehaviour

{
    private static int BestScore;
    public void OnResetButtonClicked()
    {
        // Reset the best score
        ResetBestScore();
    }

    private void ResetBestScore()
    {
        // Logic to reset the best score
        BestScore = 0; // For example, resetting the score to 0
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

}
