using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;

namespace KID
{
    /// <summary>
    /// 場景控制：重新與離開遊戲
    /// </summary>
    public class SceneControl : MonoBehaviour
    {
        private UIElement uiReplay;
        private UIElement uiQuit;
        private string nameSceneToReplay = "籃球場";

        private void Awake()
        {
            uiReplay = GameObject.Find("重新遊戲").GetComponent<UIElement>();
            uiQuit = GameObject.Find("離開遊戲").GetComponent<UIElement>();

            uiReplay.onHandClick.AddListener((UnityAction) => { SceneManager.LoadScene(nameSceneToReplay); });
            uiQuit.onHandClick.AddListener((UnityAction) => { Application.Quit(); });
        }
    }
}
