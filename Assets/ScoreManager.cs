using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    private float _runningScore;
    private float _collectibleScore;

    public Transform player;
    public float scoreMultiplier = 1;
    public float score
    {
        // TODO: Check this 
        get => _runningScore + _collectibleScore;
        set => _collectibleScore = value;
    }
    

    // Update is called once per frame
    void Update()
    {
        this._runningScore = player.position.x * scoreMultiplier;
    }

}