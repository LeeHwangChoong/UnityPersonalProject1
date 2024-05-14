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
        // PlayerPrefs�� ����Ͽ� �Էµ� �̸� ����
        PlayerPrefs.SetString("PlayerName", nameInputField.text);

        // ���� ������ �̵�
        SceneManager.LoadScene("MainScene");
    }

    public void CharacterChoice()
    {
        SceneManager.LoadScene("CharacterChoiceScene");
    }

    //private void SetCharacterImage(int characterIndex)
    //{
    //    // ĳ���� �ε����� ���� �̹��� ����
    //    switch (characterIndex)
    //    {
    //        case 0:
    //            // ����: ĳ���� 0���� ���� �̹���
    //            characterImage.sprite = Resources.Load<Sprite>("Nine Pines Animation/2D Character Sprite Animation - Penguin/sprites/penguin_idle_01");
    //            break;
    //        case 1:
    //            // ����: ĳ���� 1���� ���� �̹���
    //            characterImage.sprite = Resources.Load<Sprite>("Nine Pines Animation/2D Character Sprite Animation - Penguin/sprites/idle_1");
    //            break;
    //    }
    //}
}
