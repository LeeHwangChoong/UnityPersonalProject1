using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterChoiceScene : MonoBehaviour
{
    //public Image characterImage;

    //public int selectedCharacterIndex; // 선택한 캐릭터의 인덱스

    //public void SelectCharacter(int characterIndex)
    //{
    //    selectedCharacterIndex = characterIndex;
    //}
    //public void ConfirmCharacterSelection()
    //{
    //    // 선택한 캐릭터의 인덱스를 저장
    //    PlayerPrefs.SetInt("SelectedCharacterIndex", selectedCharacterIndex);
    //    PlayerPrefs.Save();

    //    SceneManager.LoadScene("StartScene");
    //}    

    public void BackToStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
