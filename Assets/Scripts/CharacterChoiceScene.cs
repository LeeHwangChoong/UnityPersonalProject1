using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterChoiceScene : MonoBehaviour
{
    //public Image characterImage;

    //public int selectedCharacterIndex; // ������ ĳ������ �ε���

    //public void SelectCharacter(int characterIndex)
    //{
    //    selectedCharacterIndex = characterIndex;
    //}
    //public void ConfirmCharacterSelection()
    //{
    //    // ������ ĳ������ �ε����� ����
    //    PlayerPrefs.SetInt("SelectedCharacterIndex", selectedCharacterIndex);
    //    PlayerPrefs.Save();

    //    SceneManager.LoadScene("StartScene");
    //}    

    public void BackToStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
