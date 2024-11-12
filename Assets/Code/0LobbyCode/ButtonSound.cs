////using UnityEngine;
////using UnityEngine.UI;  // UI ���� ���ӽ����̽� �߰�

////public class ButtonSound : MonoBehaviour
////{
////    public AudioSource audioSource;  // AudioSource�� ������ ����
////    public Button button;  // ��ư�� ������ ����

////    void Start()
////    {
////        // ��ư�� Ŭ�� �̺�Ʈ�� �Ҹ� ��� �Լ��� ����
////        button.onClick.AddListener(PlaySound);
////    }

////    // ��ư Ŭ�� �� �Ҹ� ��� �Լ�
////    void PlaySound()
////    {
////        audioSource.Play();  // �Ҹ� ���
////    }
////}

//using System.Collections;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class ButtonSound : MonoBehaviour
//{
//    // ȿ���� ����� ���� AudioSource
//    [SerializeField] AudioSource audioSource;

//    // "GameScene"�̶�� �̸��� ���� �ε�
//    public void StartGame()
//    {
//        // StartGame ȣ�� �� �Ҹ� ��� �� �� ��ȯ
//        StartCoroutine(PlaySoundAndLoadScene("GameScene"));
//    }

//    // ���� ����
//    public void ExitGame()
//    {
//        // ExitGame ȣ�� �� �Ҹ� ��� �� ����
//        StartCoroutine(PlaySoundAndExit());
//    }

//    // �Ҹ� ��� �� �� ��ȯ�� ���� Coroutine
//    IEnumerator PlaySoundAndLoadScene(string sceneName)
//    {
//        // �Ҹ� ���
//        audioSource.Play();

//        // �Ҹ� ���̸�ŭ ��ٸ� �� �� ��ȯ
//        yield return new WaitForSeconds(audioSource.clip.length);

//        // �� ��ȯ
//        SceneManager.LoadScene(sceneName);
//    }

//    // �Ҹ� ��� �� ���� ���Ḧ ���� Coroutine
//    IEnumerator PlaySoundAndExit()
//    {
//        // �Ҹ� ���
//        audioSource.Play();

//        // �Ҹ� ���̸�ŭ ��ٸ� �� ����
//        yield return new WaitForSeconds(audioSource.clip.length);

//        // ���� ����
//        Application.Quit();
//        Debug.Log("���� ����");
//    }
//}

