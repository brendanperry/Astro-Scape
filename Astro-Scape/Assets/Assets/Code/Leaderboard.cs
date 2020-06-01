using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;
//using Prime31;

public class Leaderboard : MonoBehaviour
{
	void Start ()
	{
		Social.localUser.Authenticate ( OnGameCenterInit );
		GameCenterPlatform.ShowDefaultAchievementCompletionBanner(true);
	}

	private void OnGameCenterInit( bool success )
	{
		Debug.Log("Logged in");
	}

	public void onClick ()
	{
		if(Social.localUser.authenticated)
			GameCenterPlatform.ShowLeaderboardUI("topscores4", UnityEngine.SocialPlatforms.TimeScope.AllTime);	
	}
}
