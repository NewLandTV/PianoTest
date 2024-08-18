using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Image image;

    [Serializable]
    public class Data
    {
        public string name;
        public Sprite sprite;
    }

    [SerializeField]
    private Data[] datas;

    [SerializeField]
    private TMP_InputField inputField;

    private int index;

    private void Start()
    {
        ChangeImage();
    }

    private void ChangeImage()
    {
        index = UnityEngine.Random.Range(0, datas.Length);
        image.sprite = datas[index].sprite;
    }

    public void OnCheckButtonClick()
    {
        string input = inputField.text;

        if (!input.Equals(datas[index].name))
        {
            return;
        }

        ChangeImage();
    }
}
