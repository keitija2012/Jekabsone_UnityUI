using UnityEngine;
using UnityEngine.UI;

public class SFXScript : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clickSound;

    public void PlaySFX()
    {
        audioSource.PlayOneShot(clickSound);
    }
}
