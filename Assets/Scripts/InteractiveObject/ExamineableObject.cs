using UnityEngine;
using UnityEngine.UI;

public class ExamineableObject : InteractiveObject
{
    public enum ObjectTypes
    {
        FIGURA,
        COMMON
    }

    public ObjectTypes objectTypes;
    [TextArea(5, 100)]
    public string dialogText;
    public Sprite photoSprite;
    public bool isUIShown = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange && Player.gameState == Player.GameState.GAMEPLAY)
        {
            if (objectTypes == ObjectTypes.FIGURA)
            {

                GameObject fotoUI = PopUpUIManager.Instance.ActivateUI(photoSprite);
                fotoUI.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() => DialogManager.Instance.ShowDialogUI(dialogText));
                isUIShown = true;
            }
            else
            {
                DialogManager.Instance.ShowDialogUI(dialogText);
            }
        }
    }


}
