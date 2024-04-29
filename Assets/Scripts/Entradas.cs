using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Entradas : MonoBehaviour
{
    [SerializeField] private RoomsData data;
    [SerializeField] private AudioManagerController audioManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            if (data.hasPlayerPassed == false)
            {
                audioManager.PlaySfx(data.sfx_player_passed_enter);
                data.hasPlayerPassed = true;
                audioManager.PlayMusic(data.music_background);

            }
            else
            {
                audioManager.PlaySfx(data.sfx_player_passed_exit);
                data.hasPlayerPassed = false;
                if(data.is_the_first == false)
                {
                    audioManager.PlayMusic(data.music_background_above);
                }
                else
                {
                    audioManager.MusicAudioSource.Stop();
                }
            }
        }
    }
}