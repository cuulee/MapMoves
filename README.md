Simple app to check Moves app history in Unity.

![][image-1]

### How to install:

1. Download Unity project
2. Download [Json .NET for unity][1] and place it in `Assets` folder
3. Download [Unity standalone file browser][2] and place it in Assets folder 
3. Export your data from [Moves website][3] (Sign in -\> Export data), then move `json/full/storyline.json` from downloaded package into `Assets/Resources` folder of Unity project
4. Run the app

### Current features:
- Display Moves storyline data with summary
- Display map with all path drawn
- Activity filters
- Activity history display
- Detailed place info (place address, visiting hours, visiting weekdays, custom icons)
- Places search
- Google maps integration
- Press `S` to save places icons
### Planned features:
- Support for Arc app GPX
- Calendar view to change day
- Favourite/Top visited places
- Date range filters
- Save range filter as event
- Maps display optimisation

### Used APIs:
- Google maps api to get location address.  
	Create file `Assets/Resources/API/GoogleApi.txt` and paste your Google Geocoding API key there

[1]:	https://assetstore.unity.com/packages/tools/input-management/json-net-for-unity-11347
[2]:	https://github.com/gkngkc/UnityStandaloneFileBrowser
[3]:	http://moves-app.com

[image-1]:	https://i.imgur.com/CUnrJNt.png