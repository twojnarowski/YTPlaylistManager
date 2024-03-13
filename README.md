# YT Playlist Manager
The idea of this application is to allow users to have more options of controlling, managing, editing and sorting their YT playlist than what YT provides.
Taking part in the [100commitow](https://100commitow.pl/) competition.

## The roadmap
- ~~Add login via Google/YT Account~~
- ~~Fix default Identity pages to match my needs~~
  - ~~Leavy only google login, with nice button~~
  - ~~Don't allow other logins, data access, etc.~~
- Show playlists of a user
  - Set up YT API access
  - Download a list of playlists and display just the names with links
- ~~Add nice component library with beautiful UI~~
  - ~~Change the UI to match YT color scheme~~
  - ~~Add nicer font~~
  - Add AI generated cool logo
- Edit playlists (name, description, etc)
- Manage user account - change data, download data, remove data
- Sort playlist by:
  - default options  
  - video length
- Add scheduled sorting
  - Add Hangfire to the application
  - Get a test server to run the application constantly
  - Allow user to select one playlist to be sorted daily by the app, by his criteria of sorting
- Remove duplicates
- Add some tests????
- Remove deleted videos
- Remove unavailable videos in your region
- Get suggestions on what to watch next
- Automatically add new videos from subsscribtions to watch-later
- Warnings about lists being almost full
