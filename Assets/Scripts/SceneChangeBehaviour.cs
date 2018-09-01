using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class SceneChangeBehaviour : DefaultTrackableEventHandler
{
    public string TransitionScene;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        SceneManager.LoadScene(TransitionScene);
    }
}
