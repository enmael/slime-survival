using UnityEngine;

public class MonsterSounds : MonoBehaviour
{
    public AudioClip hitSound;  // 충돌 시 재생할 소리
    private AudioSource audioSource;  // AudioSource 컴포넌트

    void Start()
    {
        // AudioSource 컴포넌트를 가져옵니다.
        audioSource = GetComponent<AudioSource>();

        // AudioSource가 비활성화되어 있으면 활성화
        if (audioSource != null && !audioSource.isActiveAndEnabled)
        {
            audioSource.enabled = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // 플레이어의 무기와 충돌했을 때만 소리가 나게 합니다.
        if (collider.gameObject.CompareTag("playe"))
        {
            PlayHitSound();
        }
    }

    void PlayHitSound()
    {
        // AudioSource가 활성화되어 있는지 확인 후 소리 재생
        if (hitSound != null && audioSource != null && audioSource.isActiveAndEnabled)
        {
            audioSource.PlayOneShot(hitSound);  // 한 번만 소리 재생
        }
    }
}
