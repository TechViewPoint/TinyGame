using UnityEngine;


namespace TinyGame
{
    public class SceneManager : MonoBehaviour
    {
        public void SceneSwitch(string sceneName)
        {           
            if (ScenesConst.Exist(sceneName))
                UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName);

            else
                Debug.LogError(string.Format("{0}, this scene name does not be found in the game environment, if you need this scene please add it into SceneManager.cs.", sceneName) );
        }
    }

    public class ScenesConst
    {
        public static string[] ScenesName = 
        {
            sceneStart,
            sceneLevel1,
            sceneLevel2,
            sceneLevel3,
            sceneLevel4,
            sceneLevel5
        };

        public const string sceneStart = "Start";
        public const string sceneLevel1 = "Level1";
        public const string sceneLevel2 = "Level2";
        public const string sceneLevel3 = "Level3";
        public const string sceneLevel4 = "Level4";
        public const string sceneLevel5 = "Level5";

        public static bool Exist(string name)
        {           
            for (int i = 0; i < ScenesName.Length; i++)
            {
                if (string.Equals(name, ScenesName[i]))
                    return true;
            }
            return false;
        }
    }
}
