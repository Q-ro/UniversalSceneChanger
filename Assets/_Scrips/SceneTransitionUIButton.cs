

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SceneTransitionUIButton : MonoBehaviour
{

    [SerializeField] bool isTransitionByIndex = false;
    [SerializeField] string sceneName;
    [SerializeField] int sceneIndex;
    [SerializeField] int transitionIndex;

    // Start is called before the first frame update
    void Start()
    {
        Button button = this.GetComponent<Button>();
        button.onClick.AddListener(TransitionOnClick);
    }

    // Update is called once per frame
    void TransitionOnClick()
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
