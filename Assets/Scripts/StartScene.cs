using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
    public InputField nameInputField;
    public Text placeholderText;
    public Button joinButton;

    //public Image characterImage;

    private void Start()
    {
        //int selectedCharacterIndex = PlayerPrefs.GetInt("SelectedCharacterIndex", 0);

        //SetCharacterImage(selectedCharacterIndex);

        joinButton.interactable = false;
    }

    public void CheckNameAndJoin()
    {
        string playerName = nameInputField.text;

        if (playerName.Length >= 2 && playerName.Length <= 10)
        {
            joinButton.interactable = true;
        }
        else
        {
            joinButton.interactable = false;
        }
    }

    public void JoinGame()
    {
        // PlayerPrefs를 사용하여 입력된 이름 저장
        PlayerPrefs.SetString("PlayerName", nameInputField.text);

        // 메인 씬으로 이동
        SceneManager.LoadScene("MainScene");
    }

    public void CharacterChoice()
    {
        SceneManager.LoadScene("CharacterChoiceScene");
    }

    //private void SetCharacterImage(int characterIndex)
    //{
    //    // 캐릭터 인덱스에 따라 이미지 설정
    //    switch (characterIndex)
    //    {
    //        case 0:
    //            // 예시: 캐릭터 0번에 대한 이미지
    //            characterImage.sprite = Resources.Load<Sprite>("Nine Pines Animation/2D Character Sprite Animation - Penguin/sprites/penguin_idle_01");
    //            break;
    //        case 1:
    //            // 예시: 캐릭터 1번에 대한 이미지
    //            characterImage.sprite = Resources.Load<Sprite>("Nine Pines Animation/2D Character Sprite Animation - Penguin/sprites/idle_1");
    //            break;
    //    }
    //}
}
