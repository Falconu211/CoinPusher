using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void StartContinueSceneButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void StartNewGameSceneButton()
    {
        CoinCount.coins = 10;
        SceneManager.LoadScene("GameScene");
    }

    public void TitletSceneButton()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
