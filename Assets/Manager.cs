using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public PlaneFinderBehaviour plane;
    public Button buttonOnTheScene;

    void Start()
    {
    
        buttonOnTheScene.onClick.AddListener(TaskOnClick);
    
    }

    void TaskOnClick()
    {
        Vector2 aPosition = new Vector2(0, 0);
    
        plane.PerformHitTest(aPosition);
    }
}
