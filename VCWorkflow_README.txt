---Working around Version Control Unity Limitations---

-make sure version control for meta is enabled in project settings
-when pushing a full project update, send assets to a zip file and project settings to a zip file, push and commit these zip files
-to download and run an update pulled from git, download and unzip asset and project settings files (make sure the most up to date version is downloaded), then replace the folders in your existing Unity project iteration with the updated unzipped folders in File explorer
-Run the updated Unity project by opening the scene within the assets folder
-Be sure to communicate with team members about the settings changes you made in the notes on each commit, so as to alert team members to potential merging issues
-make sure all team members involved with project settings within Unity are properly notified when an update is pushed so that no accidental merging issues arise