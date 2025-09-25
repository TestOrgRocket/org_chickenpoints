using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Advertisement.IosSupport;
using Unity.VisualScripting;

public class SceneLoading : MonoBehaviour
{
    public Transform loader;
    void Update()
    {
        loader.Rotate(0, 0, 180 * Time.deltaTime);
    }
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);
        if (ATTrackingStatusBinding.GetAuthorizationTrackingStatus() == ATTrackingStatusBinding.AuthorizationTrackingStatus.NOT_DETERMINED)
        {
            ATTrackingStatusBinding.RequestAuthorizationTracking();
        }
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);
    }
}