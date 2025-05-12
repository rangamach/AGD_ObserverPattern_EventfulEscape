using UnityEngine;

public class KeyView : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        int current_keys = GameService.Instance.GetPlayerController().KeysEquipped;

        GameService.Instance.GetInstructionView().HideInstruction();
        GameService.Instance.GetSoundView().PlaySoundEffects(SoundType.KeyPickUp);
        current_keys++;

        EventService.Instance.OnKeyPickedUp.InvokeEvent(current_keys);

        gameObject.SetActive(false);
    }
}
