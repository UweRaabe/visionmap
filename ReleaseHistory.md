# Case Tracker Release History #
## v1.4.2 (2010-04-21) ##
  * FIX: Several issues regarding saving user settings to registry were fixed. Users of v1.4.0 should update.
  * FIX: Various improvements to usability and responsiveness
  * FEATURE: More information in active case's tooltip (estimate, elapsed %)
## v1.4.0 (2010-04-05) ##
  * FEATURE: Window can be dragged even when paused.
  * FEATURE: Option to stop working when Case Tracker exists.
  * FIX: Casting exception when using locales under which (Nothing) isn't first on the case list.
  * FIX: Filter window thoroughly debugged.
  * FIX: Search syntax link doesn't work.
## v1.3.2.185 (2009-09-24) ##
  * FEATURE: "Stop Work" button, instead of having to select "(nothing)" from the drop-down.
  * FEATURE: Can configure how frequently to refresh the case list.
  * FEATURE: Esc closes (cancels) all dialogs.
  * FIX: Parsing error when running under Norwegian locale. Now everything runs as en-US.
  * FIX: Improved performance. More async queries and much faster case-switching.
  * FIX: "Include Cases Without Estimates" in the Filter dialog now actually works.
## v1.3.1.170 (2009-09-07) ##
  * HOTFIX: Case Tracker "forgot" the user name when exiting, resulting in a login failure when rerun.
## v1.3.0.164 (2009-09-06) ##
  * FEATURE: UI to provide estimates for cases
  * FEATURE: Settings dialog allows to control window opacity and font
  * FEATURE: View current case's outline in the browser
  * FEATURE: Auto-away feature
  * FEATURE: "About" dialog added
  * FIX: Search filter only runs query once (reuses results to populate main window when closed)
  * FIX: Support for various multi-monitor configurations (not just horizontal)
  * Various UI aesthetic improvements, new icons, redesign of filter window, etc.
  * A special thanks to James Barrass who contributed ideas and code to this release
## v1.2.2.133 (2009-08-26) ##
  * Reorganized main menu into groups
  * Added "New Sub-Case" button (to create a sub case of the current case)
  * Disabled FreeMind Import feature, since it's not quite ready yet
## v1.2.1.120 (2009-08-18) ##
  * Added Seach History for filter page (remembers your last 20 filters)
  * UI Enhancement - disabled buttons are now grey
  * Some bug fixes from last release
## v1.2.1.103 (2009-08-17) ##
  * Added Pause button (stops the clock while you're away)
  * Auto version update from now on
## v1.1.0.60 (2009-07-30) ##
**Compatible with FogBugz v7 or Newer**
  * Added button for Export To [FreeMind](http://freemind.sourceforge.net/wiki/index.php/Main_Page) (you'll need [FreeMind](http://freemind.sourceforge.net/wiki/index.php/Main_Page) installed)
  * The mandatory filter can now be ignored via a check box in the filter window
  * Lots of refactoring and code cleanup
[Download v1.1.0.60](http://visionmap.googlecode.com/files/CaseTracker-1.1.0.60-setup.exe)
## v1.0.0.40 (2009-04-06) ##
First major version
  * Compatible with FogBugz 6 & 7
[Download v1.1.0.60](http://visionmap.googlecode.com/files/CaseTracker-1.0.0.40-setup.exe)