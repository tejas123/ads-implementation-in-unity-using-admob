using UnityEngine;
using System.Collections;
using Prime31;


public class AdMobComboUI : MonoBehaviourGUI
{
#if UNITY_ANDROID || UNITY_IPHONE
	void OnGUI()
	{
		beginColumn();


		if( GUILayout.Button( "Init" ) )
		{
			AdMob.init ("ANDROID_PUBLISHER_ID", "IOS_PUBLISHER_ID");
		}

		if( GUILayout.Button( "Set Test Devices" ) )
		{
			AdMob.setTestDevices( new string[] { "<DEVICE_ID>", "DEVICE_ID", "DEVICE_ID", "DEVICE_ID" } );
		}

		if( GUILayout.Button( "Create Smart Banner" ) )
		{
			// place it on the top
//			AdMob.createBanner( AdMobBanner.SmartBanner, AdMobLocation.BottomCenter );
			AdMob.createBanner ("ANDROID_ID", "IOS_ID", AdMobBanner.SmartBanner, AdMobLocation.BottomCenter);
		}


		if( GUILayout.Button( "Create 320x50 banner" ) )
		{
			// place it on the top
			AdMob.createBanner( AdMobBanner.Phone_320x50, AdMobLocation.TopCenter );
		}


		if( GUILayout.Button( "Create 300x250 banner" ) )
		{
			// center it on the top
			AdMob.createBanner( AdMobBanner.Tablet_300x250, AdMobLocation.BottomCenter );
		}


		if( GUILayout.Button( "Destroy Banner" ) )
		{
			AdMob.destroyBanner();
		}


		endColumn( true );


		if( GUILayout.Button( "Request Interstitial" ) )
		{
//			AdMob.requestInterstital( "ca-app-pub-1625797239515514/5150481381", "ca-app-pub-1625797239515514/5010880580 " );
			AdMob.requestInterstital ("ANDROID_ID", "IOS_ID");
		}


		if( GUILayout.Button( "Is Interstitial Ready?" ) )
		{
			var isReady = AdMob.isInterstitalReady();
			Debug.Log( "is interstitial ready? " + isReady );
		}


		if( GUILayout.Button( "Display Interstitial" ) )
		{
			AdMob.displayInterstital();
		}

		endColumn();
	}



	#region Optional: Example of Subscribing to All Events

	void OnEnable()
	{
		AdMob.receivedAdEvent += receivedAdEvent;
		AdMob.failedToReceiveAdEvent += failedToReceiveAdEvent;
		AdMob.interstitialReceivedAdEvent += interstitialReceivedAdEvent;
		AdMob.interstitialFailedToReceiveAdEvent += interstitialFailedToReceiveAdEvent;
	}

	void OnDisable()
	{
		AdMob.receivedAdEvent += receivedAdEvent;
		AdMob.failedToReceiveAdEvent += failedToReceiveAdEvent;
		AdMob.interstitialReceivedAdEvent += interstitialReceivedAdEvent;
		AdMob.interstitialFailedToReceiveAdEvent += interstitialFailedToReceiveAdEvent;
	}


	void receivedAdEvent()
	{
		Debug.Log( "receivedAdEvent" );
	}


	void failedToReceiveAdEvent( string error )
	{
		Debug.Log( "failedToReceiveAdEvent: " + error );
	}


	void interstitialReceivedAdEvent()
	{
		Debug.Log( "interstitialReceivedAdEvent" );
	}


	void interstitialFailedToReceiveAdEvent( string error )
	{
		Debug.Log( "interstitialFailedToReceiveAdEvent: " + error );
	}

	#endregion

#endif
}
