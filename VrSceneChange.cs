using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VrSceneChange : MonoBehaviour
{
    [SerializeField] private Text countdownText;
    private Coroutine countdown = null;

    /// <summary>視線(カーソル)がボタンに重なったときのイベント</summary>
    /// <remarks>カウントダウンの処理を開始します</remarks>
    public void OnEnter()
    {
        this.countdown = this.StartCoroutine(this.Countdown());
    }

    /// <summary>視線(カーソル)がボタンから離れた時のイベント</summary>
    /// <remarks>カウントダウンの処理を停止します</remarks>
    public void OnExit()
    {
        this.StopCoroutine(this.countdown);
        this.countdownText.text = string.Empty;
    }

    /// <summary>ボタンが重なって離れるまでに走る処理</summary>
    /// <remarks>カウントダウンが終わったら、シーン遷移します</remarks>
    private IEnumerator Countdown()
    {
        const int sec = 3;
        float elapsed = 0;
        while (elapsed < sec)
        {
            this.countdownText.text = $"{(int)(sec - elapsed)}";
            elapsed += Time.fixedDeltaTime;
            yield return null;
        }
        SceneManager.LoadScene("GameModeSelect");
    }
}