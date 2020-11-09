/*
Author: Andres Mrad (Q-ro)
Date: Wednesday 08/April/2020 @ 17:15:23
Description:  Loads a different scene 
*/

using UnityEngine;

public class SceneChanger : MonoBehaviour
{

    [SerializeField] protected bool isTransitionByIndex = false;
    [SerializeField] protected string sceneName;
    [SerializeField] protected int sceneIndex;
    [SerializeField] protected int transitionIndex;


    protected void ChangeScene()
    {
        if (isTransitionByIndex)
        {
            SceneTransitionHelper.Instance.ChangeScene(sceneIndex, transitionIndex);
        }
        else
        {
            SceneTransitionHelper.Instance.ChangeScene(sceneName, transitionIndex);
        }
    }

}