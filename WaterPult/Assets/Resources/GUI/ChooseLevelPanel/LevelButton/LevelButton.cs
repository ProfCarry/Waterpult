using System.Collections;
using System.Collections.Generic;
using TMPro;
using ToolBox.Core;
using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    [SerializeField]
    private LevelAsset asset;

    private void Start()
    {
        Button button = this.GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    private void Update()
    {
        TextMeshProUGUI textview = this.GetComponentInChildren<TextMeshProUGUI>();
        textview.text = asset.GetLevelName();
    }

    private void OnClick()
    {
        GameController.Instance.System.Level = asset;
        GameController.Instance.Gui.DeactivePanel();
    }

    public void SetLevelAsset(LevelAsset asset)
    {
        this.asset=asset;
    }
}
