# dekokJSayHelloEndpoint
// Jacob Dekok
// 10/25/2022
// Say Hello Endpoint
// This will take user input in the url bar
// and output saying hello
// Peer Reviewed by: Mark A Ramirez: says hello and then my name.

DOWNLOAD INSTRUCTIONS:
To use and test this program you must first download it from git hub.
Click the green button on top of the filess, that says "Code" and copy the Https
URL it gives you. Assuming you use visual studio and have the correct extentions
installed, you can open up a fresh window and click the "Clone git repository...".
Paste the Https URL into the URL bar, and select "Clone from URL". Finally select
the floder you'd like to use, and you're all set.

HOW TO RUN:
Assuming that you have it installed, you can now start debugging. Once visual studio
finishes debugging, your default browser should open up to a page. It should say
something like "This localhost page can’t be found", don't worry that's okay. Go to
the URL bar and copy the whole URL. It should be something like "https://localhost:7180".
Assuming you use an API platform, you can copy the URL into a workspace. Look at the
names of the controller files, and add the name of the file you'd like to test to the end
of the URL. Remember to put a "/" in front and ingore the "Controller.cs" at the end of the
file name. For this specific program the Controller file name would be "SayHello". To finish
off the URL we need to add a route. If you look into the Controller file you'd like to run,
you should see something like [HttpGet] and [Route("...")]. You'd want to find the route
you would like to test and copy the text inside the Route quotations, "", into the URL,
after a "/" of course. Where you see the squiggly braces "{}" you can change those to
fit your variable needs. For this specific program the URL might look like this
"https://localhost:7180/SayHello/Hello/Mike".
