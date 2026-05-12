using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneButton : MonoBehaviour
{
    public void StartContinueSceneButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void StartNewGameSceneButton()
    {
        GenerateAndCountCoins.coins = 10;
        SceneManager.LoadScene("GameScene");
    }

    public void TitletSceneButton()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
