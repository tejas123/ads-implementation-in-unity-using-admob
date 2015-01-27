using UnityEngine;
using System.Collections.Generic;
using Prime31;


public class AdMobGUIManager : MonoBehaviourGUI
{
#if UNITY_IPHONE

	void OnGUI()
	{
		beginColumn();


		if( GUILayout.Button( "Initialize AdMob" ) )
		{
			// add your test devices
			AdMobBinding.setTestDevices( new string[] { "<DEVICE_ID>", "DEVICE_ID" } );
			AdMobBinding.init( "YOUR_PUBLISHER_ID", true );
		}


		if( GUILayout.Button( "Destroy Banner" ) )
		{
			AdMobBinding.destroyBanner();
		}


		if( GUILayout.Button( "Portrait Smart Banner (top right)" ) )
		{
			AdMobBinding.createBanner( AdMobBannerType.SmartBannerPortrait, AdMobAdPosition.TopRight );
		}


		if( GUILayout.Button( "Landscape Smart Banner (bottom)" ) )
		{
			AdMobBinding.createBanner( AdMobBannerType.SmartBannerLandscape, AdMobAdPosition.BottomCenter );
		}


		if( iPhone.generation != iPhoneGeneration.iPad1Gen && iPhone.generation != iPhoneGeneration.iPad2Gen
			&& iPhone.generation != iPhoneGeneration.iPad3Gen && iPhone.generation != iPhoneGeneration.iPad4Gen && iPhone.generation != iPhoneGeneration.iPadMini1Gen )
		{
			if( GUILayout.Button( "320x50 Banner (bottom right)" ) )
			{
				// replace the adUnitId with your own!
				AdMobBinding.createBanner( "BANNER_ID", AdMobBannerType.iPhone_320x50, AdMobAdPosition.BottomRight );
			}
		}
		else
		{
			if( GUILayout.Button( "320x250 Banner (bottom)" ) )
			{
				// replace the adUnitId with your own!
				AdMobBinding.createBanner( "BANNER_ID", AdMobBannerType.iPad_320x250, AdMobAdPosition.BottomCenter );
			}


			if( GUILayout.Button( "468x60 Banner (top)" ) )
			{
				AdMobBinding.createBanner( AdMobBannerType.iPad_468x60, AdMobAdPosition.TopCenter );
			}


			if( GUILayout.Button( "728x90 Banner (bottom)" ) )
			{
				AdMobBinding.createBanner( AdMobBannerType.iPad_728x90, AdMobAdPosition.BottomCenter );
			}
		}


		endColumn( true );


		if( GUILayout.Button( "Request Interstitial" ) )
		{
			// replace the adUnitId with your own!
			AdMobBinding.requestInterstital( "INTERSTITIAL_ID" );
		}


		if( GUILayout.Button( "Is Interstial Loaded?" ) )
		{
			Debug.Log( "is interstitial loaded: " + AdMobBinding.isInterstitialAdReady() );
		}


		if( GUILayout.Button( "Show Interstitial" ) )
		{
			AdMobBinding.displayInterstital();
		}

		endColumn();
	}
#endif
}
