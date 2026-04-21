using UnityEngine;
using UnityEngine.EventSystems;

public class SFXScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public AudioSource audioSource;
    public AudioClip startSound;   // skaòa, kad uzbrauc virsû
    public AudioClip endSound;     // skaòa, kad noiet nost

    public void OnPointerEnter(PointerEventData eventData)
    {
        audioSource.PlayOneShot(startSound);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        audioSource.PlayOneShot(endSound);
    }
}
