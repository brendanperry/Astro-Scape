using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;
//using Prime31;

public class GameCenterMNGR : MonoBehaviour
{

	public int t;
	public int p;
	public int pf;
	public int u;
	public int m;
	public int mt;
	public int mn;
	public int ua;
	public int d;
	public int tw;

	int startup;



	void Start ()
	{
//		GameCenterBinding.authenticateLocalPlayer ();
		//GameCenterBinding.getAchievements ();
		//GameCenterBinding.loadPlayerData ();

		startup = PlayerPrefs.GetInt ("startup", 1);

		if (startup == 1) {

			PlayerPrefs.SetInt ("t", 1);
			PlayerPrefs.SetInt ("p", 1);
			PlayerPrefs.SetInt ("pf", 1);
			PlayerPrefs.SetInt ("u", 1);
			PlayerPrefs.SetInt ("m", 1);
			PlayerPrefs.SetInt ("mt", 1);
			PlayerPrefs.SetInt ("mn", 1);
			PlayerPrefs.SetInt ("ua", 1);
			PlayerPrefs.SetInt ("d", 1);
			PlayerPrefs.SetInt ("tw", 1);

			PlayerPrefs.SetInt ("startup", 2);
			startup = 2;
		}

	
	
	}


	public void tutorial ()
	{

		if (PlayerPrefs.GetInt ("t") == 1) {
			Social.ReportProgress("tutorial", 100.0, null);
	//		GameCenterBinding.reportAchievement ("tutorial", 100);
			PlayerPrefs.SetInt ("t", 2);
			StopCoroutine ("tutorial");

		}
	}

	public void hundredpoints ()
	{

		if (PlayerPrefs.GetInt ("p") == 1) {
			Social.ReportProgress("100points", 100.0, null);
		//	GameCenterBinding.reportAchievement ("100points", 100);
			PlayerPrefs.SetInt ("p", 2);
			StopCoroutine ("hundredpoints");
		}
	}

	public void fivehundredpoints ()
	{

		if (PlayerPrefs.GetInt ("pf") == 1) {
			Social.ReportProgress("500points", 100.0, null);
		//	GameCenterBinding.reportAchievement ("500points", 100);
			PlayerPrefs.SetInt ("pf", 2);
			StopCoroutine ("fivehundredpoints");
		}
	}

	public void firstcolor ()
	{

		if (PlayerPrefs.GetInt ("u") == 1) {
			Social.ReportProgress("FirstColor", 100.0, null);
		//	GameCenterBinding.reportAchievement ("FirstColor", 100);
			PlayerPrefs.SetInt ("u", 2);
			StopCoroutine ("firstcolor");
		}
	}

	public void maxhind ()
	{

		if (PlayerPrefs.GetInt ("m") == 1) {
			Social.ReportProgress("maxhind", 100.0, null);
		//	GameCenterBinding.reportAchievement ("maxhind", 100);
			PlayerPrefs.SetInt ("m", 2);
			StopCoroutine ("maxhind");
		}
	}

	public void maxthunder ()
	{

		if (PlayerPrefs.GetInt ("mt") == 1) {
			Social.ReportProgress("maxthunderbird", 100.0, null);
			//GameCenterBinding.reportAchievement ("maxthunderbird", 100);
			PlayerPrefs.SetInt ("mt", 2);
			StopCoroutine ("maxthunder");
		}
	}

	public void maxnaut ()
	{

		if (PlayerPrefs.GetInt ("mn") == 1) {
			Social.ReportProgress("maxnaut", 100.0, null);
		//	GameCenterBinding.reportAchievement ("maxnaut", 100);
			PlayerPrefs.SetInt ("mn", 2);
			StopCoroutine ("maxnaut");
		}
	}

	public void unlockall ()
	{

		if (PlayerPrefs.GetInt ("ua") == 1) {
			Social.ReportProgress("unlockall", 100.0, null);
		//	GameCenterBinding.reportAchievement ("unlockall", 100);
			PlayerPrefs.SetInt ("ua", 2);
			StopCoroutine ("unlockall");
		}
	}

	public void death ()
	{

		if (PlayerPrefs.GetInt ("d") == 1) {
			Social.ReportProgress("death", 100.0, null);
		//	GameCenterBinding.reportAchievement ("death", 100);
			PlayerPrefs.SetInt ("d", 2);
			StopCoroutine ("death");
		}
	}

	public void timewaster ()
	{

		if (PlayerPrefs.GetInt ("tw") == 1) {
			Social.ReportProgress("timewaster", 100.0, null);
		//	GameCenterBinding.reportAchievement ("timewaster", 100);
			PlayerPrefs.SetInt ("tw", 2);
			StopCoroutine ("timewaster");
		}
	}
}
