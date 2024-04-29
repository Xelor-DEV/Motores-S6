using UnityEngine;

[CreateAssetMenu(fileName = "RoomsData", menuName = "ScriptableObjects/RoomsData", order = 1)]
public class RoomsData : ScriptableObject
{
    public int sfx_player_passed_enter;
    public int sfx_player_passed_exit;
    public int music_background;
    public int music_background_above;
    public bool hasPlayerPassed = false;
    public bool is_the_first = false;
}