using System;

[Serializable]
public struct sceneChangeRequest
{
    public string sceneName;
    public int sceneIndex;
    public int transitionIndex;
}