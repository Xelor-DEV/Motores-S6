using UnityEngine;

public class Entradas : MonoBehaviour
{
    [SerializeField] private int sfx_player_passed_enter;
    [SerializeField] private int sfx_player_passed_exit;
    [SerializeField] private int music_background;
    [SerializeField] private int music_background_above;
    private bool hasPlayerPassed = false;
    [SerializeField] private bool is_the_first = false;
    [SerializeField] private AudioManagerController audioManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (hasPlayerPassed == false)
            {
                audioManager.PlaySfx(sfx_player_passed_enter);
                hasPlayerPassed = true;
                audioManager.PlayMusic(music_background);
            }
            else
            {
                audioManager.PlaySfx(sfx_player_passed_exit);
                hasPlayerPassed = false;
                if(is_the_first == false)
                {
                    audioManager.PlayMusic(music_background_above);
                }
                else
                {
                    audioManager.MusicAudioSource.Stop();
                }

            }
        }
    }
}
