using UnityEngine;

public class LightsOffByGhostEvent : MonoBehaviour
{
    [SerializeField] private int requred_keys;
    [SerializeField] private SoundType sound_effect;

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerView>() != null && requred_keys == GameService.Instance.GetPlayerController().KeysEquipped)
        {
            EventService.Instance.OnLightsOffByGhostEvent.InvokeEvent();
            GameService.Instance.GetSoundView().PlaySoundEffects(sound_effect);
            this.enabled = false;
        }
    }
}