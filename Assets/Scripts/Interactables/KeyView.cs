using UnityEngine;

public class KeyView : MonoBehaviour, IInteractable
{
    [SerializeField] GameUIView gameUIView;
    public void Interact()
    {
        int current_keys = GameService.Instance.GetPlayerController().KeysEquipped;

        GameService.Instance.GetInstructionView().HideInstruction();
        GameService.Instance.GetSoundView().PlaySoundEffects(SoundType.KeyPickUp);
        current_keys++;
        gameUIView.UpdateKeyText();

        gameObject.SetActive(false);
    }
}
