using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public Text playerNameText;

    void Start()
    {
        // PlayerPrefs를 사용하여 저장된 이름 불러오기
        string playerName = PlayerPrefs.GetString("PlayerName", "DefaultName");

        // 가져온 이름을 원하는 텍스트 UI에 표시
        playerNameText.text = "Player Name: " + playerName;
    }
}

