//using System.Collections.Generic;
//using Unity.VisualScripting;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class BGMController : MonoBehaviour
//{
//    public AudioClip bgm;  // ��� ����
//    private AudioSource audioSource;
//    void Awake()
//    {
//        // ���� ����Ǿ BGM ������Ʈ�� �ı����� �ʵ��� ����
//        DontDestroyOnLoad(gameObject);  // �� ��ü�� �� ��ȯ �ÿ��� �ı����� ����
//    }

//    void Start()
//    {
//        audioSource = GetComponent<AudioSource>();

//        // ������ ������ �ʱ�ȭ
//        if (audioSource == null)
//        {
//            audioSource = gameObject.AddComponent<AudioSource>();
//        }

//        // BGM�� ���� �����ϵ��� ����
//        if (bgm != null)
//        {
//            audioSource.clip = bgm;
//            audioSource.loop = true;  // ���� ����
//            audioSource.Play();
//        }
//    }
//}
using UnityEngine;

public class BGMController : MonoBehaviour
{
    public static BGMController instance;
    public AudioClip bgm;  // ��� ����
    private AudioSource audioSource;

    void Awake()
    {
        // �̹� �ν��Ͻ��� �����ϸ� �� ��ü�� �ı�
        if (instance != null && instance != this)
        {
            Destroy(gameObject);  // �ߺ��� ��ü�� ����
            return;
        }
        else
        {
            instance = this;  // ���� ��ü�� �ν��Ͻ��� ����
        }

        // �� ��ȯ �ÿ��� BGM ������Ʈ�� �ı����� �ʵ��� ����
        DontDestroyOnLoad(gameObject);  // �� ��ü�� �� ��ȯ �ÿ��� �ı����� ����
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // ������ ������ �ʱ�ȭ
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // BGM�� ���� �����ϵ��� ����
        if (bgm != null && !audioSource.isPlaying)
        {
            audioSource.clip = bgm;
            audioSource.loop = true;  // ���� ����
            audioSource.Play();
        }
    }

    // �ʿ��ϴٸ� ������ �����ϴ� �޼���
    public void StopBGM()
    {
        if (audioSource != null)
        {
            audioSource.Stop();
        }
    }

    // �̸����� BGMController ã��
    public static BGMController FindBGMControllerByName(string name)
    {
        GameObject bgmObject = GameObject.Find(name);  // �̸����� GameObject ã��
        if (bgmObject != null)
        {
            // GameObject���� BGMController ������Ʈ�� ��������
            return bgmObject.GetComponent<BGMController>();
        }
        else
        {
            Debug.LogWarning("BGMController not found with name: " + name);
            return null;
        }
    }
}

