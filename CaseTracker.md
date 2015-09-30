# What does CaseTracker do? #

Helps you keep track of the time you spent on FogBugz cases.

In essence, it's like the web interface tracker that's built into FogBugz, but having it as a Windows Desktop application (always on top and much quicker and more responsive) is the main advantage.

# Features #
  * Switch between cases (and "nothing") in two clicks. Enabled very fine-grained time tracking for cases.
  * **New:** Auto-away feature stops tracking while you're away from your machine (configurable).
  * Filter cases according to a search query, and remembers search history.
  * One-click operations on tracked cases: Resolve, Edit Estimate, Close, View in Browser, View Outline, New Sub-Case.
  * **New:** Quick "Add Estimate" ability for cases with no estimates
  * Export the current list of cases (according to search filter) into Excel (a CSV really), in a format that's compatible also with MS Project (just copy paste it).
  * **New:** Export a list of cases as a Mind-Map (FreeMind format).
  * The application is written around a C# wrapper API we wrote for the FogBugz web service interface. So if you want to code your own client, feel free to reuse this independent library (FogBugz.cs).
# Screenshots #
<img src='http://visionmap.googlecode.com/svn/trunk/WebSite/images/caseTracker_menu.png'>
<h1>How do I use CaseTracker?</h1>
</li></ul><ol><li>Install and run<br>
<ol><li>Requires <a href='http://www.microsoft.com/downloads/details.aspx?familyid=0856eacb-4362-4b0d-8edd-aab15c5e04f5&displaylang=en#Overview,'>Microsoft .Net Framework 2.0</a> or newer.<br>
</li></ol></li><li>Login with username/password, and make sure you supply the correct link to your (company's) FogBugz location. e.g. <code>http://www.[some-company].com/FogBugz</code>
</li><li>Remember that you can only track cases for which you've given estimates. Case Tracker will remind you of this if/when you try to track a case with no estimate.<br>
</li><li>Click on the filter button and specify your desired search filer. e.g. <code>AssignedTo:Me Project:TPS Area:Reports</code>
</li><li>Select that case you wish to work on, and that's it, the timer is ticking away. When you're done working on it, or just taking a break, click on the "(nothing)" case and the timer will stop.</li></ol>

Any questions/suggestions? Feel free to post them on the VisionMap forum, email us, or open an issue using the issue tracker.<br>
<br>
<h1>[Download](http://code.google.com/p/visionmap/downloads/list) #
# ReleaseHistory #
# Contributing to Case Tracker #
If you wish to contribute code to the project please subscribe to [the project's Google Group](http://groups.google.com/group/casetracker-dev) where all discussions of future development take place.