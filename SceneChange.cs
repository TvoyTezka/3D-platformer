using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //—оздать пустую переменную, в которую будет вкладыватьс€ назвние уровн€
    public string sceneName;

    private void OnTriggerEnter(Collider other)
    {
        //«агрузить сцену, когда игрок наступает на коллайдер
        EditorSceneManager.LoadScene(sceneName);
    }
}
