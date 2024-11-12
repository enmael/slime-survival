using UnityEngine;

public class MonsterSounds : MonoBehaviour
{
    public AudioClip hitSound;  // �浹 �� ����� �Ҹ�
    private AudioSource audioSource;  // AudioSource ������Ʈ

    void Start()
    {
        // AudioSource ������Ʈ�� �����ɴϴ�.
        audioSource = GetComponent<AudioSource>();

        // AudioSource�� ��Ȱ��ȭ�Ǿ� ������ Ȱ��ȭ
        if (audioSource != null && !audioSource.isActiveAndEnabled)
        {
            audioSource.enabled = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // �÷��̾��� ����� �浹���� ���� �Ҹ��� ���� �մϴ�.
        if (collider.gameObject.CompareTag("playe"))
        {
            PlayHitSound();
        }
    }

    void PlayHitSound()
    {
        // AudioSource�� Ȱ��ȭ�Ǿ� �ִ��� Ȯ�� �� �Ҹ� ���
        if (hitSound != null && audioSource != null && audioSource.isActiveAndEnabled)
        {
            audioSource.PlayOneShot(hitSound);  // �� ���� �Ҹ� ���
        }
    }
}
