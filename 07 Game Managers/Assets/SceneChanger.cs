using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene()
    {
        //Debug.Log(GameManagement.manager.sceneNum);
        GameManagement.manager.NextScene();
    }
}
